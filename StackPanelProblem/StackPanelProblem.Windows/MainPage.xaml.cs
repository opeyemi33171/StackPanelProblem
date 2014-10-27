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
            PanelItems rect;
            switch (input[0].ToLower())
            {
                case "red":
                    rect = new PanelItems(new SolidColorBrush(Colors.Red), input[1]) {
                        Width = holder.ActualWidth
                        , Height = 45 };
                    
                    break;
                case "blue":
                    rect = new PanelItems(new SolidColorBrush(Colors.Blue), input[1]) {
                        Width = holder.ActualWidth, 
                        Height = 45 };
                    break;
                case "green":
                    rect = new PanelItems(new SolidColorBrush(Colors.Green), input[1]) { 
                        Width = holder.ActualWidth, 
                        Height = 45 };
                    break;
                default:
                    rect = new PanelItems(new SolidColorBrush(Colors.Purple), input[1]);
                    break;
            }
            entryBar.Text = "";
            holder.Children.Add(rect);
        }
    }
}
