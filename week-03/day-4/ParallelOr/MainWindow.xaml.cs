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

namespace ParallelOr
{
   
    public partial class MainWindow : Window
    {
        public static void DrawGreenPolygon(FoxDraw foxDraw, Canvas canvas)
        {
            var points = new List<Point>();
            points.Add(new Point(canvas.Width / 3, canvas.Height- canvas.Height));
            points.Add(new Point(canvas.Width / 3, canvas.Height / 3));
            points.Add(new Point(canvas.Width *2/ 3, canvas.Height / 3));
            points.Add(new Point(canvas.Width * 2 / 3, canvas.Height- canvas.Height));

            foxDraw.FillColor(Colors.Red);
            foxDraw.DrawPolygon(points);
        }
        public static void DrawGreenPolygon2(FoxDraw foxDraw, Canvas canvas)
        {
            var points = new List<Point>();
            points.Add(new Point(canvas.Width- canvas.Width, canvas.Height / 3));
            points.Add(new Point(canvas.Width- canvas.Width, canvas.Height *2 / 3));
            points.Add(new Point(canvas.Width  / 3, canvas.Height * 2 / 3));
            points.Add(new Point(canvas.Width  / 3, canvas.Height / 3));

            foxDraw.FillColor(Colors.Red);
            foxDraw.DrawPolygon(points);
        }
        public static void DrawGreenPolygon3(FoxDraw foxDraw, Canvas canvas)
        {
            var points = new List<Point>();
            points.Add(new Point(canvas.Width / 3, canvas.Height * 2 / 3));
            points.Add(new Point(canvas.Width / 3, canvas.Height));
            points.Add(new Point(canvas.Width * 2 / 3, canvas.Height));
            points.Add(new Point(canvas.Width * 2 / 3, canvas.Height * 2 / 3));

            foxDraw.FillColor(Colors.Red);
            foxDraw.DrawPolygon(points);
        }
        public static void DrawGreenPolygon4(FoxDraw foxDraw, Canvas canvas)
        {
            var points = new List<Point>();
            points.Add(new Point(canvas.Width * 2 / 3, canvas.Height / 3));
            points.Add(new Point(canvas.Width * 2 / 3, canvas.Height * 2 / 3));
            points.Add(new Point(canvas.Width, canvas.Height * 2 / 3));
            points.Add(new Point(canvas.Width, canvas.Height  / 3));

            foxDraw.FillColor(Colors.Red);
            foxDraw.DrawPolygon(points);
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawGreenPolygon(foxDraw, canvas);
            DrawGreenPolygon2(foxDraw, canvas);
            DrawGreenPolygon3(foxDraw, canvas);
            DrawGreenPolygon4(foxDraw, canvas);
            foxDraw.BackgroundColor(Colors.Black);
        }
    }
}
