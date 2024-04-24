using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Winpilot;

namespace Interop
{
    public class Answer
    {
        public string Question { get; set; }
        public string Response { get; set; }
        public string Action { get; set; }
        public string DownloadUrl { get; set; }
        public string DownloadPath { get; set; }
        public string PowershellCommand { get; set; } // Ps
        public string Command { get; set; } // cmd
        public string DiskSpace { get; set; }
        public string AppPath { get; set; }
        public string ScriptPath { get; set; }
        public string PluginName { get; set; }
        public string GithubURL { get; set; }
        public string Category { get; set; } // Extensions plugin
        public string Description { get; set; } // Extensions plugin
        public Dictionary<string, string> DownloadUri { get; set; } // download handler  (e.g. multiple files, localizations)

        // Support for Vive tool (optional package)
        public string ViveCommand { get; set; }

        public string ViveFeatureId { get; set; }
        public string ViveBuildAvailability { get; set; }
    }

    public class ClippyLogicHandler : InteropBase
    {
        private MainForm form;
        private List<string> questions; // Chatbox questions list

        private List<Answer> answers;
        private ClippyDataHandler clippyDataHandler;
        private AppxPackages appxPackages;
        private ClippyConversationHandler clippyConversationHandler;
        private StorageSettings storageSettings;
        private DownloadHandler downloadHandler;
        private CommandsHandler commandHandler;
        private AIFeaturesHandler aiFeaturesHandler;

        private string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app", "staticAIData.json");

        public ClippyLogicHandler(MainForm form, Logger logger) : base(form, logger)
        {
            this.form = form;

            appxPackages = new AppxPackages(form, logger);
            clippyConversationHandler = new ClippyConversationHandler(form, logger);
            clippyDataHandler = new ClippyDataHandler(logger);
            storageSettings = new StorageSettings(logger);
            downloadHandler = new DownloadHandler(logger);
            commandHandler = new CommandsHandler(logger);
            aiFeaturesHandler = new AIFeaturesHandler(logger);
        }

        public override void Execute()
        { } // Just for abstraction

        public Task LoadAnswersFromJson()
        {
            return Task.Run(() =>
            {
                try
                {
                    string jsonContent = File.ReadAllText(jsonPath);
                    answers = JsonConvert.DeserializeObject<List<Answer>>(jsonContent);
                }
                catch (Exception ex)
                {
                    Logger.Log($"Error loading responses in staticAIData: {ex.Message}", Color.Red);
                }
            });
        }

        public async Task LoadChatboxQuestions()
        {
            try
            {
                questions = GetQuestionsFromJson();

                // Build HTML input with chatbox
                var chatboxHtml = new StringBuilder();
                chatboxHtml.AppendLine("<input type='text' id='chatbox' oninput='chatboxInputChanged()'>");

                // Inject HTML into WebView2 control
                await form.WebView.CoreWebView2.ExecuteScriptAsync(
                    "document.getElementById('chatbox-container').innerHTML = `" + chatboxHtml.ToString() + "`;");

                // Initialize chatbox functionality
                await form.WebView.CoreWebView2.ExecuteScriptAsync(
                    "var questions = " + JsonConvert.SerializeObject(questions) + ";" +
                    "chatbox(document.getElementById('chatbox'), questions);");
            }
            catch (Exception ex)
            {
                Logger.Log($"Error loading questions from staticAIData: {ex.Message}", Color.Red);
            }
        }

        public async Task LoadButtonsFromJson()
        {
            List<string> questions = GetQuestionsFromJson();

            // Shuffle list of indices and limit number of buttons
            Random random = new Random();
            var indices = Enumerable.Range(0, questions.Count).OrderBy(i => random.Next()).Take(6).ToList();

            // Build HTML buttons for first 6 randomly selected questions
            var buttonsHtml = new StringBuilder();
            foreach (int index in indices)
            {
                buttonsHtml.Append($"<button onclick='buttonClicked({index})'>{questions[index]}</button>");
            }

            // Inject HTML into WebView2 control
            await form.WebView.CoreWebView2.ExecuteScriptAsync(
                "document.getElementById('buttons-container').innerHTML = `" + buttonsHtml.ToString() + "`;");

            // Inject HTML content of random app packages in Pinned apps section
            string buttonsAppxHtml = await appxPackages.GetPinnedAppPackages();
            await form.WebView.CoreWebView2.ExecuteScriptAsync(
                "document.getElementById('buttonsAppx-container').innerHTML = `" + buttonsAppxHtml + "`;");
        }

