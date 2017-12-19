using HomeWindowSkeleton.Models;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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


        //private void NextButton_Click(object sender, RoutedEventArgs e)
        //{
        //    var window = new NavigationWindow
        //    {
        //        Source = new Uri("NextWindow.xaml", UriKind.Relative)
        //    };
        //    window.Show();
        //    this.Close();
        //}

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string className = ComboYear.SelectedItem.ToString();
        //    className = className.Substring(38);
        //    MessageBox.Show(className);
        //}
    }
}
