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
    /// Interaction logic for HangmanEasy.xaml
    /// </summary>
    public partial class HangmanEasy : Page
    {
        
        public int wrongGuesses = 0;
        public char[] guesses = new char[26];
        
        public HangmanEasy()
        {
            InitializeComponent();
            bool win = false;
            bool gameover = false;
            string[] words = { "bruh", "poggers" };
            Random random = new Random();
            string chosenWord = words[x];
            char[] word = chosenWord.ToCharArray();

            while (win == false && gameover == false)
            {

            }

        }

        private int RandomNumber()
        {
            Random r = new Random();
            int x = r.Next(0, 2);
            return x;
        }

        private void CheckGuess(char a, char[] arr)
        {
            
        }

        private void aClick(object sender, RoutedEventArgs e)
        {
            guesses[0] = 'a';
        }

        private void bClick(object sender, RoutedEventArgs e)
        {
            guesses[1] = 'b';
        }
        private void cClick(object sender, RoutedEventArgs e)
        {
            guesses[2] = 'c';
        }
        private void dClick(object sender, RoutedEventArgs e)
        {
            guesses[3] = 'd';
        }
        private void eClick(object sender, RoutedEventArgs e)
        {
            guesses[4] = 'e';
        }
        private void fClick(object sender, RoutedEventArgs e)
        {
            guesses[5] = 'f';
        }
    }
}
