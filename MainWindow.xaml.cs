using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScreenshotViewer
{
    public partial class MainWindow : Window
    {
        public string[] Images;
        public int CurrentImageIndex;

        public MainWindow()
        {
            InitializeComponent();
        }


        public void UpdateBottomPanel()
        {
            BottomPanel.Text = CurrentImageIndex + 1 + "/" + Images.Length;
        }

        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Escape)
                Close();
            if (e.Key == Key.Left)
                LoadNextImage(-1);
            if (e.Key == Key.Right)
                LoadNextImage(1);
            UpdateBottomPanel();
        }

        private void LoadNextImage(int indexChange)
        {
            if (CurrentImageIndex == 0 && indexChange < 0)
                return;
            if (CurrentImageIndex == Images.Length - 1 && indexChange > 0)
                return;
            
            Image.LoadImage(Images[CurrentImageIndex + indexChange], this);
            CurrentImageIndex += indexChange;
        }
    }
}
