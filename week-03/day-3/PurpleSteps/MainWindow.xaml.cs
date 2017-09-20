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

namespace PurpleSteps
{
    public partial class MainWindow : Window
    {
        public static void DrawPolygon(FoxDraw foxDraw, int s, int a)
        {
            var points = new List<Point>();
            points.Add(new Point(s, a));
            points.Add(new Point(s  , 2 * a));
            points.Add(new Point(2 * a, 2 * s));
            points.Add(new Point(2 * s,  a));

            foxDraw.FillColor(Colors.Purple);
            foxDraw.DrawPolygon(points);
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.FillColor(Colors.Black);
            int x, y;
            x = 5;
            y = 5;
            
            for (int i = 1; i < 7; i++)
            {
                
                x *= 2;
                y *= 2;
                DrawPolygon(foxDraw, x, y);
            }

        }
    }
}
