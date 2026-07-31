namespace MessengerDraft_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbMessages = new RichTextBox();
            lblText = new Label();
            tbxMessage = new TextBox();
            btnSend = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            moreToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tbxSearch = new TextBox();
            lblSearch = new Label();
            btnSearch = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rtbMessages
            // 
            rtbMessages.BackColor = Color.FromArgb(255, 255, 227);
            rtbMessages.Location = new Point(396, 62);
            rtbMessages.Name = "rtbMessages";
            rtbMessages.ReadOnly = true;
            rtbMessages.Size = new Size(428, 367);
            rtbMessages.TabIndex = 0;
            rtbMessages.Text = "";
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.BackColor = Color.FromArgb(128, 255, 255);
            lblText.Location = new Point(396, 444);
            lblText.Name = "lblText";
            lblText.Size = new Size(28, 15);
            lblText.TabIndex = 2;
            lblText.Text = "Text";
            // 
            // tbxMessage
            // 
            tbxMessage.Location = new Point(441, 441);
            tbxMessage.Name = "tbxMessage";
            tbxMessage.Size = new Size(307, 23);
            tbxMessage.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.Image = Properties.Resources.sendIcon;
            btnSend.Location = new Point(766, 435);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 32);
            btnSend.TabIndex = 4;
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackgroundImage = Properties.Resources.chatList;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(21, 68);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(276, 414);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { moreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(890, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // moreToolStripMenuItem
            // 
            moreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutUsToolStripMenuItem, exitToolStripMenuItem });
            moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            moreToolStripMenuItem.Size = new Size(47, 20);
            moreToolStripMenuItem.Text = "More";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(122, 22);
            aboutUsToolStripMenuItem.Text = "About us";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(122, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(79, 39);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(154, 23);
            tbxSearch.TabIndex = 7;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(28, 42);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Search:";
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.search4;
            btnSearch.Location = new Point(239, 39);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(58, 26);
            btnSearch.TabIndex = 9;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = Properties.Resources.back;
            ClientSize = new Size(890, 494);
            Controls.Add(btnSearch);
            Controls.Add(lblSearch);
            Controls.Add(tbxSearch);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnSend);
            Controls.Add(tbxMessage);
            Controls.Add(lblText);
            Controls.Add(rtbMessages);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbMessages;
        private Label lblText;
        private TextBox tbxMessage;
        private Button btnSend;
        private FlowLayoutPanel flowLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem moreToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox tbxSearch;
        private Label lblSearch;
        private Button btnSearch;
    }
}
