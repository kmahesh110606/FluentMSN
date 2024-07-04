using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using Windows.Foundation;
using Windows.Foundation.Collections;
using static System.Net.WebRequestMethods;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace FluentMSN
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            Homei.Glyph = "\uEA8A";
            ContentFrame.Navigate(typeof(HomePage));
            this.ExtendsContentIntoTitleBar= true;
        }

        void HomeClick(object sender, RoutedEventArgs e)
        {
            Homei.Glyph = "\uEA8A";
            Vidi.Glyph = "\uE768";
            Inti.Glyph = "\uE734";
            Fdi.Glyph = "\uED15";
            Stgi.Glyph = "\uE713";
            ContentFrame.Navigate(typeof(HomePage));
        }
        void VidClick(object sender, RoutedEventArgs e)
        {
            Homei.Glyph = "\uE80F";
            Vidi.Glyph = "\uF5B0";
            Inti.Glyph = "\uE734";
            Fdi.Glyph = "\uED15";
            Stgi.Glyph = "\uE713";
            ContentFrame.Navigate(typeof(VidPage));
        }
        void IntClick(object sender, RoutedEventArgs e)
        {
            Homei.Glyph = "\uE80F";
            Vidi.Glyph = "\uE768";
            Inti.Glyph = "\uE735";
            Fdi.Glyph = "\uED15";
            Stgi.Glyph = "\uE713";
            ContentFrame.Navigate (typeof(IntPage));
        }
        void FdClick(object sender, RoutedEventArgs e)
        {
            Homei.Glyph = "\uE80F";
            Vidi.Glyph = "\uE768";
            Inti.Glyph = "\uE734";
            Fdi.Glyph = "\uED15";
            Stgi.Glyph = "\uE713";
        }
        void StgClick(object sender, RoutedEventArgs e)
        {
            Homei.Glyph = "\uE80F";
            Vidi.Glyph = "\uE768";
            Inti.Glyph = "\uE734";
            Fdi.Glyph = "\uED15";
            Stgi.Glyph = "\uF8B0";
            ContentFrame.Navigate (typeof(StgPage)); 
        }
    }
}
