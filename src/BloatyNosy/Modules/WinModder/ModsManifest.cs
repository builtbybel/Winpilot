namespace BloatyNosy
{
    internal class ModsManifest
    {
        public ModsParser ini;
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public string DisplayName
        {
            get
            {
                return ini.ReadString("Info", "DisplayName");
            }
        }

        public string AboutScript
        {
            get
            {
                return ini.ReadString("Info", "AboutScript");
            }
        }

        public string Publisher
        {
            get
            {
                return ini.ReadString("Info", "Publisher");
            }
        }

        public string ConditionScript
        {
            get
            {
                return ini.ReadString("Info", "ConditionScript");
            }
        }

        public string ScriptLanguage
        {
            get
            {
                return ini.ReadString("Info", "ScriptLanguage");
            }
        }
    }
}