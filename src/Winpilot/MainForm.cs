using Interop;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views;
using Walks;

namespace Winpilot
{
    public partial class MainForm : Form
    {
        private int selectedButtonIndex = -1; // Initialize clippyLogicHandler with an invalid index

        public WebView2 WebView => webView;
        private ClippyConversationHandler clippyConversationHandler;
        private ClippyLogicHandler clippyLogicHandler;
        private List<WalksBase> coTweaker;
        public Control INavPage;

        public MainForm()
        {
            InitializeComponent();

            // Set default NavPage
            Views.SwitchView.INavPage = pnlForm.Controls[0];
            Views.SwitchView.mainForm = this;
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            // Init WebView
            await InitializeWebView();
        }

        private async Task InitializeWebView()
        {
            Panel pnlForm = new Panel
            {
                Dock = DockStyle.Fill,
                Parent = pnlMain,
            };

            webView = new WebView2
            {
                Dock = DockStyle.Fill,
                Parent = pnlForm,
            };

            await webView.EnsureCoreWebView2Async(null);

            webView.CoreWebView2.WebMessageReceived += (sender, e) =>
            {
                var message = e.TryGetWebMessageAsString();
                UpdateCheckboxState(message);
            };

            await LoadHtmlContent();

            // Attach event handler to open links in default system browser
            webView.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
            // Disable default context menus
            webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            // Ssubscribe to KeyDown event of the WebView to capture the ESC key press
            WebView.KeyDown += WebView_KeyDown;
        }

        private async Task LoadHtmlContent()
        {
            try
            {
                // Default theme preference
                bool isDarkMode = false;

                // Check if the settings.txt file exists in "app" directory
                string darkModeFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app", "settings.txt");
                if (File.Exists(darkModeFilePath))
                {
                    // Determine theme preference
                    string fileContent = File.ReadAllText(darkModeFilePath);
                    if (fileContent.Contains("Theme=1"))
                    {
                        // If file indicates dark mode, enable dark mode
                        isDarkMode = true;
                    }
                }
                else
                {
                    // If file doesn't exist or contain theme preference, default to light mode
                    isDarkMode = false;

                    // Write default theme preference to settings file
                    File.WriteAllText(darkModeFilePath, isDarkMode ? "Theme=1" : "Theme=0");
                }

                // Construct full file paths for HTML, CSS, JS files
                string htmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app", "frontend.html");
                string cssFilePath = isDarkMode ? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app", "ui_dark.css") : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app", "ui.css");
                string jsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app", "backend.js");

                // Get all PNG files with "clippy" in their names
                string[] clippyImagePaths = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app"), "*chatbot*.png");

                // Select a random clippy image
                Random random = new Random();
                string randomClippyImagePath = clippyImagePaths[random.Next(clippyImagePaths.Length)];

                async Task<string> ReadFileAsync(string filePath)
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        return await reader.ReadToEndAsync();
                    }
                }

                string htmlContent = await ReadFileAsync(htmlFilePath);
                string cssContent = await ReadFileAsync(cssFilePath);
                string jsContent = await ReadFileAsync(jsFilePath);

                // Read the image file as bytes
                byte[] imageBytes = File.ReadAllBytes(randomClippyImagePath);

                // Convert the image bytes to a base64 string
                string base64Image = Convert.ToBase64String(imageBytes);

                // Replace the placeholder with the image tag
                StringBuilder finalHtmlContentBuilder = new StringBuilder(htmlContent);
                finalHtmlContentBuilder.Replace("</head>", $"<style>{cssContent}</style><script>{jsContent}</script></head>");
                finalHtmlContentBuilder.Replace("<div id=\"clippy-container\">", $"<div id=\"clippy-container\"><img src=\"data:image/png;base64,{base64Image}\" alt=\"Microsoft Clippy\">");

                string finalHtmlContent = finalHtmlContentBuilder.ToString();

                // Subscribe to NavigationCompleted event before navigating
                webView.CoreWebView2.NavigationCompleted += WebView_NavigationCompleted;