        private List<string> GetQuestionsFromJson()
        {
            try
            {
                string jsonContent = File.ReadAllText(jsonPath);
                List<Answer> answers = JsonConvert.DeserializeObject<List<Answer>>(jsonContent);
                return answers.Select(answer => answer.Question).ToList();
            }
            catch (Exception ex)
            {
                Logger.Log($"Error loading questions in staticAIData from JSON: {ex.Message}", Color.Red);
                return new List<string>();
            }
        }

        // Assisted Chatbox
        public void ShowAnswerForChatbox(string selectedQuestion)
        {
            Logger.Log($"🤖🔥 Engaging AI Mode: Selected Inquiry for Chatbox: {selectedQuestion}", Color.Green);

            if (answers != null)
            {
                // Attempt to find an exact match with selectedQuestion
                var selectedAnswer = answers.FirstOrDefault(answer =>
                    answer.Question.Equals(selectedQuestion, StringComparison.OrdinalIgnoreCase));

                if (selectedAnswer != null)
                {
                    // Log response
                    Logger.Log($"Action for '{selectedQuestion}': {selectedAnswer.Action}", Color.Green);
                    Logger.Log(selectedAnswer.Response, Color.Magenta);

                    // Call common method to handle default staticAIData action
                    HandleAction(selectedAnswer);
                }
                else
                {
                    Logger.Log($"🤖 System Error: No precise match detected for '{selectedQuestion}' within the knowledge base. Searching the vast data banks for relevant information.", Color.Red);

                    // No matches? Show a result suggesting to open Copilot
                    var copilotSuggestion = new
                    {
                        Question = "Ask Copilot",
                        Response = "No matches found. Why not try asking Copilot?",
                        Action = "openCopilot"
                    };

                    // Log suggestion
                    Logger.Log($"Suggestion: {copilotSuggestion.Question}", Color.Yellow);
                    form.WebView.CoreWebView2.Navigate("https://copilot.microsoft.com/");
                }
            }
            else
            {
                Logger.Log("Answers list is not initialized.", Color.Red);
            }
        }

        // Assisted Buttons
        public void ShowAnswerForButtons(int index)
        {
            if (index >= 0 && index < answers.Count)
            {
                Answer selectedAnswer = answers[index];

                // Log response
                Logger.Log(selectedAnswer.Response, Color.Magenta);

                // Call common method to handle default staticAIData action
                HandleAction(selectedAnswer);
            }
            else
            {
                Logger.Log("Invalid index in staticAIData.", Color.Red);
            }
        }

        // Initialize Extensions plugin entries
        public async Task LoadExtensions()
        {
            List<string> hardcodedActions = new List<string> { "runStorageSense", "createRestorePoint" }; // Add hardcoded actions here

            try
            {
                // Load answers from the JSON file
                await LoadAnswersFromJson();

                // Filter entries by the "plugin" category
                var pluginEntries = answers.Where(a => a.Category == "Plugin").ToList();

                // Create HTML elements for each filtered entry
                var pluginHtml = new StringBuilder();
                foreach (var entry in pluginEntries)
                {
                    // Extract plugin name from scriptPath
                    string pluginName = Path.GetFileNameWithoutExtension(entry.ScriptPath);

                    // Check if the plugin is installed
                    bool isInstalled = IsPluginInstalled(pluginName);

                    // Check if the action is hardcoded
                    bool isHardcoded = hardcodedActions.Contains(entry.Action);

                    // Plugin entry box
                    pluginHtml.AppendLine("<div class='plugin-entry'>");
                    pluginHtml.AppendLine($"<h3>{entry.Question} {(isHardcoded ? "<span class='plugin-badge'>preinstalled</span>" : "")}</h3>");
                    pluginHtml.AppendLine($"<p>{entry.Description}</p>");

                    // Adjust button text based on installation status and hardcoded parameter
                    if (isInstalled || isHardcoded)
                    {
                        pluginHtml.AppendLine($"<button class='execute-button' onclick='executePluginEntry(\"{entry.Question}\")'>Run plugin</button>");
                    }
                    else
                    {
                        pluginHtml.AppendLine($"<button class='install-button' onclick='installPlugin(\"{pluginName}\", \"{entry.GithubURL}\")'>Install</button>");
                    }

                    pluginHtml.AppendLine("</div>");
                }

                // Inject the HTML elements into the container
                await form.WebView.CoreWebView2.ExecuteScriptAsync(
                    "document.getElementById('plugin-categories-container').innerHTML = `" + pluginHtml.ToString() + "`;");
            }
            catch (Exception ex)
            {
                // Log error if there's an issue displaying plugin entries
                Logger.Log($"Error displaying plugin entries: {ex.Message}", Color.Red);
            }
        }

