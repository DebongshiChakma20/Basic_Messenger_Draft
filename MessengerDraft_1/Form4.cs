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
    public partial class addUserForm : Form
    {
        public MainForm mainForm;
        private List<Contact> contacts;
        public addUserForm(MainForm mForm)
        {
            InitializeComponent();
            mainForm = mForm;
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void addUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnbackAddUser_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            mainForm.Show();

            this.Hide();
        }

        private void btnAddUserSearch_Click(object sender, EventArgs e)
        {
            Contact found=ContactRepo.contactUsers.FirstOrDefault(x=>x.id==tbxSearch.Text);

            if (found != null)
            {
                ShowSearchResult(found);
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void ShowSearchResult(Contact contact)
        {
            floSearch.Controls.Clear();

            Panel searchResultPanel = new Panel();
            searchResultPanel.Size = new Size(890, 60);
            searchResultPanel.BorderStyle = BorderStyle.FixedSingle;

            Label lblId=new Label();
            lblId.Text = contact.id;
            lblId.AutoSize=true;
            lblId.Location = new Point(20, 20);

            Label lblName = new Label();
            lblName.Text = contact.name;
            lblName.Location = new Point(300, 20);
            lblName.AutoSize = true;

            Label lblStatus = new Label();
            lblStatus.Text = contact.status;
            lblStatus.Location = new Point(580, 20);
            lblStatus.AutoSize = true;

            Button btnAdd = new Button();
            btnAdd.Text = "Add";
            btnAdd.Location = new Point(780, 17);
            btnAdd.AutoSize = true;

            btnAdd.Tag = contact;
            btnAdd.Click += btnAddUser_Click;


            searchResultPanel.Controls.Add(lblId);
            searchResultPanel.Controls.Add(lblName);
            searchResultPanel.Controls.Add(lblStatus);
            searchResultPanel.Controls.Add(btnAdd);

            floSearch.Controls.Add(searchResultPanel);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            Contact selected = (Contact)btn.Tag;

            mainForm.AddContact(selected);
            mainForm.Show();

            this.Hide();
        }
    }
}
