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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // can.Background = new SolidColorBrush(Color.FromRgb(0, 255, 255));

            Path myPath = new Path();
            myPath.Stroke = System.Windows.Media.Brushes.Black;
            myPath.Fill = System.Windows.Media.Brushes.White;
            myPath.StrokeThickness = 1;
            myPath.HorizontalAlignment = HorizontalAlignment.Left;
            myPath.VerticalAlignment = VerticalAlignment.Center;

            PathGeometry myPathGeometry = new PathGeometry();

            for (int i=0; i < 15; i++)
            {
                // 24 goes into 60 2.5 times

                // Get the angle from 12 O'Clock to this tick (radians)
                double di = (double)i;
                double angleFrom12 = (di * 2.5) / 60.0 * 2.0 * Math.PI;

                // Get the angle from 3 O'Clock to this tick
                // Note: 3 O'Clock corresponds with zero angle in unit circle
                // Makes it easier to do the math.
                double angleFrom3 = Math.PI / 2.0 - angleFrom12;

                double x = (260 + Math.Cos(angleFrom3) * 250);
                double y = (260 - Math.Sin(angleFrom3) * 250);

                PathFigure myPathFigure = new PathFigure();
                myPathFigure.StartPoint = new System.Windows.Point(260, 260);
                myPathFigure.IsClosed = false;

                // arc segment of path figure
                ArcSegment seg = new ArcSegment();
                seg.Size = new System.Windows.Size(5, 90);

                seg.Point = new System.Windows.Point(x, y);
                seg.IsLargeArc = false;
                seg.SweepDirection = SweepDirection.Clockwise;
                seg.RotationAngle = 0;// angleFrom3;

                // add arc segment
                myPathFigure.Segments.Add(seg);

                // add path figure
                myPathGeometry.Figures.Add(myPathFigure);
            }

            // Assign path data
            myPath.Data = myPathGeometry;

            // Add path to canvas
            can.Children.Add(myPath);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            // Make the background red
 //           but2.Background = new SolidColorBrush(Color.FromRgb(0, 0, 255));
            rightCircle.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void DrawCircle()
        {
            // Make the background red
  //          Canvas main = new Canvas();

  //          main.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
        }
    }
}
