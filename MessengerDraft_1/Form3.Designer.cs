namespace MessengerDraft_1
{
    partial class signUpForm
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
            signUpPanel2 = new Panel();
            btSignUp = new Button();
            tbxPasswordSU = new TextBox();
            tbxNameSU = new TextBox();
            tbxUserIdSU = new TextBox();
            lblPassSU = new Label();
            lblName = new Label();
            lblUserIdSU = new Label();
            btnbackSignUp = new Button();
            signUpPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // signUpPanel2
            // 
            signUpPanel2.BackgroundImage = Properties.Resources.signupPanel;
            signUpPanel2.Controls.Add(btSignUp);
            signUpPanel2.Controls.Add(tbxPasswordSU);
            signUpPanel2.Controls.Add(tbxNameSU);
            signUpPanel2.Controls.Add(tbxUserIdSU);
            signUpPanel2.Controls.Add(lblPassSU);
            signUpPanel2.Controls.Add(lblName);
            signUpPanel2.Controls.Add(lblUserIdSU);
            signUpPanel2.Location = new Point(297, 121);
            signUpPanel2.Margin = new Padding(3, 4, 3, 4);
            signUpPanel2.Name = "signUpPanel2";
            signUpPanel2.Size = new Size(486, 354);
            signUpPanel2.TabIndex = 0;
            // 
            // btSignUp
            // 
            btSignUp.Font = new Font("Segoe UI", 12F);
            btSignUp.Location = new Point(171, 265);
            btSignUp.Margin = new Padding(3, 4, 3, 4);
            btSignUp.Name = "btSignUp";
            btSignUp.Size = new Size(152, 61);
            btSignUp.TabIndex = 11;
            btSignUp.Text = "Sign up";
            btSignUp.UseVisualStyleBackColor = true;
            btSignUp.Click += btSignUp_Click;
            // 
            // tbxPasswordSU
            // 
            tbxPasswordSU.Location = new Point(149, 192);
            tbxPasswordSU.Margin = new Padding(3, 4, 3, 4);
            tbxPasswordSU.Name = "tbxPasswordSU";
            tbxPasswordSU.PasswordChar = '*';
            tbxPasswordSU.Size = new Size(268, 27);
            tbxPasswordSU.TabIndex = 8;
            // 
            // tbxNameSU
            // 
            tbxNameSU.Location = new Point(149, 127);
            tbxNameSU.Margin = new Padding(3, 4, 3, 4);
            tbxNameSU.Name = "tbxNameSU";
            tbxNameSU.Size = new Size(268, 27);
            tbxNameSU.TabIndex = 9;
            // 
            // tbxUserIdSU
            // 
            tbxUserIdSU.Location = new Point(149, 61);
            tbxUserIdSU.Margin = new Padding(3, 4, 3, 4);
            tbxUserIdSU.Name = "tbxUserIdSU";
            tbxUserIdSU.Size = new Size(268, 27);
            tbxUserIdSU.TabIndex = 10;
            // 
            // lblPassSU
            // 
            lblPassSU.AutoSize = true;
            lblPassSU.Font = new Font("Segoe UI", 12F);
            lblPassSU.Location = new Point(51, 189);
            lblPassSU.Name = "lblPassSU";
            lblPassSU.Size = new Size(97, 28);
            lblPassSU.TabIndex = 7;
            lblPassSU.Text = "Password:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(71, 124);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 28);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            // 
            // lblUserIdSU
            // 
            lblUserIdSU.AutoSize = true;
            lblUserIdSU.Font = new Font("Segoe UI", 12F);
            lblUserIdSU.Location = new Point(71, 59);
            lblUserIdSU.Name = "lblUserIdSU";
            lblUserIdSU.Size = new Size(77, 28);
            lblUserIdSU.TabIndex = 5;
            lblUserIdSU.Text = "User Id:";
            // 
            // btnbackSignUp
            // 
            btnbackSignUp.BackgroundImage = Properties.Resources.backArrow;
            btnbackSignUp.Location = new Point(14, 4);
            btnbackSignUp.Margin = new Padding(3, 4, 3, 4);
            btnbackSignUp.Name = "btnbackSignUp";
            btnbackSignUp.Size = new Size(55, 26);
            btnbackSignUp.TabIndex = 13;
            btnbackSignUp.UseVisualStyleBackColor = true;
            btnbackSignUp.Click += btnbackSignUp_Click;
            // 
            // signUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.signUpBack;
            ClientSize = new Size(1007, 557);
            Controls.Add(btnbackSignUp);
            Controls.Add(signUpPanel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "signUpForm";
            Text = "Sign up";
            FormClosing += signUpForm_FormClosing;
            signUpPanel2.ResumeLayout(false);
            signUpPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel signUpPanel2;
        private Button btSignUp;
        private TextBox tbxPasswordSU;
        private TextBox tbxNameSU;
        private TextBox tbxUserIdSU;
        private Label lblPassSU;
        private Label lblName;
        private Label lblUserIdSU;
        private Button btnbackSignUp;
    }
}