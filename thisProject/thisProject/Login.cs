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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "ztier" && tbPass.Text == "2479")
            {
                this.Hide();
                gamePicker form = new gamePicker();
                form.ShowDialog();
               
            }
            else
            {
                string error = "Wrong username or password!";
                MessageBox.Show(error, "Oops!", MessageBoxButtons.OK);
            }
        }
    }
}

