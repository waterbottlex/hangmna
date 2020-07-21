using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HangmanGame
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Difficulty : Page
    {
        public Difficulty()
        {
            InitializeComponent();

        }

        private void BeginButton_Click(object sender, RoutedEventArgs e)
        {
            if (Easy.IsChecked == true)
            {
                this.NavigationService.Navigate(new Uri("HangmanEasy.xaml", UriKind.Relative));
            }
            else if (Medium.IsChecked == true)
            {
                this.NavigationService.Navigate(new Uri("HangmanEasy.xaml", UriKind.Relative));

            }
            else if (Hard.IsChecked == true)
            {
                this.NavigationService.Navigate(new Uri("HangmanEasy.xaml", UriKind.Relative));

            }
            else
            {
                MessageBox.Show("Please select an option!");
            }
        }
    }
}
