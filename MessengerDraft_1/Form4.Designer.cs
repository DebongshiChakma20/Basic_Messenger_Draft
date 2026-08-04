namespace MessengerDraft_1
{
    partial class addUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            floSearch = new FlowLayoutPanel();
            panel1 = new Panel();
            btnAddUserSearch = new Button();
            lblSearch = new Label();
            tbxSearch = new TextBox();
            btnbackAddUser = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // floSearch
            // 
            floSearch.BackgroundImage = Properties.Resources.addPanelBAck;
            floSearch.Location = new Point(1, 140);
            floSearch.Margin = new Padding(3, 4, 3, 4);
            floSearch.Name = "floSearch";
            floSearch.Size = new Size(898, 408);
            floSearch.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddUserSearch);
            panel1.Controls.Add(lblSearch);
            panel1.Controls.Add(tbxSearch);
            panel1.Location = new Point(169, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 80);
            panel1.TabIndex = 4;
            // 
            // btnAddUserSearch
            // 
            btnAddUserSearch.Font = new Font("Segoe UI", 10F);
            btnAddUserSearch.Location = new Point(429, 19);
            btnAddUserSearch.Margin = new Padding(3, 4, 3, 4);
            btnAddUserSearch.Name = "btnAddUserSearch";
            btnAddUserSearch.Size = new Size(86, 44);
            btnAddUserSearch.TabIndex = 6;
            btnAddUserSearch.Text = "Search";
            btnAddUserSearch.UseVisualStyleBackColor = true;
            btnAddUserSearch.Click += btnAddUserSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F);
            lblSearch.Location = new Point(45, 25);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(74, 28);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search:";
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(120, 23);
            tbxSearch.Margin = new Padding(3, 4, 3, 4);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(301, 27);
            tbxSearch.TabIndex = 4;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // btnbackAddUser
            // 
            btnbackAddUser.BackgroundImage = Properties.Resources.backArrow;
            btnbackAddUser.Location = new Point(14, 16);
            btnbackAddUser.Margin = new Padding(3, 4, 3, 4);
            btnbackAddUser.Name = "btnbackAddUser";
            btnbackAddUser.Size = new Size(55, 27);
            btnbackAddUser.TabIndex = 13;
            btnbackAddUser.UseVisualStyleBackColor = true;
            btnbackAddUser.Click += btnbackAddUser_Click;
            // 
            // addUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.addPanel;
            ClientSize = new Size(900, 600);
            Controls.Add(btnbackAddUser);
            Controls.Add(panel1);
            Controls.Add(floSearch);
            Margin = new Padding(3, 4, 3, 4);
            Name = "addUserForm";
            Text = "Add User";
            FormClosing += addUserForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel floSearch;
        private Panel panel1;
        private Button btnAddUserSearch;
        private Label lblSearch;
        private TextBox tbxSearch;
        private Button btnbackAddUser;
    }
}