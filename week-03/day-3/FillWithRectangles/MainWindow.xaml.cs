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
        public static void DrawPolygon(FoxDraw foxDraw, double p, byte w)
        {
            
            var s = p / 2;
            var b = p;
            var points = new List<Point>();
            points.Add(new Point(s, s + 30));
            points.Add(new Point(s, b ));
            points.Add(new Point(b, b ));
            points.Add(new Point(b , s + 30));
            foxDraw.DrawPolygon(points);
            foxDraw.FillColor(Color.FromRgb(w, 50, 50));

        }
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw four different size and color rectangles.

            var x = 260;
            
            for (int i = 0; i <= 3; i++)
            {
                
                
                x -= 30;
                byte b = Convert.ToByte(x - 5);
                DrawPolygon(foxDraw, x, b);
            }

            
        }
    }
}
