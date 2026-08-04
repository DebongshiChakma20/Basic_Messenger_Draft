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
    public partial class logForm : Form
    {
        public logForm()
        {
            InitializeComponent();
            lblName.BackColor = Color.Transparent;
            lblPass.BackColor = Color.Transparent;
        }


        private void linkLabelSI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUpForm suForm = new signUpForm();

            suForm.Show();

            this.Hide();
        }

        private void logForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnbackSignIn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();

            this.Hide();

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string userId = tbxUserId.Text;
            string password = tbxPass.Text;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both User ID and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                
                MainForm mainForm = new MainForm(userId);
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
