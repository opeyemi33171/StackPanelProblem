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
using Windows.UI;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StackPanelProblem
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
        string[] input;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            input = entryBar.Text.Split(',');
            PanelItems rect = new PanelItems() {Width=holder.ActualWidth,Height=30 };
            switch (input[0].ToLower())
            {
                case "red":
                    rect.grid.Background= new SolidColorBrush(Colors.Red);
                    rect.name.Text = input[1];
                    break;
                case "blue":
                    rect.grid.Background = new SolidColorBrush(Colors.Blue);
                    rect.name.Text = input[1];
                    break;
                case "green":
                    rect.grid.Background = new SolidColorBrush(Colors.Green);
                    rect.name.Text = input[1];
                    break;
            }
            holder.Children.Add(rect);
            
        }
    }
}
