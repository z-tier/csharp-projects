using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thisProject
{
    public partial class rpsGame : Form
    {
        public rpsGame()
        {
            InitializeComponent();
        }

        Random ran = new Random(); // computer random number
        int pts = 0; // points
        

        private void bRock_Click(object sender, EventArgs e)
        {
            playerPick.Text = "You chose Rock!";

            /*
            int comPick = ran.Next(1, 4);

            if (comPick == 1)
            {
                computerPick.Text = "Rock";
                winLose.Text = "Draw!";
            }
            else if (comPick == 2)
            {
                computerPick.Text = "Paper";
                winLose.Text = "Lose!";
                pts--;
            }
            else if (comPick == 3)
            {
                computerPick.Text = "Scissors";
                winLose.Text = "Win!";
                pts++;
            }

            points.Text = pts.ToString();
            */

            switch (ran.Next(1, 4))
            {
                case 1:
                    computerPick.Text = "Computer chose Rock!";
                    winLose.Text = "It's a Draw!";
                    break;
                case 2:
                    computerPick.Text = "Computer chose Paper!";
                    winLose.Text = "You Lose!";
                    pts--;
                    break;
                case 3:
                    computerPick.Text = "Computer chose Scissors!";
                    winLose.Text = "You Win!";
                    pts++;
                    break;
            }

            points.Text = pts.ToString();
        }

        private void bPaper_Click(object sender, EventArgs e)
        {
            playerPick.Text = "You chose Paper!";

            switch (ran.Next(1, 4))
            {
                case 1:
                    computerPick.Text = "Computer chose Rock!";
                    winLose.Text = "You Win!";
                    pts++;
                    break;
                case 2:
                    computerPick.Text = "Computer chose Paper!";
                    winLose.Text = "It's a Draw!";
                    break;
                case 3:
                    computerPick.Text = "Computer chose Scissors!";
                    winLose.Text = "You Lose!";
                    pts--;
                    break;
            }

            points.Text = pts.ToString();
        }

        private void bScissors_Click(object sender, EventArgs e)
        {
            playerPick.Text = "You chose Scissors!";

            switch (ran.Next(1, 4))
            {
                case 1:
                    computerPick.Text = "Computer chose Rock!";
                    winLose.Text = "You Lose!";
                    pts--;
                    break;
                case 2:
                    computerPick.Text = "Computer chose Paper!";
                    winLose.Text = "You Win!";
                    pts++;
                    break;
                case 3:
                    computerPick.Text = "Computer chose Scissors!";
                    winLose.Text = "It's a Draw!";
                    break;
            }

            points.Text = pts.ToString();
        }

            private void button1_Click(object sender, EventArgs e) // hide rps game when go back to picker
        {
            this.Hide();
            gamePicker form = new gamePicker();
            form.ShowDialog();
        }
    }
}
