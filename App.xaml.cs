using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ScreenshotViewer
{
    public partial class App : Application
    {

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            if (e.Args.Length == 1 && Path.HasExtension(e.Args[0]))
            {
                var file = new FileInfo(e.Args[0]);

                Image.LoadImage(file.FullName, mainWindow);
                if (file.DirectoryName != null)
                    mainWindow.Images = Directory.GetFiles(file.DirectoryName).Where(s => Image.SupportedExtensions.Contains(Path.GetExtension(s))).ToArray();
                mainWindow.CurrentImageIndex = Array.FindIndex(mainWindow.Images, img => img.Contains(e.Args[0]));
                mainWindow.UpdateBottomPanel();
            }
                
            mainWindow.Show();
        }
    }
}
