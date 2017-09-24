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

namespace Triangles
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
            //foxDraw.BackgroundColor(Colors.Black);
            double x = 150;
            double y = 0;
            double triangleSide = 20;
            double triangleheight = Math.Sqrt(3 * triangleSide) / 2;
            double z = x - triangleSide/2;
            double a = y + triangleheight;
            DrawGreenPolygon(foxDraw, z,a, triangleSide, triangleheight);
            DrawGreenPolygon2(foxDraw, x, y, triangleSide, triangleheight);
            
        }
        public static void DrawGreenPolygon(FoxDraw foxDraw, double z, double a, double triangleSide, double triangleheight)
        {
            var points = new List<Point>();
            points.Add(new Point(z, a));
            points.Add(new Point(z + triangleSide, a));
            points.Add(new Point(z - triangleSide/2, a + triangleheight));
            

            foxDraw.FillColor(Colors.Gray);
            foxDraw.DrawPolygon(points);
        }
        public static void DrawGreenPolygon2(FoxDraw foxDraw, double x, double y, double triangleSide, double triangleheight)
        {
            var points = new List<Point>();
            points.Add(new Point(x, y));
            points.Add(new Point(x + triangleSide / 2, y + triangleheight));
            points.Add(new Point(x - triangleSide, y));


            foxDraw.FillColor(Colors.Gray);
            foxDraw.DrawPolygon(points);
        }
    }
}
