namespace MessengerDraft_1
{
    public partial class MainForm : Form
    {
        List<Panel> contactList = new List<Panel>();
        public MainForm()
        {
            InitializeComponent();
            btnbackMain.BackColor = Color.Transparent;
        }



        private void signUpInToolStripMenuItem_Click(object sender, EventArgs e)
        {

            logForm lgform = new logForm();
            lgform.Show();

            this.Hide();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserForm addForm = new addUserForm();

            addForm.Show();

            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
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
            lbl.Text = rtbMessage.Text;
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

            rtbMessage.Clear();

        }

        private void fopContact_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