                // Navigate to modified HTML content
                webView.CoreWebView2.NavigateToString(finalHtmlContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading frontend: {ex.Message}");
            }
        }

        private void ToggleDarkLightMode()
        {
            try
            {
                string darkModeFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app", "settings.txt");
                if (File.Exists(darkModeFilePath))
                {
                    string fileContent = File.ReadAllText(darkModeFilePath);
                    // Toggle theme preference
                    bool isDarkMode = fileContent.Contains("Theme=1");
                    isDarkMode = !isDarkMode;

                    // Write the updated theme preference to settings file
                    File.WriteAllText(darkModeFilePath, isDarkMode ? "Theme=1" : "Theme=0");
                }
                else
                {
                    // If settings file doesn't exist, create it with light mode enabled
                    File.WriteAllText(darkModeFilePath, "Theme=0");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error toggling mode: {ex.Message}");
            }
        }

        private async void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            // Disable the form and all controls
            this.Enabled = false;

            try
            {
                // Unsubscribe from event to avoid handling it multiple times
                webView.CoreWebView2.NavigationCompleted -= WebView_NavigationCompleted;

                // Initialize global fields
                Logger logger = new Logger(webView);
                clippyLogicHandler = new ClippyLogicHandler(this, logger);

                // Load static AI Data
                await clippyLogicHandler.LoadAnswersFromJson();  // Initialize answers and actions
                await clippyLogicHandler.LoadButtonsFromJson();  // Clipppys assistant buttons
                await clippyLogicHandler.LoadChatboxQuestions(); // Clippys chatbox autocomplete
                await clippyLogicHandler.LoadExtensions();       // Generate plugin categories

                // Add static Clippy sayings
                clippyConversationHandler = new ClippyConversationHandler(this, new Logger(webView));
                clippyConversationHandler.ShowPseudoAISayings();

                // Load Privacy and system dashboard
                InitializeCotweaker();
            }
            finally
            {
                // Re-enable the form and all controls
                this.Enabled = true;
            }
        }

        // Open new window request in default system browser
        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = e.Uri,
                UseShellExecute = true
            });

            // Cancel new window request within WebView2
            e.Handled = true;
        }

        // Initiliaze Plugin CoTweaker
        private void InitializeCotweaker()
        {
            var logger = new Logger(webView);
            coTweaker = new List<WalksBase>
            {
                // Ads
                new StartmenuAds(this,logger),
                new PersonalizedAds(this,logger),
                new WelcomeExperienceAds(this,logger),
                new FinishSetupAds(this,logger),
                new TipsAndSuggestions(this,logger),
                new SettingsAds(this,logger),
                new LockScreenAds(this,logger),
                new FileExplorerAds(this,logger),
                new TailoredExperiences(this,logger),

                // Privacy
                new BackgroundApps(this,logger),
                new DiagnosticData(this,logger),
                new FindMyDevice(this,logger),
                new PrivacyExperience(this,logger),
                new Telemetry(this,logger),

                // System
                new FullContextMenus(this,logger),
                new LockScreen(this,logger),
                new VerboseMessages(this,logger),
                new FaxPrinter(this,logger),
                new XPSWriter(this,logger),

                // Gaming
                new VisualFX(this,logger),
                new GameDVR(this,logger),
                new PowerThrottling(this,logger),

                // Taskbar and Start Menu
                new BingSearch(this,logger),
                new MostUsedApps(this,logger),
                new StartmenuLayout(this,logger),
                new TaskbarChat(this,logger),
                new TaskView(this,logger),

               // AI/Copilot
               new CopilotMSEdge(this,logger),
               new CopilotTaskbar(this,logger),
            };
        }

        private void UpdateCheckboxState(string message)
        {
            Logger logger = new Logger(webView);

            try
            {
                // Log received message for debugging
                //Console.WriteLine($"Received message: {message}");

                // Check if message is a valid JSON format
                if (message.StartsWith("{") && message.EndsWith("}"))
                {
                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(message);

                    // Log deserialized data for debugging
                    // Console.WriteLine($"Deserialized data: {Newtonsoft.Json.JsonConvert.SerializeObject(data)}");

                    // Remove selected AppxPackages
                    if (data.ContainsKey("action") && data["action"].ToString() == "removeSelectedPackages")
                    {
                        AppxPackages appxPackages = new AppxPackages(this, new Logger(webView));
                        appxPackages.HandleRemoveSelectedPackages(message, appxPackages);
                    }

                    // Check if JSON data contains expected properties
                    if (data.ContainsKey("action") && data.ContainsKey("checkboxes"))
                    {
                        var action = data["action"].ToString();
                        var checkboxes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CheckboxInfo>>(data["checkboxes"].ToString());

                        // Log checkboxes for debugging
                        // Console.WriteLine($"Checkboxes: {Newtonsoft.Json.JsonConvert.SerializeObject(checkboxes)}");

                        // Plugin CoTweaker > Check, Enable, Disable
                        if (action == "search")
                        {
                            SearchAction();
                            logger.Log("✔️ System scan complete. Configuration auto-detected and loaded.", Color.Blue);
                        }
                        else
                        {
                            foreach (var checkboxInfo in checkboxes)
                            {
                                var dashboardClass = coTweaker.FirstOrDefault(tc => tc.ID() == checkboxInfo.Id);

                                if (dashboardClass != null)
                                {
                                    if (action == "enable" && checkboxInfo.Checked)
                                    {
                                        dashboardClass.DoFeature();
                                        logger.Log($"Enabled - {checkboxInfo.Id}", Color.Green);
                                    }
                                    else if (action == "disable" && !checkboxInfo.Checked) // Ensure the checkbox is unchecked to disable the feature
                                    {
                                        dashboardClass.UndoFeature();
                                        logger.Log($"Disabled - {checkboxInfo.Id}", Color.Red);
                                    }
                                }
                            }
                        }
                        // Plugin WingetUI > Install Selected Apps
                        if (action == "installSelectedApps")
                        {
                            InstallWingetAppsAction(checkboxes);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid JSON format. Missing required properties.");
                        Console.WriteLine($"Message content: {message}");
                    }
                }
                else
                {
                    // Handle non-JSON content (e.g. Walks classes for opening URI/Settings pages, checking updates etc.)
                    HandleNonJsonMessage(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing JSON: {ex.Message}");
                Console.WriteLine($"Message content: {message}");
            }
        }

        // Avoid trying to deserialize non-JSON content: If message is not a valid JSON format, it will be treated as a non-JSON message
        // e.g.  the message content is just the string "checkAppUpdates", which is not a valid JSON format
        private async void HandleNonJsonMessage(string message)
        {
            Logger logger = new Logger(webView);

            // Instantiate Feature classes with logger
            WalksBase appCustomCrapware = new CAppxPackages(this, logger);
            AIFeaturesHandler aiFeaturesHandler = new AIFeaturesHandler(logger);
            ClippyDataHandler clippyDataHandler = new ClippyDataHandler(logger);

            // Handle non-JSON content (e.g., interop classes)
            switch (message)
            {
                case "tiny11maker":
                    clippyDataHandler.Tiny11Maker();
                    break;

                // Back button
                case "goBack":
                    await LoadHtmlContent();
                    break;

                // Toggle Dark/Light mode
                case "toggleDarkLightMode":
                    ToggleDarkLightMode();
                    await LoadHtmlContent();
                    break;

                // Open Settings (About this app)
                case "openSettings":
                    OpenSettings();
                    break;

                case "checkAppUpdates":
                    CheckForAppUpdates();
                    break;

                // Search for AI in CoTweaker
                case "plugCopilotless":
                    aiFeaturesHandler.CheckAIFeatures();
                    break;

                // Show Clippy's AI sayings
                case "plugClippySupreme":
                    clippyConversationHandler.ShowPseudoAISayings();
                    break;

                // Refresh Assisted buttons
                case "refreshAB":
                    await clippyLogicHandler.LoadAnswersFromJson();  // Initialize answers and actions
                    await clippyLogicHandler.LoadButtonsFromJson();  // Random buttons
                    await clippyLogicHandler.LoadChatboxQuestions(); // Chatbox autocomplete
                    break;

                // Appx Uninstaller
                case "searchCustomCrapware":
                    appCustomCrapware.CheckFeature();
                    break;

                case "removeCustomCrapware":
                    appCustomCrapware.DoFeature();
                    break;

                // Assisted Buttons
                case var msg when msg.StartsWith("showAnswerForButtons:"):
                    if (int.TryParse(msg.Split(':')[1], out selectedButtonIndex))
                    {
                        // logger.Log($"Selected button index: {selectedButtonIndex}", Color.Green);
                        clippyLogicHandler.ShowAnswerForButtons(selectedButtonIndex);
                    }
                    else
                    {
                        logger.Log("Invalid dropdown index format.", Color.Red);
                    }
                    break;

                // Handle plugin entries
                case var msg when msg.StartsWith("showAnswerForPlugin:"):
                    string question = msg.Substring("showAnswerForPlugin:".Length);
                    clippyLogicHandler.ShowAnswerForPlugin(question);
                    break;

                case var installMsg when installMsg.StartsWith("installPlugin:"):
                    string[] installParts = installMsg.Split(':');
                    if (installParts.Length >= 4)
                    {
                        string pluginName = installParts[1];
                        string downloadUrl = installParts[3].TrimStart('/'); // remove any leading slashes from the URL.

                        // Check if the URL starts with "https://" or "http://" and add it if missing
                        if (!downloadUrl.StartsWith("https://") && !downloadUrl.StartsWith("http://"))
                        {
                            downloadUrl = "https://" + downloadUrl;
                        }

                        logger.Log($"Attempting to install plugin '{pluginName}' from URL: {downloadUrl}", Color.Blue); // Add this line for logging
                        await clippyLogicHandler.InstallPlugin(pluginName, downloadUrl); // Pass downloadUrl
                    }
                    break;

                // Assited Chatbox which handle autocomplete-related messages
                case var msg when msg.StartsWith("showAnswerForChatbox:"):
                    string selectedQuestion = msg.Split(':')[1];
                    clippyLogicHandler.ShowAnswerForChatbox(selectedQuestion);
                    break;

                default:
                    MessageBox.Show($"Unhandled non-JSON message: {message}");
                    break;
            }
        }

        private async Task RunPowerShellScript()
        {
            Logger logger = new Logger(webView);
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-ExecutionPolicy Bypass -File \"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Downloads", "tiny11maker.ps1")}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = Process.Start(psi);
            await process.WaitForExitAsync();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            if (!string.IsNullOrEmpty(error))
            {
                logger.Log($"Error running PowerShell script: {error}", Color.Red);
            }
            else
            {
                logger.Log($"PowerShell script executed successfully: {output}", Color.Green);
            }
        }

        // Plugin WingetUI > Install Selected Apps
        private void InstallWingetAppsAction(List<CheckboxInfo> checkboxes)
        {
            Logger logger = new Logger(webView);

            foreach (var checkbox in checkboxes)
            {
                // Update IsChecked property based on Checked property
                checkbox.IsChecked = checkbox.Checked;

                // Check if the checkbox is selected using IsChecked property
                if (checkbox.IsChecked)
                {
                    // Instantiate AppPackages class with logger and execute installation
                    InteropBase AppPackages = new AppPackages(this, logger, checkbox.Id, checkbox.WingetId);
                    AppPackages.Execute();
                }
            }
        }

        // Plugin CoTweaker > Check
        private void SearchAction()
        {
            try
            {
                /* Initialize ClippyConversationHandler
                ClippyConversationHandler clippyConversationHandler = new ClippyConversationHandler(this, new Logger(webView));
                clippyConversationHandler.Execute(); */

                var searchResults = new List<CheckboxInfo>();

                foreach (var dashboardClass in coTweaker)
                {
                    bool isInstalled = dashboardClass.CheckFeature();
                    searchResults.Add(new CheckboxInfo { Id = dashboardClass.ID(), Checked = isInstalled });
                    UpdateCheckboxStatus(dashboardClass.ID(), isInstalled);
                }

                // Convert searchResults to JSON and send it to JS
                var jsonResults = JsonConvert.SerializeObject(searchResults);
                webView.CoreWebView2.ExecuteScriptAsync($"searchResults({jsonResults});");
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error during SearchAction: " + ex.Message);
            }
        }

        // Plugin CoTweaker > Helper method to update toogle switch status
        private void UpdateCheckboxStatus(string id, bool isChecked)
        {
            var script = $"document.getElementById('{id}').checked = {isChecked.ToString().ToLower()};";
            script += $"updateLog('{id}', {isChecked.ToString().ToLower()});";

            // Append the log directly to the logContainer in the WebView
            // script += $"document.getElementById('logContainer').innerHTML += '{(isChecked ? "Enabled" : "Disabled")} - Feature ID {id}<br>';";

            webView.CoreWebView2.ExecuteScriptAsync(script);
        }

        // Toggle Switch/Checkbox information
        private class CheckboxInfo
        {
            public string Id { get; set; }
            public bool Checked { get; set; }
            public string WingetId { get; set; }
            public bool IsChecked { get; set; }
            public string CrapId { get; set; }
        }

        private void OpenSettings() => Views.SwitchView.SetView(new SettingsPageView());

        private void CheckForAppUpdates() => new UpdateSettings(this, new Logger(webView)).Execute();

        // Capture ESC key press to leave the current view/refresh the page
        private async void WebView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true; // Prevent further processing of ESC key
                await LoadHtmlContent();
            }
        }
    }
}