namespace MessengerDraft_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string messages = tbxMessage.Text;

            if (!string.IsNullOrEmpty(messages))
            {
                rtbMessages.Text = $" {messages} \n\n";

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
