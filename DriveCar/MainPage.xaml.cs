using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DriveCar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
        }

        void CoreWindow_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
            switch (args.VirtualKey)
            {
                case Windows.System.VirtualKey.Up:
                    Canvas.SetTop(this.Car, Canvas.GetTop(this.Car) - 5);
                    break;
                case Windows.System.VirtualKey.Down:
                    Canvas.SetTop(this.Car, Canvas.GetTop(this.Car) + 5);
                    break;
                case Windows.System.VirtualKey.Left:
                    Canvas.SetLeft(this.Car, Canvas.GetLeft(this.Car) - 5);
                    break;
                case Windows.System.VirtualKey.Right:
                    Canvas.SetLeft(this.Car, Canvas.GetLeft(this.Car) + 5);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Page_KeyDown_1(object sender, KeyRoutedEventArgs e)
        {
            
        }
    }
}
