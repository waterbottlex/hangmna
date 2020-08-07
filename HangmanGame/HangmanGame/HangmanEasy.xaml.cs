using System;
using System.Collections.Generic;
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
        public static string[] words = { "india", "watermelon" };
        public static int x = RandomNumber();
        public static string chosenWord = words[x];
        public static char[] word = chosenWord.ToCharArray();
        public static char[] display = new char[(word.Length*2)];
        public static string displayed;

        public HangmanEasy()
        {
            InitializeComponent();
            

            for(int i = 0; i< guesses.Length;i++)
            {
                guesses[i] = '.';
            }

            for(int i = 0; i < (word.Length*2); i+=2)
            {
                display[i] = '_';
                display[i + 1] = ' ';
            }

            displayed = new string(display);
            WordShown.Text = displayed;
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


            for(int i = 0; i < display.Length; i += 2)
            {
                if(correctGuesses[i/2] == true)
                {
                    display[i] = word[i/2];
                }
            }
            displayed = new string(display);
            WordShown.Text = displayed;


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
            BButton.Visibility = Visibility.Collapsed;

        }
        private void cClick(object sender, RoutedEventArgs e)
        {
            guesses[2] = 'c';
            CheckGame(guesses, word);
            CButton.Visibility = Visibility.Collapsed;

        }
        private void dClick(object sender, RoutedEventArgs e)
        {
            guesses[3] = 'd';
            CheckGame(guesses, word);
            DButton.Visibility = Visibility.Collapsed;

        }
        private void eClick(object sender, RoutedEventArgs e)
        {
            guesses[4] = 'e';
            CheckGame(guesses, word);
            EButton.Visibility = Visibility.Collapsed;

        }
        private void fClick(object sender, RoutedEventArgs e)
        {
            guesses[5] = 'f';
            CheckGame(guesses, word);
            FButton.Visibility = Visibility.Collapsed;

        }
        private void gClick(object sender, RoutedEventArgs e)
        {
            guesses[6] = 'g';
            CheckGame(guesses, word);
            GButton.Visibility = Visibility.Collapsed;
        }

        private void hClick(object sender, RoutedEventArgs e)
        {
            guesses[7] = 'h';
            CheckGame(guesses, word);
            HButton.Visibility = Visibility.Collapsed;

        }
        private void iClick(object sender, RoutedEventArgs e)
        {
            guesses[8] = 'i';

            CheckGame(guesses, word);
            IButton.Visibility = Visibility.Collapsed;
        }
        private void jClick(object sender, RoutedEventArgs e)
        {
            guesses[9] = 'j';

            CheckGame(guesses, word);
            JButton.Visibility = Visibility.Collapsed;
        }

        private void kClick(object sender, RoutedEventArgs e)
        {
            guesses[10] = 'k';
            CheckGame(guesses, word);
            KButton.Visibility = Visibility.Collapsed;

        }
        private void lClick(object sender, RoutedEventArgs e)
        {
            guesses[11] = 'l';
            CheckGame(guesses, word);
            LButton.Visibility = Visibility.Collapsed;

        }
        private void mClick(object sender, RoutedEventArgs e)
        {
            guesses[12] = 'm';
            CheckGame(guesses, word);
            MButton.Visibility = Visibility.Collapsed;

        }
        private void nClick(object sender, RoutedEventArgs e)
        {
            guesses[13] = 'n';
            CheckGame(guesses, word);
            NButton.Visibility = Visibility.Collapsed;

        }
        private void oClick(object sender, RoutedEventArgs e)
        {
            guesses[14] = 'o';
            CheckGame(guesses, word);
            OButton.Visibility = Visibility.Collapsed;

        }
        private void pClick(object sender, RoutedEventArgs e)
        {
            guesses[15] = 'p';
            CheckGame(guesses, word);
            PButton.Visibility = Visibility.Collapsed;

        }
        private void qClick(object sender, RoutedEventArgs e)
        {
            guesses[16] = 'q';
            CheckGame(guesses, word);
            QButton.Visibility = Visibility.Collapsed;

        }
        private void rClick(object sender, RoutedEventArgs e)
        {
            guesses[17] = 'r';

            CheckGame(guesses, word);
            RButton.Visibility = Visibility.Collapsed;
        }
        private void sClick(object sender, RoutedEventArgs e)
        {
            guesses[18] = 's';
            CheckGame(guesses, word);
            SButton.Visibility = Visibility.Collapsed;

        }
        private void tClick(object sender, RoutedEventArgs e)
        {
            guesses[19] = 't';
            CheckGame(guesses, word);
            TButton.Visibility = Visibility.Collapsed;

        }
        private void uClick(object sender, RoutedEventArgs e)
        {
            guesses[20] = 'u';
            CheckGame(guesses, word);
            UButton.Visibility = Visibility.Collapsed;

        }
        private void vClick(object sender, RoutedEventArgs e)
        {
            guesses[21] = 'v';
            CheckGame(guesses, word);
            VButton.Visibility = Visibility.Collapsed;

        }
        private void wClick(object sender, RoutedEventArgs e)
        {
            guesses[22] = 'w';
            CheckGame(guesses, word);
            WButton.Visibility = Visibility.Collapsed;

        }
        private void xClick(object sender, RoutedEventArgs e)
        {
            guesses[23] = 'x';
            CheckGame(guesses, word);
            XButton.Visibility = Visibility.Collapsed;

        }
        private void yClick(object sender, RoutedEventArgs e)
        {
            guesses[24] = 'y';

            CheckGame(guesses, word);
            YButton.Visibility = Visibility.Collapsed;
        }
        private void zClick(object sender, RoutedEventArgs e)
        {
            guesses[25] = 'z';

            CheckGame(guesses, word);
            ZButton.Visibility = Visibility.Collapsed;
        }
    }
}
