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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            lblSearch = new Label();
            tbxSearch = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImage = Properties.Resources.addPanelBAck;
            flowLayoutPanel1.Location = new Point(12, 101);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 306);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblSearch);
            panel1.Controls.Add(tbxSearch);
            panel1.Location = new Point(148, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 60);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(375, 14);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F);
            lblSearch.Location = new Point(39, 19);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(60, 21);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search:";
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(105, 17);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(264, 23);
            tbxSearch.TabIndex = 4;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // addUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.addPanel;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "addUserForm";
            Text = "Add User";
            FormClosing += addUserForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button button1;
        private Label lblSearch;
        private TextBox tbxSearch;
    }
}