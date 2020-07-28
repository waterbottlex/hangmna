using System;
using System.Windows;
using System.Windows.Controls;

namespace HangmanGame
{
    /// <summary>
    /// Interaction logic for HangmanEasy.xaml
    /// </summary>
    public partial class HangmanEasy : Page
    {
        public static char[] guesses = new char[26];
        
        public HangmanEasy()
        {
            InitializeComponent();
            bool win = false;
            bool gameover = false;
            string[] words = { "bruh", "poggers" };
            int x = RandomNumber();
            string chosenWord = words[x];
            char[] word = chosenWord.ToCharArray();

            for(int i = 0; i< guesses.Length;i++)
            {
                guesses[i] = '.';
            }

            Console.WriteLine(chosenWord);

            if(guesses[0] == 'a')
            {
                this.NavigationService.Navigate(new Uri("Start.xaml", UriKind.Relative));
            }

            /*
            while (win == false && gameover == false)
            {
                CheckGameOver(guesses,word);
                win = CheckWin(word, guesses);
                
            }
            */
            

        }

        private int RandomNumber()
        {
            Random r = new Random();
            int x = r.Next(0, 2);
            return x;
        }

        private bool CheckGameOver(char[] guesses, char[] word)
        {
            int wrongGuesses = 0;
            bool gameover = false;
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

            if (wrongGuesses >= 7)
            {
                gameover = true;
            }
            return gameover;
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

            bool win = true; 

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
        private void gClick(object sender, RoutedEventArgs e)
        {
            guesses[6] = 'g';
           
        }

        private void hClick(object sender, RoutedEventArgs e)
        {
            guesses[7] = 'h';
       

        }
        private void iClick(object sender, RoutedEventArgs e)
        {
            guesses[8] = 'i';
           

        }
        private void jClick(object sender, RoutedEventArgs e)
        {
            guesses[9] = 'j';
            

        }

        private void kClick(object sender, RoutedEventArgs e)
        {
            guesses[10] = 'k';
         

        }
        private void lClick(object sender, RoutedEventArgs e)
        {
            guesses[11] = 'l';
       

        }
        private void mClick(object sender, RoutedEventArgs e)
        {
            guesses[12] = 'm';
           

        }
        private void nClick(object sender, RoutedEventArgs e)
        {
            guesses[13] = 'n';
         

        }
        private void oClick(object sender, RoutedEventArgs e)
        {
            guesses[14] = 'o';
          

        }
        private void pClick(object sender, RoutedEventArgs e)
        {
            guesses[15] = 'p';
         

        }
        private void qClick(object sender, RoutedEventArgs e)
        {
            guesses[16] = 'q';
         

        }
        private void rClick(object sender, RoutedEventArgs e)
        {
            guesses[17] = 'r';
          

        }
        private void sClick(object sender, RoutedEventArgs e)
        {
            guesses[18] = 's';
           

        }
        private void tClick(object sender, RoutedEventArgs e)
        {
            guesses[19] = 't';
           

        }
        private void uClick(object sender, RoutedEventArgs e)
        {
            guesses[20] = 'u';
            

        }
        private void vClick(object sender, RoutedEventArgs e)
        {
            guesses[21] = 'v';
            

        }
        private void wClick(object sender, RoutedEventArgs e)
        {
            guesses[22] = 'w';
           

        }
        private void xClick(object sender, RoutedEventArgs e)
        {
            guesses[23] = 'x';
            

        }
        private void yClick(object sender, RoutedEventArgs e)
        {
            guesses[24] = 'y';
            

        }
        private void zClick(object sender, RoutedEventArgs e)
        {
            guesses[25] = 'z';
            

        }
    }
}
