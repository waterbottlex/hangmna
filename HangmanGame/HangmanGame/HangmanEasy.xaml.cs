using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HangmanGame
{
    /// <summary>
    /// Interaction logic for HangmanEasy.xaml
    /// </summary>
    public partial class HangmanEasy : Page
    {
        public static char[] guesses = new char[26];
        public static string[] words = { "bruh", "bruh" };
        public static int x = RandomNumber();
        public static string chosenWord = words[x];
        public char[] word = chosenWord.ToCharArray();

        public HangmanEasy()
        {
            InitializeComponent();
            

            for(int i = 0; i< guesses.Length;i++)
            {
                guesses[i] = '.';
            }
        }


        private static int RandomNumber()
        {
            Random r = new Random();
            int x = r.Next(0, 2);
            return x;
        }

        private void CheckGame(char[] guesses, char[] word)
        {
            int wrongGuesses = 0;
            for (int i = 0; i <guesses.Length;i++)
            {
                if (guesses[i] != '.')
                {
                    bool notinword = false;

                    for (int j = 0; j < word.Length; j++)
                    {
                        if(guesses[i] == word[j])
                        {
                            notinword = true;
                        }
                    }

                    if (notinword == false)
                    {
                        wrongGuesses += 1;
                    }
                }
            }

            bool[] correctGuesses = new bool[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                for(int j = 0; j < guesses.Length; j++)
                {
                    if (word[i] == guesses[j]){
                        correctGuesses[i] = true;
                    }
                }
            }

            bool win = true; ;
            for(int i = 0; i < correctGuesses.Length; i++)
            {
                if(correctGuesses[i] == false){
                    win = false;
                }
            }
            if (win)
            {
                pog.Source = new BitmapImage(new Uri("/Images/smily.png", UriKind.Relative));
            }

            if(wrongGuesses == 7)
            {
                pog.Source = new BitmapImage(new Uri("/Images/dead.png", UriKind.Relative));
            }


        }

        private void aClick(object sender, RoutedEventArgs e)
        {
            guesses[0] = 'a';
            CheckGame(guesses, word);
            AButton.Visibility = Visibility.Collapsed;


        }

        private void bClick(object sender, RoutedEventArgs e)
        {
            guesses[1] = 'b';
            CheckGame(guesses, word);

        }
        private void cClick(object sender, RoutedEventArgs e)
        {
            guesses[2] = 'c';
            CheckGame(guesses, word);

        }
        private void dClick(object sender, RoutedEventArgs e)
        {
            guesses[3] = 'd';
            CheckGame(guesses, word);

        }
        private void eClick(object sender, RoutedEventArgs e)
        {
            guesses[4] = 'e';
            CheckGame(guesses, word);

        }
        private void fClick(object sender, RoutedEventArgs e)
        {
            guesses[5] = 'f';
            CheckGame(guesses, word);

        }
        private void gClick(object sender, RoutedEventArgs e)
        {
            guesses[6] = 'g';
            CheckGame(guesses, word);
        }

        private void hClick(object sender, RoutedEventArgs e)
        {
            guesses[7] = 'h';
            CheckGame(guesses, word);

        }
        private void iClick(object sender, RoutedEventArgs e)
        {
            guesses[8] = 'i';

            CheckGame(guesses, word);
        }
        private void jClick(object sender, RoutedEventArgs e)
        {
            guesses[9] = 'j';

            CheckGame(guesses, word);
        }

        private void kClick(object sender, RoutedEventArgs e)
        {
            guesses[10] = 'k';
            CheckGame(guesses, word);

        }
        private void lClick(object sender, RoutedEventArgs e)
        {
            guesses[11] = 'l';
            CheckGame(guesses, word);

        }
        private void mClick(object sender, RoutedEventArgs e)
        {
            guesses[12] = 'm';
            CheckGame(guesses, word);

        }
        private void nClick(object sender, RoutedEventArgs e)
        {
            guesses[13] = 'n';
            CheckGame(guesses, word);

        }
        private void oClick(object sender, RoutedEventArgs e)
        {
            guesses[14] = 'o';
            CheckGame(guesses, word);

        }
        private void pClick(object sender, RoutedEventArgs e)
        {
            guesses[15] = 'p';
            CheckGame(guesses, word);

        }
        private void qClick(object sender, RoutedEventArgs e)
        {
            guesses[16] = 'q';
            CheckGame(guesses, word);

        }
        private void rClick(object sender, RoutedEventArgs e)
        {
            guesses[17] = 'r';

            CheckGame(guesses, word);
        }
        private void sClick(object sender, RoutedEventArgs e)
        {
            guesses[18] = 's';
            CheckGame(guesses, word);

        }
        private void tClick(object sender, RoutedEventArgs e)
        {
            guesses[19] = 't';
            CheckGame(guesses, word);

        }
        private void uClick(object sender, RoutedEventArgs e)
        {
            guesses[20] = 'u';
            CheckGame(guesses, word);

        }
        private void vClick(object sender, RoutedEventArgs e)
        {
            guesses[21] = 'v';
            CheckGame(guesses, word);

        }
        private void wClick(object sender, RoutedEventArgs e)
        {
            guesses[22] = 'w';
            CheckGame(guesses, word);

        }
        private void xClick(object sender, RoutedEventArgs e)
        {
            guesses[23] = 'x';
            CheckGame(guesses, word);

        }
        private void yClick(object sender, RoutedEventArgs e)
        {
            guesses[24] = 'y';

            CheckGame(guesses, word);
        }
        private void zClick(object sender, RoutedEventArgs e)
        {
            guesses[25] = 'z';

            CheckGame(guesses, word);
        }
    }
}
