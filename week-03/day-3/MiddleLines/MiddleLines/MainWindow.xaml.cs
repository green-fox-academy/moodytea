using System;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace MiddleLines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static void DrawLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            var startPoint = new Point(0, 150);
            var endPoint = new Point(300, 150);
            foxDraw.DrawLine(startPoint, endPoint);
        }
        public static void DrawLines2(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            var startPoint = new Point(150, 0);
            var endPoint = new Point(150,300);
            foxDraw.DrawLine(startPoint, endPoint);
        }
        public MainWindow()
        {

            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawLines(foxDraw);
            DrawLines2(foxDraw);

            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.

        }
    }
}
