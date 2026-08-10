using System.Text;
using System.Net.Sockets;
using System.Net.Sockets;

namespace MessengerDraft_1
{
    public partial class MainForm : Form
    {
        private Client client;

     
        private Contact currentContact;

        public MainForm(string userId,Client client)
        {
            InitializeComponent();
            this.client = client;
            lblUsersId.Text = userId;
            btnbackMain.BackColor = Color.Transparent;
        }

        List<Panel> myContactListPanel = new List<Panel>();
        List<Contact> myContacts = new List<Contact>();
        List<Message> allMsg = new List<Message>();
        



        private void signUpInToolStripMenuItem_Click(object sender, EventArgs e)
        {

            logForm lgform = new logForm();
            lgform.Show();

            this.Hide();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserForm addForm = new addUserForm(this,client,lblUsersId.Text);


            addForm.Show();

            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            client.Disconnect();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                client.MessageReceived += clientMessageReceived;
                client.StartListening();
            }
            catch (Exception ex) { 
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }
        }

        private void clientMessageReceived(string text)
        {
            this.Invoke(() =>
            {
                if (!text.StartsWith("MESSAGE:"))
                    return;

                string data =
                    text.Substring("MESSAGE:".Length);

                string[] parts = data.Split('|', 2);

                if (parts.Length != 2)
                    return;

                Message message = new Message();

                message.senderId = parts[0];
                message.recreiverId = lblUsersId.Text;
                message.messageText = parts[1];
                message.time = DateTime.Now;

                allMsg.Add(message);

                if (currentContact != null &&
                    currentContact.id == message.senderId)
                {
                    loadConversation(currentContact);
                }
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           
            if (currentContact == null)
            {
                MessageBox.Show("Please select a contact.");
                return;
            }

            if (string.IsNullOrEmpty(rtbMessage.Text))
            {
                return;
            }
            Message message = new Message();

            message.senderId = lblUsersId.Text;
            message.messageText = rtbMessage.Text;
            message.time = DateTime.Now;
            message.recreiverId = currentContact.id;

            messageOwnDisplay(message);
            allMsg.Add(message);
            string send = $"SEND_MESSAGE:{lblUsersId.Text}|{currentContact.id}|{rtbMessage.Text}";


            client.Send(send);
            rtbMessage.Clear();

        }

      

        private void pbProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog profilePic = new OpenFileDialog();

            profilePic.Title = "Select a profile picture";
            profilePic.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (profilePic.ShowDialog() == DialogResult.OK)
            {
                pbProfile.Image = Image.FromFile(profilePic.FileName);
                pbProfile.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void addContactToFlow(Contact contacts)
        {
            Panel singleContactPanel = new Panel();
            singleContactPanel.Size = new Size(362, 50);
            singleContactPanel.BackColor = Color.White;
            singleContactPanel.BorderStyle = BorderStyle.FixedSingle;
            singleContactPanel.Margin = new Padding(3);


            Label lblIdOfContact = new Label();
            lblIdOfContact.Text = contacts.id;
            lblIdOfContact.Location = new Point(10, 15);
            lblIdOfContact.AutoSize = true;
            lblIdOfContact.Font = new Font("Segoe UI", 8, FontStyle.Regular);

            Label lblNameOfContact = new Label();
            lblNameOfContact.Text = contacts.name;
            lblNameOfContact.Location = new Point(130, 15);
            lblNameOfContact.AutoSize = true;
            lblNameOfContact.Font = new Font("Segoe UI", 8, FontStyle.Regular);

            Label lblStatus = new Label();
            lblStatus.Text = contacts.status;
            lblStatus.Location = new Point(230, 15);
            lblStatus.AutoSize = true;

            singleContactPanel.Controls.Add(lblIdOfContact);
            singleContactPanel.Controls.Add(lblNameOfContact);
            singleContactPanel.Controls.Add(lblStatus);

            singleContactPanel.Tag = contacts;

            singleContactPanel.Click += contact_Click;
            lblIdOfContact.Click += contact_Click;
            lblNameOfContact.Click += contact_Click;
            lblStatus.Click += contact_Click;

            fopContact.Controls.Add(singleContactPanel);
        }

        public void AddContact(Contact contact)
        {
            myContacts.Add(contact);

            addContactToFlow(contact);
        }

        public void contact_Click(object sender, EventArgs e)
        {

            Control clicked = (Control)sender;

            Panel clicked_Panel;

            if (clicked is Panel)
            {
                clicked_Panel = (Panel)clicked;
            }
            else
            {
                clicked_Panel = (Panel)clicked.Parent;
            }
            Contact selectedContact = (Contact)clicked_Panel.Tag;

            currentContact = (Contact)clicked_Panel.Tag;
            loadConversation(currentContact);

        }

        private void loadConversation(Contact contact)
        {
            floMsg.Controls.Clear();

            foreach (Message msg in allMsg)
            {
                if ((msg.senderId == lblUsersId.Text && msg.recreiverId == contact.id) || (msg.senderId == contact.id && msg.recreiverId == lblUsersId.Text))
                {
                    if (msg.senderId == lblUsersId.Text)
                    {
                        messageOwnDisplay(msg);
                    }
                    else
                    {
                        messageOThersDisplay(msg);
                    }
                }

            }

        }

        private void messageOwnDisplay(Message message)
        {
            Panel row = new Panel();
            row.Width = floMsg.ClientSize.Width - 25;
            row.AutoSize = true;
            row.BackColor = Color.Transparent;
            row.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            Panel msg = new Panel();
            msg.AutoSize = true;
            msg.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            msg.BackColor = Color.Transparent;
            msg.Padding = new Padding(10);
            msg.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            msg.Location = new Point(row.ClientSize.Width - msg.PreferredSize.Width, 10);


            Label lbl = new Label();
            lbl.Text = message.messageText;
            lbl.AutoSize = true;
            lbl.BackColor = Color.White;
            lbl.Font = new Font("Sage UI", 15, FontStyle.Regular);
            lbl.MaximumSize = new Size(180, 0);
            lbl.Location = new Point(10, 10);


            msg.Controls.Add(lbl);
            msg.PerformLayout();
            msg.Size = msg.PreferredSize;

            msg.Location = new Point(row.Width - msg.Width - 10, 10);

            row.Height = row.Height + 20;
            row.Controls.Add(msg);

            floMsg.Controls.Add(row);
        }

        private void messageOThersDisplay(Message message)
        {
            Panel row = new Panel();
            row.Width = floMsg.ClientSize.Width - 25;
            row.AutoSize = true;
            row.BackColor = Color.Cyan;
            row.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            Panel msg = new Panel();
            msg.AutoSize = true;
            msg.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            msg.BackColor = Color.Cyan;
            msg.Padding = new Padding(10);
            msg.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            msg.Location = new Point(row.ClientSize.Width - msg.PreferredSize.Width, 10);


            Label lbl = new Label();
            lbl.Text = message.messageText;
            lbl.AutoSize = true;
            lbl.BackColor = Color.White;
            lbl.Font = new Font("Sage UI", 15, FontStyle.Regular);
            lbl.MaximumSize = new Size(180, 0);
            lbl.Location = new Point(10, 10);


            msg.Controls.Add(lbl);
            msg.PerformLayout();
            msg.Size = msg.PreferredSize;

            msg.Location = new Point(10, 10);

            row.Height = row.Height + 20;
            row.Controls.Add(msg);

            floMsg.Controls.Add(row);
        }
        
        
    }
}
