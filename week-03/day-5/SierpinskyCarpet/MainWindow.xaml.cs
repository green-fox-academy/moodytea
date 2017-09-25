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

namespace SierpinskyCarpet
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Black);

            DrawSquare(foxDraw, canvas, 0, 0, 100, 6);
        }
        public static void DrawSquare (FoxDraw foxDraw, Canvas canvas, double x, double y, double Side, int depth)
        {
            
            foxDraw.FillColor(Colors.Gray);
            foxDraw.DrawRectangle( x + Side, y + Side, Side, Side);

            if (depth > 1)
            {
                DrawSquare(foxDraw, canvas, x,                y,                Side / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x + Side,         y,                Side / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x + 2 * Side,     y,                Side / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x,                y + Side,         Side / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x + 2 * Side,     y + Side,         Side / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x,                y + 2 * Side,     Side / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x + Side,         y + 2 * Side,     Side / 3, depth - 1);
                DrawSquare(foxDraw, canvas, x + 2 * Side,     y + 2 * Side,     Side / 3, depth - 1);
            }
        }


       
    }
}
