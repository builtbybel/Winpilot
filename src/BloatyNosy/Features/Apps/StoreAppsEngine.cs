using System.Collections.Generic;

namespace BloatyNosy
{
    public static class BloatwareList
    {
        // Our Windows 11 bloatware list
        public static IEnumerable<string> GetList()
        {
            var apps = new List<string>
            {
                "2FE3CB00.PICSART-PHOTOSTUDIO",
                "4DF9E0F8.Netflix",
                "5319275A.WhatsAppDesktop",
                "9E2F88E3.TWITTER",
                "NAVER.LINEwin8_8ptj331gd3tyt",
                "SpotifyAB.SpotifyMusic",
                "king.com.CandyCrushFriends",
                "king.com.CandyCrushSaga",
                "king.com.FarmHeroesSaga",
                "22364Disney.ESPNBetaPWA",
                "5A894077.McAfeeSecurity",
                "AdobeSystemsIncorporated.AdobeCreativeCloudExpress",
                "AmazonVideo.PrimeVideo",
                "AppUp.IntelGraphicsExperience",
                "B9ECED6F.ASUSPCAssistant",
                "B9ECED6F.ScreenPadMaster",
                "BytedancePte.Ltd.TikTok",
                "Clipchamp.Clipchamp",
                "DTSInc.DTSAudioProcess",
                "FACEBOOK.317180B0BB486",
                "Facebook.InstagramBeta",
                "AdobeSystemsIncorporated.AdobeLightroom",
                "AdobeSystemsIncorporated.AdobePhotoshopExpress",
                "Clipchamp.Clipchamp_yxz26nhyzhsrt",
                "CorelCorporation.PaintShopPro",
                "FACEBOOK.317180B0BB486",
                "Facebook.InstagramBeta",
                "AD2F1837.HPJumpStarts",
                "AD2F1837.HPPCHardwareDiagnosticsWindows",
                "AD2F1837.HPPowerManager",
                "AD2F1837.HPPrivacySettings",
                "AD2F1837.HPSupportAssistant",
                "AD2F1837.HPSureShieldAI",
                "AD2F1837.HPSystemInformation",
                "AD2F1837.HPQuickDrop",
                "AD2F1837.HPWorkWell",
                "AD2F1837.myHP",
                "AD2F1837.HPDesktopSupportUtilities",
                "AD2F1837.HPQuickTouch",
                "AD2F1837.HPEasyClean",
                "AD2F1837.HPSystemInformation",
                "Microsoft.549981C3F5F10",
                "Microsoft.BingNews",
                "Microsoft.BingWeather",
                "Microsoft.GamingApp",
                "Microsoft.Getstarted",
                "Microsoft.Microsoft3DViewer",
                "Microsoft.MicrosoftOfficeHub",
                "Microsoft.MicrosoftSolitaireCollection",
                "Microsoft.MicrosoftStickyNotes",
                "Microsoft.MixedReality.Portal",
                "Microsoft.Office.OneNote",
                "Microsoft.OneDriveSync",
                "Microsoft.OneConnect",
                "Microsoft.People",
                "Microsoft.Print3D",
                "Microsoft.SkypeApp",
                "Microsoft.Wallet",
                "Microsoft.WindowsSoundRecorder"
            };

            return apps;
        }
    }
}