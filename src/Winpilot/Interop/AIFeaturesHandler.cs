using Winpilot;
using Microsoft.Win32;
using System;
using System.Drawing;

namespace Interop
{
    public class AIFeaturesHandler
    {
        private Logger logger;

        public AIFeaturesHandler(Logger logger)
        {
            this.logger = logger;
        }

        // Check if a Windows AI feature is enabled based on reg settings
        private bool IsWindowsAIFeatureEnabled(string registryPath, string valueName, int expectedValue)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath))
                {
                    if (key != null)
                    {
                        object value = key.GetValue(valueName);
                        if (value != null && int.TryParse(value.ToString(), out int result))
                        {
                            return result == expectedValue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Log($"Error reading registry: {ex.Message}", Color.Red);
            }
            return false;
        }

        // Check if Copilot AI in Microsoft Edge browser is enabled
        public bool IsCopilotInEdgeEnabled()
        {
            return IsWindowsAIFeatureEnabled(@"Software\Policies\Microsoft\Edge", "HubsSidebarEnabled", 1);
        }

        // Check if Copilot AI in taskbar is enabled
        public bool IsCopilotInTaskbarEnabled()
        {
            return !IsWindowsAIFeatureEnabled(@"Software\Policies\Microsoft\Windows", "TurnOffWindowsCopilot", 1);
        }

        // Method to get the color based on AI feature status
        public Color GetColorForAIFeature(bool featureEnabled)
        {
            return featureEnabled ? Color.Red : Color.DarkGreen;
        }

        public void CheckAIFeatures()
        {
            bool copilotInEdgeEnabled = IsCopilotInEdgeEnabled();
            logger.Log(copilotInEdgeEnabled ? "Copilot AI in Microsoft Edge browser is enabled." : "Copilot AI in Microsoft Edge browser is not enabled.", GetColorForAIFeature(copilotInEdgeEnabled));

            bool copilotInTaskbarEnabled = IsCopilotInTaskbarEnabled();
            logger.Log(copilotInTaskbarEnabled ? "Copilot AI in the taskbar is enabled." : "Copilot AI in the taskbar is not enabled.", GetColorForAIFeature(copilotInTaskbarEnabled));


            logger.Log("We've also spotted AI integration in the Microsoft Paint and Notepad apps and assisted AI in Winpilot.", Color.Gray);
        }
    }
}