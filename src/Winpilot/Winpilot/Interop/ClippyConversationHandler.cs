// Obsolete: Remove Intelligent/ AI Actions

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Winpilot;

namespace Interop
{
    public class ClippyConversationHandler : InteropBase
    {
        private readonly Random random = new Random();
        private readonly List<string> clippySayings;
        private readonly List<string> aiSayings;

        public ClippyConversationHandler(MainForm form, Logger logger) : base(form, logger)
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app", "clippySayings.json");

            string jsonContent = File.ReadAllText(jsonFilePath);
            var jsonData = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonContent);
            clippySayings = jsonData["clippySayings"];
            aiSayings = jsonData["aiSayings"];
        }

        // Clippy's Windows tips
        public override void Execute()
        {
            int index = random.Next(clippySayings.Count);
            string saying = clippySayings[index];

            Logger.Log($"Clippy tip: {saying}", Color.Blue);
        }

        // Clippy's random fun sayings
        public void ShowPseudoAISayings()
        {
            int index = random.Next(aiSayings.Count);
            string saying = aiSayings[index];

            Logger.Log($"{saying}", Color.Black);
        }
    }
}