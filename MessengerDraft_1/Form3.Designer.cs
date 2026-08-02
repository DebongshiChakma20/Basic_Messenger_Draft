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
            tbxName = new TextBox();
            tbxUserIdSU = new TextBox();
            lblPassSU = new Label();
            lblName = new Label();
            lblUserIdSU = new Label();
            signUpPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // signUpPanel2
            // 
            signUpPanel2.BackgroundImage = Properties.Resources.signupPanel;
            signUpPanel2.Controls.Add(btSignUp);
            signUpPanel2.Controls.Add(tbxPasswordSU);
            signUpPanel2.Controls.Add(tbxName);
            signUpPanel2.Controls.Add(tbxUserIdSU);
            signUpPanel2.Controls.Add(lblPassSU);
            signUpPanel2.Controls.Add(lblName);
            signUpPanel2.Controls.Add(lblUserIdSU);
            signUpPanel2.Location = new Point(177, 76);
            signUpPanel2.Name = "signUpPanel2";
            signUpPanel2.Size = new Size(425, 293);
            signUpPanel2.TabIndex = 0;
            // 
            // btSignUp
            // 
            btSignUp.Font = new Font("Segoe UI", 12F);
            btSignUp.Location = new Point(170, 203);
            btSignUp.Name = "btSignUp";
            btSignUp.Size = new Size(133, 46);
            btSignUp.TabIndex = 11;
            btSignUp.Text = "Sign up";
            btSignUp.UseVisualStyleBackColor = true;
            // 
            // tbxPasswordSU
            // 
            tbxPasswordSU.Location = new Point(130, 144);
            tbxPasswordSU.Name = "tbxPasswordSU";
            tbxPasswordSU.PasswordChar = '*';
            tbxPasswordSU.Size = new Size(235, 23);
            tbxPasswordSU.TabIndex = 8;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(130, 95);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(235, 23);
            tbxName.TabIndex = 9;
            // 
            // tbxUserIdSU
            // 
            tbxUserIdSU.Location = new Point(130, 46);
            tbxUserIdSU.Name = "tbxUserIdSU";
            tbxUserIdSU.Size = new Size(235, 23);
            tbxUserIdSU.TabIndex = 10;
            // 
            // lblPassSU
            // 
            lblPassSU.AutoSize = true;
            lblPassSU.Font = new Font("Segoe UI", 12F);
            lblPassSU.Location = new Point(45, 142);
            lblPassSU.Name = "lblPassSU";
            lblPassSU.Size = new Size(79, 21);
            lblPassSU.TabIndex = 7;
            lblPassSU.Text = "Password:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(62, 93);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 21);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            // 
            // lblUserIdSU
            // 
            lblUserIdSU.AutoSize = true;
            lblUserIdSU.Font = new Font("Segoe UI", 12F);
            lblUserIdSU.Location = new Point(62, 44);
            lblUserIdSU.Name = "lblUserIdSU";
            lblUserIdSU.Size = new Size(62, 21);
            lblUserIdSU.TabIndex = 5;
            lblUserIdSU.Text = "User Id:";
            // 
            // signUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.signUpBack;
            ClientSize = new Size(800, 450);
            Controls.Add(signUpPanel2);
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
        private TextBox tbxName;
        private TextBox tbxUserIdSU;
        private Label lblPassSU;
        private Label lblName;
        private Label lblUserIdSU;
    }
}