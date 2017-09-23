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

namespace LinePlay
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
            DrawGreenLines(foxDraw);
            DrawPurpleLines(foxDraw);
            //foxDraw.BackgroundColor(Colors.Black);
        }
        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            int x, y, z, a;
            x = 0;
            y = 10;
            z = 10;
            a = 300;
            for (int i = 0; i < 13; i++)
            {
                y += 20;
                z += 20;
                var startPoint = new Point(x, y);
                var endPoint = new Point(z, a);
                foxDraw.DrawLine(startPoint, endPoint);
            }
        }
        public static void DrawPurpleLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Purple);
            int x, y, z, a;
            x = 10;
            y = 0;
            z = 300;
            a = 10;
            for (int i = 0; i < 13; i++)
            {
                x += 20;
                a += 20;
                var startPoint = new Point(x, y);
                var endPoint = new Point(z, a);
                foxDraw.DrawLine(startPoint, endPoint);
            }
        }
    }
}
