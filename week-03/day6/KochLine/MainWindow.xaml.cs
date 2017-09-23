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
using GreenFox;

namespace KochLine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Koch(foxDraw, canvas, 0, 150, 300, 3, 0);
            foxDraw.BackgroundColor(Colors.LightGray);
        }
        public static void Koch(FoxDraw foxDraw, Canvas canvas, double x, double y, double length, int depth, double a)
        {
            double d = length / 3;
            double pi = Math.PI;

            if (depth > 0)
            {
                Koch(foxDraw, canvas, x, y, d, depth - 1, a);
                Koch(foxDraw, canvas, x + d * Math.Cos(a), y + d * Math.Sin(a), d, depth - 1, a + pi / 3);
                Koch(foxDraw, canvas, x + d * Math.Cos(a) + d * Math.Cos(a + pi/3), y + d * Math.Sin(a) + d * Math.Sin(a + pi/3), d, depth - 1, a - pi /3);
                Koch(foxDraw, canvas, x + 2 * d * Math.Cos(a), y + 2 * d * Math.Sin(a), d, depth - 1, a);
            }
            else
            {
                foxDraw.DrawLine(x, y, x + length * Math.Cos(a), y + length * Math.Sin(a));
            }
        }
    }
        
}
