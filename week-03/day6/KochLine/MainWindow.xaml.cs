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
    /// For a merry, happy Xmas! In September.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            SnowFlake(foxDraw, canvas, 30, 220, 250, 4, 0);
            foxDraw.BackgroundColor(Colors.Black);
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
        public static void SnowFlake (FoxDraw foxDraw, Canvas canvas, double x, double y, double length, int depth, double a)
        {
            foxDraw.StrokeColor(Colors.White);
            KocaptureMouse();h(foxDraw, canvas, x, y, length, depth, 0);
            Koch(foxDraw, canvas, x + length, y, length, depth, 4 * Math.PI / 3);
            Koch(foxDraw, canvas, x + length/2, y - length * Math.Sqrt(3) / 2, length, depth, 2 * Math.PI / 3);
        }
    }
        
}
