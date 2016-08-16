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
                Image.LoadImage(e.Args[0], mainWindow);
            mainWindow.Show();
        }
    }
}
