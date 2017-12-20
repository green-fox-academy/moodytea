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
            try
            {
                using (Process p = new Process())
                {
                    // set start info
                    p.StartInfo = new ProcessStartInfo("cmd.exe")
                    {
                        RedirectStandardInput = true,
                        UseShellExecute = false,
                        WorkingDirectory = @"c:\"
                    };
                    // event handlers for output & error
                    p.OutputDataReceived += p_OutputDataReceived;
                    //p.ErrorDataReceived += p_ErrorDataReceived;

                    // start process
                    p.Start();
                    // send command to its input
                    p.StandardInput.Write("dir" + p.StandardInput.NewLine);
                    //wait
                    p.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //static void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        //{
        //    Process p = sender as Process;
        //    if (p == null)
        //        return;
        //    Console.WriteLine(e.Data);
        //}

        static void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Process p = sender as Process;
            if (p == null)
                return;
            Console.WriteLine(e.Data);
        }
    

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string className = ComboYear.SelectedItem.ToString();
        //    className = className.Substring(38);
        //    MessageBox.Show(className);
        //}
    }
}
