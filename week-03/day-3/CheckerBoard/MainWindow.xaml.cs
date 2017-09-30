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

namespace CheckerBoard
{
    public partial class MainWindow : Window
    {
        public static void DrawPolygon(FoxDraw foxDraw, int s, int a)
        {
            var points = new List<Point>();
            points.Add(new Point(s, a));
            points.Add(new Point(s, a + 30));
            points.Add(new Point(s + 30, a + 30));
            points.Add(new Point(s + 30, a));


            foxDraw.DrawPolygon(points);
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.FillColor(Colors.Green);
            int x, y;
            x = 0;
            y = 0;

            int i, j, n;
            n = 8;
            for (i = 1; i <= n; i++)
            {



                for (j = 1; j <= n; j++)
                {


                    if ((i + j) % 2 == 0)
                    {
                        foxDraw.FillColor(Colors.Black);

                    }

                    else if ((i + j) % 2 != 0)
                    {
                        foxDraw.FillColor(Colors.White);

                    }
                    x += 30;
                    DrawPolygon(foxDraw, x, y);

                }
                y += 30;
                //DrawPolygon(foxDraw, x, y);
                x = 0;
            }

        }
    }
}
