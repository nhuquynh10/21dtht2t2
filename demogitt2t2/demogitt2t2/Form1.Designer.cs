namespace demogitt2t2
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
            lbUserName = new Label();
            txtUserName = new TextBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(84, 68);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(78, 20);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(204, 65);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(232, 27);
            txtUserName.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(84, 116);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(204, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(232, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(204, 185);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtUserName);
            Controls.Add(lbUserName);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private TextBox txtUserName;

        private Label lbPassword;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
