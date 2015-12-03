using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        // public delegate void Page1EventHandler(object source, EventArgs e);
        // public event Page1EventHandler OnNavigatePage1Ready;

        public MainPage()
        {
            this.InitializeComponent();
           //  this.OnNavigatePage1Ready += MainPage_OnNavigateParentReady;
        }

        /*
        private void MainPage_OnNavigateParentReady(object source, EventArgs e)
        {
            Frame.Navigate(typeof(Page1));
        }
        */

        private void testbtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page1));
//            OnNavigatePage1Ready(this, null);
        }
    }
}
