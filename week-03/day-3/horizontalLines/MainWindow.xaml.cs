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

namespace horizontalLines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static void DrawLines(FoxDraw foxDraw, int x, int y)
        {
            var z = x + 50;
            var startPoint = new Point(x, y);
            var endPoint = new Point(z,y);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.StrokeColor(Colors.Magenta);
        }
        public MainWindow()
        {
            var foxDraw = new FoxDraw(canvas);
            InitializeComponent();
            int half = 150;
            int full = 300;
            DrawLines(foxDraw, half, full);
        }
    }
}