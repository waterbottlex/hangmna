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
        public char[] word;
        
        public HangmanEasy()
        {
            InitializeComponent();
            bool win = false;
            bool gameover = false;
            string[] words = { "bruh", "poggers" };
            Random random = new Random();
            int x = RandomNumber();
            string chosenWord = words[x];
            word = chosenWord.ToCharArray();

            while (win == false && gameover == false)
            {
                if(wrongGuesses == 7)
                {
                    gameover = true;
                    System.Windows.Application.Current.Shutdown();

                }

                win = CheckWin(word, guesses);
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
            bool containsGuess = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (a == arr[i])
                {
                    containsGuess = true;
                }
            }
            if (!containsGuess)
            {
                wrongGuesses += 1;
            }
        }

        private bool CheckWin(char[] x, char[]y)
        {
            bool[] letters = new bool[x.Length];
            for (int i = 0; i< x.Length;i++)
            {
                for(int j = 0;j<y.Length;j++)
                {
                    if (x[i] == y[j])
                    {
                        letters[i] = true;
                    }
                }
            }

            bool win = true; ;

            for(int i =0; i< x.Length; i++)
            {
                if (letters[i] == false)
                {
                    win = false;
                }
            }
            return win;
        }

        private void aClick(object sender, RoutedEventArgs e)
        {
            guesses[0] = 'a';
            CheckGuess('a', word);
        }

        private void bClick(object sender, RoutedEventArgs e)
        {
            guesses[1] = 'b';
            CheckGuess('b', word);

        }
        private void cClick(object sender, RoutedEventArgs e)
        {
            guesses[2] = 'c';
            CheckGuess('c', word);

        }
        private void dClick(object sender, RoutedEventArgs e)
        {
            guesses[3] = 'd';
            CheckGuess('d', word);

        }
        private void eClick(object sender, RoutedEventArgs e)
        {
            guesses[4] = 'e';
            CheckGuess('e', word);

        }
        private void fClick(object sender, RoutedEventArgs e)
        {
            guesses[5] = 'f';
            CheckGuess('f', word);

        }
        private void gClick(object sender, RoutedEventArgs e)
        {
            guesses[6] = 'g';
            CheckGuess('g', word);
        }

        private void hClick(object sender, RoutedEventArgs e)
        {
            guesses[7] = 'h';
            CheckGuess('h', word);

        }
        private void iClick(object sender, RoutedEventArgs e)
        {
            guesses[8] = 'i';
            CheckGuess('i', word);

        }
        private void jClick(object sender, RoutedEventArgs e)
        {
            guesses[9] = 'j';
            CheckGuess('j', word);

        }

        private void kClick(object sender, RoutedEventArgs e)
        {
            guesses[10] = 'k';
            CheckGuess('k', word);

        }
        private void lClick(object sender, RoutedEventArgs e)
        {
            guesses[11] = 'l';
            CheckGuess('l', word);

        }
        private void mClick(object sender, RoutedEventArgs e)
        {
            guesses[12] = 'm';
            CheckGuess('m', word);

        }
        private void nClick(object sender, RoutedEventArgs e)
        {
            guesses[13] = 'n';
            CheckGuess('n', word);

        }
        private void oClick(object sender, RoutedEventArgs e)
        {
            guesses[14] = 'o';
            CheckGuess('o', word);

        }
        private void pClick(object sender, RoutedEventArgs e)
        {
            guesses[15] = 'p';
            CheckGuess('p', word);

        }
        private void qClick(object sender, RoutedEventArgs e)
        {
            guesses[16] = 'q';
            CheckGuess('q', word);

        }
        private void rClick(object sender, RoutedEventArgs e)
        {
            guesses[17] = 'r';
            CheckGuess('r', word);

        }
        private void sClick(object sender, RoutedEventArgs e)
        {
            guesses[18] = 's';
            CheckGuess('s', word);

        }
        private void tClick(object sender, RoutedEventArgs e)
        {
            guesses[19] = 't';
            CheckGuess('t', word);

        }
        private void uClick(object sender, RoutedEventArgs e)
        {
            guesses[20] = 'u';
            CheckGuess('u', word);

        }
        private void vClick(object sender, RoutedEventArgs e)
        {
            guesses[21] = 'v';
            CheckGuess('v', word);

        }
        private void wClick(object sender, RoutedEventArgs e)
        {
            guesses[22] = 'w';
            CheckGuess('w', word);

        }
        private void xClick(object sender, RoutedEventArgs e)
        {
            guesses[23] = 'x';
            CheckGuess('x', word);

        }
        private void yClick(object sender, RoutedEventArgs e)
        {
            guesses[24] = 'y';
            CheckGuess('y', word);

        }
        private void zClick(object sender, RoutedEventArgs e)
        {
            guesses[25] = 'z';
            CheckGuess('z', word);

        }
    }
}
