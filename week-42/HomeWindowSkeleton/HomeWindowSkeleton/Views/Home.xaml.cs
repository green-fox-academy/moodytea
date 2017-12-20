using HomeWindowSkeleton.Models;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWindowSkeleton
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            //DataContext = new ClassNameViewModel();
        }

        
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo pro = new ProcessStartInfo("cmd");
            //pro.WorkingDirectory = @"C:\";
            pro.UseShellExecute = false;
            //pro.CreateNoWindow = true;
            pro.RedirectStandardOutput = true;
            pro.RedirectStandardInput = true;
            var proc = Process.Start(pro);
            proc.StandardInput.WriteLine("echo hello");
            proc.StandardInput.WriteLine("exit");
            string s = proc.StandardOutput.ReadToEnd();
            MessageBox.Show(s);
        }

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string className = ComboYear.SelectedItem.ToString();
        //    className = className.Substring(38);
        //    MessageBox.Show(className);
        //}
    }
}
