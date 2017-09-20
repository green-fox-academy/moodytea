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

namespace GoToCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        public static void DrawLines(FoxDraw foxDraw, int x, int y)
        {
            
            int half = 150;
            //int rei = 0;
            //int full = 300;
            var startPoint = new Point(x, y);
            var endPoint = new Point(half, half);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.StrokeColor(Colors.Black);
        }
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // draw 3 lines with that function.
            int x = 0;
            int y = 0;
            DrawLines(foxDraw, x,y);
            x = 150;
            y = 0;
            DrawLines(foxDraw, x, y);
            x = 0;
            y = 150;
            DrawLines(foxDraw, x, y);
        }
    }
}
