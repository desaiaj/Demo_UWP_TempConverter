using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FinalUWPAjayDesai
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Style reveal = Resources.ThemeDictionaries["ButtonRevealStyle"] as Style;
            btnConvert.Style = reveal;
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double temp = double.Parse(txtTemp.Text);
                tbTemp.Foreground = new SolidColorBrush(Colors.Black);
                if ((bool)rbCtoF.IsChecked)
                    tbTemp.Text = ((temp * 9.0 / 5.0) + 32).ToString("F") + "\u00B0 F";
                else if ((bool)rbFtoC.IsChecked)
                    tbTemp.Text = ((temp - 32) * 5.0 / 9.0).ToString("F") + "\u00B0 C";
            }
            catch
            {
                tbTemp.Text = "Invalid Input";
                tbTemp.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
