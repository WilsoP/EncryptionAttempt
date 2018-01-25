using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Encyption
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        public string output = "";
        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            OutputBox.Text = "";
            string input = "";
            input = InputBox.Text;
            input = input + " ";
            input = input.ToLower();
            E1Method(input);
            OutputBox.Text = output;
        }

        public string E1Method(String input)

        {
            ///Loops through each letter in the input word and then 
            ///increases a counter and adds each letter to a different variable
            ///when it recieves a space character it will stop counting then run 
            ///the Encrypt method
            var temp = "";
            int counter = 0;
            string word;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    counter++;
                    temp += c;
                }
                else
                {
                    word = temp.ToString();
                    E1Encrypt(word, counter);
                    counter = 0;
                    word = "";
                    temp = "";
                }
            }
            return output;
        }

        public string E1Encrypt(string word, int counter)
        {
            string[] Alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string letter = "";

            int n = 0;
            foreach (char c in word)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (c.ToString() == Alphabet[i])
                    {
                        n = i;
                        n = n + counter;
                        if (n > 26)
                        {
                            do
                            {
                                n = n - 26;
                            } while (n > 26);

                        }
                        letter = Alphabet[n].ToString() ;
                        output += letter;
                    }
                }
            }
            output = output + " ";
            return output;
        }
    }
}
/*
 * Encryption Style 1 = take word length shift up alphabet by that amount
 * 
 * 
 * 
 */
