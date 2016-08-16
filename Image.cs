using System;
using System.Windows.Media.Imaging;

namespace ScreenshotViewer
{
    public class Image
    {
        public static void LoadImage(string imageLocation, MainWindow targetWindow)
        {
            var image = new BitmapImage(new Uri(imageLocation));
            targetWindow.ImageBox.Source = image;
            targetWindow.ImageBox.MaxWidth = image.PixelWidth;
            targetWindow.ImageBox.MaxHeight = image.PixelHeight;
        }
    }
}