        // Check if a Extension is installed
        private bool IsPluginInstalled(string pluginName)
        {
            // Placeholder logic: Check if the plugin's script file exists in the specified directory
            string pluginFilePath = Path.Combine("plugins", $"{pluginName}.ps1");
            return File.Exists(pluginFilePath);
        }

        public async Task InstallPlugin(string pluginName, string githubUrl)
        {
            try
            {
                // Extract filename from URL
                string fileName = Path.GetFileName(new Uri(githubUrl).AbsolutePath);

                string pluginsDirectory = "plugins";

                // Combine the plugins directory with the file name to get the full path
                string filePath = Path.Combine(pluginsDirectory, fileName);

                // Download file
                using (var client = new WebClient())
                {
                    await client.DownloadFileTaskAsync(githubUrl, filePath);
                }

                Logger.Log($"Plugin '{pluginName}' downloaded successfully.", Color.Green);
            }
            catch (Exception ex)
            {
                Logger.Log($"Error downloading plugin '{pluginName}': {ex.Message}", Color.Red);
                return;
            }

            // If download is successful, refresh plugin entries
            await LoadExtensions();
        }

        // Extensions plugin handler
        public void ShowAnswerForPlugin(string question)
        {
            // Find the corresponding entry based on the question
            Answer entry = answers.FirstOrDefault(a => a.Question == question);
            if (entry != null)
            {
                // Log response
                Logger.Log(entry.Response, Color.Magenta);

                // Call common method to handle default action
                HandleAction(entry);
            }
            else
            {
                Logger.Log($"Response for plugin question '{question}' in WinModder not found.", Color.Red);
            }
        }

