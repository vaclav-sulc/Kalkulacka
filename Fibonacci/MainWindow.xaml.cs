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

namespace Fibonacci
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Canvas myCanvas = new Canvas();
            this.Content = myCanvas;

            int[] fibonacci = {1, 1, 2, 3};
            double x = 800, y = 400;
            double sideLength = 20;
            int direction = 0;

            for (int i = 0; i < fibonacci.Length; i++)
            {
                double currentSide = fibonacci[i] * sideLength;
                Rectangle rect = new Rectangle
                {
                    Width = currentSide,
                    Height = currentSide,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1
                };
                Canvas.SetLeft(rect, x);
                Canvas.SetTop(rect, y);
                myCanvas.Children.Add(rect);
                switch (direction)
                {
                    case 0:
                        x += currentSide;
                        break;
                    case 1:
                        y -= fibonacci[i+1]*currentSide;
                        x -= fibonacci[i]*currentSide;
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                direction = (direction + 1) % 4;
            }
            

        }
    }
}