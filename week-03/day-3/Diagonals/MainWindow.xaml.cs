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

namespace Diagonals
{
    public partial class MainWindow : Window
    {
        public static void DrawLines(FoxDraw foxDraw)
        {

            //int half = 150;
            int rei = 0;
            int full = 300;
            foxDraw.StrokeColor(Colors.Green);
            var startPoint = new Point(rei, rei);
            var endPoint = new Point(full, full);
            foxDraw.DrawLine(startPoint, endPoint);
            startPoint = new Point(rei, full);
            endPoint = new Point(full, rei);
            foxDraw.DrawLine(startPoint, endPoint);
            
        }
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw the canvas' diagonals in green.
            DrawLines(foxDraw);
        }
    }
}
