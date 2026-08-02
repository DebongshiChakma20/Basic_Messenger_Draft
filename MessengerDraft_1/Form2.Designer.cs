namespace MessengerDraft_1
{
    partial class logForm
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
            panel1 = new Panel();
            linkLabelSI = new LinkLabel();
            btnSignIn = new Button();
            tbxPass = new TextBox();
            tbxName = new TextBox();
            lblPass = new Label();
            lblName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.signinPanelBackground;
            panel1.Controls.Add(linkLabelSI);
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(tbxPass);
            panel1.Controls.Add(tbxName);
            panel1.Controls.Add(lblPass);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(275, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 356);
            panel1.TabIndex = 0;
            // 
            // linkLabelSI
            // 
            linkLabelSI.AutoSize = true;
            linkLabelSI.Location = new Point(182, 262);
            linkLabelSI.Margin = new Padding(4, 0, 4, 0);
            linkLabelSI.Name = "linkLabelSI";
            linkLabelSI.Size = new Size(151, 21);
            linkLabelSI.TabIndex = 9;
            linkLabelSI.TabStop = true;
            linkLabelSI.Text = "Click here to sign up";
            linkLabelSI.LinkClicked += linkLabelSI_LinkClicked;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(192, 193);
            btnSignIn.Margin = new Padding(4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(129, 49);
            btnSignIn.TabIndex = 8;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            // 
            // tbxPass
            // 
            tbxPass.Location = new Point(122, 139);
            tbxPass.Margin = new Padding(4);
            tbxPass.Name = "tbxPass";
            tbxPass.PasswordChar = '*';
            tbxPass.Size = new Size(298, 29);
            tbxPass.TabIndex = 6;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(122, 76);
            tbxName.Margin = new Padding(4);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(298, 29);
            tbxName.TabIndex = 7;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12F);
            lblPass.Location = new Point(13, 142);
            lblPass.Margin = new Padding(4, 0, 4, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(79, 21);
            lblPass.TabIndex = 4;
            lblPass.Text = "Password:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(35, 74);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 21);
            lblName.TabIndex = 5;
            lblName.Text = "User Id:";
            // 
            // logForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.signinpanel;
            ClientSize = new Size(1029, 630);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "logForm";
            Text = "Sign in or up";
            FormClosing += logForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabelSI;
        private Button btnSignIn;
        private TextBox tbxPass;
        private TextBox tbxName;
        private Label lblPass;
        private Label lblName;
    }
}