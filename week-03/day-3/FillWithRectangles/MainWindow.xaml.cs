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


namespace FillWithRectangles
{

    public partial class MainWindow : Window
    {
        public static void DrawGreenPolygon(FoxDraw foxDraw)
        {
            var half = 150; //canvas.ActualHeight / 2;
            var squareSideA = 10;
            var x = half - squareSideA / 2;
            var y = half + squareSideA / 2;
            var points = new List<Point>();
            points.Add(new Point(x, x));
            points.Add(new Point(x, y));
            points.Add(new Point(y, y));
            points.Add(new Point(y, x));

            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawPolygon(points);
        }
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a green 10x10 square to the canvas' center.

            DrawGreenPolygon(foxDraw);

        }
    }
}
