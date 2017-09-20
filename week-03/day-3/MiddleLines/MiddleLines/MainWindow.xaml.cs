using System;
using System.Windows;
using GreenFox;

namespace MiddleLines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var foxDraw = new FoxDraw(canvas);
            InitializeComponent();
        }
    }
}
