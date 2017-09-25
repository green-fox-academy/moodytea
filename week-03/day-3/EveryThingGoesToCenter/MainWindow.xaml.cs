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

namespace EveryThingGoesToCenter
{
    public partial class MainWindow : Window

    {
        public static void DrawPolygon(FoxDraw foxDraw, int x, int y)
        {

            int half = 150;
            //int rei = 0;
            //int full = 300;
            var startPoint = new Point(x, y);
            var endPoint = new Point(half, half);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.StrokeColor(Colors.Magenta);
            foxDraw.BackgroundColor(Colors.Black);
        }
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            int i, j, n;
            int x = 0;
            int y = 0;
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
                        foxDraw.FillColor(Colors.Red);

                    }
                    x += 5;
                    DrawPolygon(foxDraw, x, y);

                }
                y += 5;
                DrawPolygon(foxDraw, x, y);
                
            }

        }
    }
}
