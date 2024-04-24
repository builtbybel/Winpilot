using Microsoft.Win32;
using Winpilot;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interop
{
    public class WallpaperSettings : InteropBase
    {
        public WallpaperSettings(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const int SPI_SETDESKWALLPAPER = 20;
        private const int SPIF_UPDATEINIFILE = 0x01;
        private const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private string wallpaperPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\Themes\TranscodedWallpaper";

        public override void Execute()
        {
            if (File.Exists(wallpaperPath))
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RegistryKey keyName = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
                    keyName.SetValue(@"WallpaperStyle", 2.ToString());
                    keyName.SetValue(@"TileWallpaper", 0.ToString());

                    SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, openFileDialog.FileName, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
                }
            }
            else
            {
                logger.Log("Wallpaper file not found: " + wallpaperPath, Color.Red);
            }
        }
    }
}