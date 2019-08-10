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

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DrawCircle();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Make the background red
 //           but.Background = new SolidColorBrush(Color.FromRgb(255,0,0));
            leftCircle.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            // Make the background red
 //           but2.Background = new SolidColorBrush(Color.FromRgb(0, 0, 255));
            rightCircle.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 255));
        }

        private void DrawCircle()
        {
            // Make the background red
  //          Canvas main = new Canvas();

  //          main.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
        }
    }
}
