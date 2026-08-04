using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerDraft_1
{
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
        }

        private void signUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            string userId = tbxUserIdSU.Text;
            string name = tbxNameSU.Text;
            string password = tbxPasswordSU.Text;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("None of the fields can be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                MainForm mainForm = new MainForm(userId);
                MessageBox.Show("Sign Up successful! Welcome, " + name + "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.Show();
                this.Hide();
            }
        }

        private void btnbackSignUp_Click(object sender, EventArgs e)
        {
            logForm lgForm= new logForm();

            lgForm.Show();

            this.Hide();
        }
    }
}
