using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharphone
{
    public partial class Loginform : Form
    {
        private const string CorrectUsername = "Daan";
        private int wrongUsernameAttampts = 0;
        private const string CorrectPassword = "1234daan";
        private int wrongPasswordAttempts = 0;

        public Loginform()
        {
            InitializeComponent();
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtPassword.Text;

            if (enteredPassword == CorrectPassword)
            {

                MessageBox.Show("Inloggen gelukt!");
                //Form1 form = new Form1();
                //form.ShowDialog();
                DialogResult = DialogResult.OK;

            }
            else
            {

                wrongPasswordAttempts++;

                if (wrongPasswordAttempts >= 3)
                {
                    MessageBox.Show("Te veel verkeerde pogingen. Het programma wordt afgesloten.");
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Onjuiste inloggegevens. Probeer opnieuw.");
                }
            }



            Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}