        // Handler for staticAIData
        private async void HandleAction(Answer selectedAnswer)
        {
            // Trigger action based on specified action type
            switch (selectedAnswer.Action)
            {
                case "getFile":
                    string powershellCommand = $"Invoke-WebRequest -Uri '{selectedAnswer.DownloadUrl}' -OutFile \"{selectedAnswer.DownloadPath}\"";
                    commandHandler.ExecutePowerShellCommand(powershellCommand);
                    logger.Log($"Downloaded {selectedAnswer.DownloadPath} to your desktop.", Color.Green);
                    break;

                case "createRestorePoint":
                    commandHandler.ExecutePowerShellCommand(selectedAnswer.PowershellCommand);
                    break;

                case "runStorageSense":
                    await storageSettings.RunStorageSense();
                    break;

                case "showWindowsVersion":
                    await clippyDataHandler.ShowWindowsVersion();
                    break;

                case "showDiskSpace":
                    clippyDataHandler.ShowDiskSpace();
                    break;

                case "changeWallpaper":
                    InteropBase wallpaperSettings = new WallpaperSettings(form, logger);
                    wallpaperSettings.Execute();
                    break;

                case "toggleThemeMode":
                    InteropBase themeSettings = new ThemeSettings(form, logger);
                    themeSettings.Execute();
                    break;

                case "takeScreenshot":
                    clippyDataHandler.TakeScreenshot();
                    break;

                case "switchToAutostartTab":
                    clippyDataHandler.SwitchToAutostartTab();
                    break;

                case "openFile":
                    clippyDataHandler.OpenAppFromPackagesFolder(selectedAnswer.AppPath);
                    break;

                case "showHighRamProcesses":
                    clippyDataHandler.ShowProcessesWithHighRamUsage(thresholdMB: 200);
                    break;

                case "runWindowsDefenderScan":
                    await clippyDataHandler.RunWindowsDefenderScan();
                    break;

                case "ipCheck":
                    await clippyDataHandler.CheckIPAddress();
                    break;

                // Running command-prompts, e.g. REG
                case "shell":
                    await commandHandler.ExecuteShellCommand(selectedAnswer.Command);
                    break;
                // Running and interpreting PS commands
                case "runPS":
                    await commandHandler.RunPowerShellCommand(selectedAnswer.Command);
                    break;
                // Running and interpreting external PS files in plugins directory with PowerShell window in front
                // createNoWindow: true
                case "runPSFile":
                    await commandHandler.RunPowerShellScript(selectedAnswer.ScriptPath);
                    break;
                // Running and interpreting external PS files in plugins directory without visible PowerShell window in front
                // createNoWindow: false
                case "runPlugin":
                    commandHandler.ExecutePowerShellCommand(selectedAnswer.ScriptPath);
                    break;

                case "updateCheck":
                    UpdateSettings updateSettings = new UpdateSettings(form, logger);
                    updateSettings.RunWUpdateCheck();
                    break;

                // Here Winpilot plugins are called, trigger js functions to scroll to the respective sections
                case "plugCotweaker":
                    await form.WebView.CoreWebView2.ExecuteScriptAsync("activateStep('stepSystemHeader');");
                    break;

                case "plugDecrapify":
                    await form.WebView.CoreWebView2.ExecuteScriptAsync("activateStep('stepAppxHeader');");
                    break;

                case "plugWingetUI":
                    await form.WebView.CoreWebView2.ExecuteScriptAsync("activateStep('stepAppsHeader');");
                    break;

                case "plugCopilotless":
                    aiFeaturesHandler.CheckAIFeatures();
                    break;

                case "plugClippySupreme":
                    clippyConversationHandler.Execute();
                    break;

                // Localization handler
                case "translate":
                    string localeDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                    string targetDirectoryLocale = Path.Combine(localeDirectory, "app");

                    // Download files to target directory
                    await downloadHandler.DownloadFiles(selectedAnswer.DownloadUri, targetDirectoryLocale);
                    Logger.Log(selectedAnswer.Response, Color.Magenta);
                    break;

                // File downloader for e.g., plugins in plugins directory
                case "coDownload":
                    string filesDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                    string targetDirectoryPlugins = Path.Combine(filesDirectory, "plugins");
                    await downloadHandler.DownloadFiles(selectedAnswer.DownloadUri, targetDirectoryPlugins);
                    break;

                // Vive tool (optional package)
                case "viveTool":
                    string viveToolPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "\\plugins\\vivetool\\", "vivetool.exe");
                    string featureId = selectedAnswer.ViveFeatureId;

                    // Construct ViveTool command to enable feature
                    if (selectedAnswer.ViveCommand.Equals("enable", StringComparison.OrdinalIgnoreCase))
                    {
                        string viveToolCommand = $" /enable /id:{featureId}";
                        commandHandler.StartProcess(viveToolPath, viveToolCommand, true, createNoWindow: true);
                    }      // Construct ViveTool command to disable feature
                    else if (selectedAnswer.ViveCommand.Equals("disable", StringComparison.OrdinalIgnoreCase))
                    {
                        string viveToolCommand = $" /disable /id:{featureId}";
                        commandHandler.StartProcess(viveToolPath, viveToolCommand, true, createNoWindow: true);
                    }
                    Logger.Log($"Build Availability: {selectedAnswer.ViveBuildAvailability}", Color.MediumPurple);
                    break;

                // Default for running external processes, URIs and opening linkhandler
                default:
                    commandHandler.ExecuteSettingsURI(selectedAnswer.Action);
                    break;
            }
        }
    }
}