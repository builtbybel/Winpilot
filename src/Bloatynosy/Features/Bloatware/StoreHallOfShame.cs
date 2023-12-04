using System.Collections.Generic;

namespace Bloatynosy
{
    public static class BloatwareHallOfShame
    {
        // Our Windows 11 Hall Of Shame
        public static IEnumerable<string> GetList()
        {
            var apps = new List<string>
            {
                "BytedancePte.Ltd.TikTok",
                "Facebook.InstagramBeta",
                "Microsoft.MicrosoftOfficeHub",
                "Microsoft.MicrosoftSolitaireCollection",
                "Microsoft.ZuneVideo",
                "Microsoft.MixedReality.Portal",
                "Microsoft.Getstarted",
                "Microsoft.Office.OneNote",
                "Microsoft.Print3D",
                "Microsoft.People",
            };

            return apps;
        }
    }
}