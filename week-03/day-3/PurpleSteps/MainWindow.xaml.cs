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
            points.Add(new Point(s + 15, a));
            points.Add(new Point(a + 15, s + 15));
            points.Add(new Point(s, a + 15));

            foxDraw.FillColor(Colors.Purple);
            foxDraw.DrawPolygon(points);
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int x, y;
            x = 0;
            y = 0;
            for (int i = 0; i < 20; i++)
            {
                x += 15;
                y += 15;
                DrawPolygon(foxDraw, x, y);
            }

        }
    }
}
