using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MessengerDraft_1
{
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
            lblNameSU.BackColor = Color.Transparent;
            lblPassSU.BackColor = Color.Transparent;
            lblUserIdSU.BackColor = Color.Transparent;
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
                if (GlobalData.UserCredentials.ContainsKey(userId))
                {
                    MessageBox.Show("User Id already exists!");
                    return;
                }

                MainForm mainForm = new MainForm(userId);
                MessageBox.Show("Sign Up successful! Welcome, " + name + "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Account created successfully!");
                mainForm.Show();
                this.Hide();
            }


            GlobalData.UserCredentials.Add(userId, password);

           
        }

        private void btnbackSignUp_Click(object sender, EventArgs e)
        {
            logForm lgForm = new logForm();

            lgForm.Show();

            this.Hide();
        }
    }
    public static class GlobalData
    {
        
        public static Dictionary<string, string> UserCredentials = new Dictionary<string, string>();

       
        public static List<string> UserIds = new List<string>();
    }
}