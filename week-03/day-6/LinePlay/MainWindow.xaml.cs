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
            DrawLines(foxDraw);
            DrawLines2(foxDraw);
            //foxDraw.BackgroundColor(Colors.Black);
        }
        public static void DrawLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            int x, y, z, a;
            x = 150;
            y = 0;
            z = 150;
            a = 150;
            for (int i = 0; i < 14; i++)
            {
                y += 10;
                z -= 10;
                var startPoint = new Point(x, y);
                var endPoint = new Point(z, a);
                foxDraw.DrawLine(startPoint, endPoint);
            }

        }
        public static void DrawLines2(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            int x, y, z, a;
            x = 150;
            y = 300;
            z = 150;
            a = 150;
            for (int i = 0; i < 14; i++)
            {
                y -= 10;
                z += 10;
                var startPoint = new Point(x, y);
                var endPoint = new Point(z, a);
                foxDraw.DrawLine(startPoint, endPoint);
            }

        }
        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            int x, y, z, a;
            x = 150;
            y = 0;
            z = 150;
            a = 150;
            for (int i = 0; i < 14; i++)
            {
                y += 10;
                z += 10;
                var startPoint = new Point(x, y);
                var endPoint = new Point(z, a);
                foxDraw.DrawLine(startPoint, endPoint);
            }
        }
        public static void DrawPurpleLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            int x, y, z, a;
            x = 0;
            y = 150;
            z = 150;
            a = 150;
            for (int i = 0; i < 14; i++)
            {
                x += 10;
                a += 10;
                var startPoint = new Point(x, y);
                var endPoint = new Point(z, a);
                foxDraw.DrawLine(startPoint, endPoint);
            }
        
        }
    }
}
