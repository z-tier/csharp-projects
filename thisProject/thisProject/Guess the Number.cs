using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thisProject
{
    public partial class guessGame : Form
    {
        public guessGame()
        {
            InitializeComponent();
        }


        int num;
        Random ran = new Random();
        int guesses;

        private void guessGame_Load(object sender, EventArgs e) // when form loads, execute NewGame event
        {
            NewGame();
            Console.WriteLine("form loaded successfully! yayyy!");
            // debug --- IT WORKS NOW THANK YOU STACK OVERFLOW PERSON
        }

        private void NewGame() // new game thingies
        {
            num = ran.Next(1, 101);

            number.Text = "<<number>>";
            tbGuess.Text = "";
            bEnter.Enabled = true;
            guesses = 0;
            numGuesses.Text = "0";
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbGuess.Text, out int guess)) // if not integer, run command
            {
                MessageBox.Show("Enter a valid number!", "Seriously?", MessageBoxButtons.OK); // exception handling
                return; // returns to the if statement to check user input again
            }

            if (guess == num) // if guess is num, then end game
            {
                number.Text = "Correct! The number was " + num + "!";
                bEnter.Enabled = false;
                numGuesses.Text = guesses.ToString();
                hint.Text = "<<hint>>";
            }
            else if (guess != num) // if guess isn't num, give hint and +1 to guesses
            {
                if (guess < num)
                {
                    hint.Text = "Your number is too low!";
                    guesses++;
                    numGuesses.Text = guesses.ToString();
                }
                else
                {
                    hint.Text = "Your number is too high!";
                    guesses++;
                    numGuesses.Text = guesses.ToString();
                }
            }
        }

        private void playAgain_Click(object sender, EventArgs e) // restart game
        {
            NewGame();
        }

        private void pickerReturn_Click(object sender, EventArgs e) // go back to game picker
        {
            this.Hide();
            gamePicker form = new gamePicker();
            form.ShowDialog();
        }
    }
}
