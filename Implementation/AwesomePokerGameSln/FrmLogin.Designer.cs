namespace AwesomePokerGameSln
{
    partial class FrmLogin
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.forgotPassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.LoginButton.Location = new System.Drawing.Point(376, 394);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(195, 84);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.AcceptsTab = true;
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.usernameInput.Location = new System.Drawing.Point(376, 245);
            this.usernameInput.MaxLength = 20;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(193, 44);
            this.usernameInput.TabIndex = 0;
            // 
            // passwordInput
            // 
            this.passwordInput.AcceptsReturn = true;
            this.passwordInput.AcceptsTab = true;
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.passwordInput.Location = new System.Drawing.Point(376, 295);
            this.passwordInput.MaxLength = 36;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(193, 44);
            this.passwordInput.TabIndex = 1;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(687, 393);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(211, 87);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.ForeColor = System.Drawing.SystemColors.Menu;
            this.UsernameTxt.Location = new System.Drawing.Point(243, 251);
            this.UsernameTxt.MaxLength = 20;
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.ReadOnly = true;
            this.UsernameTxt.Size = new System.Drawing.Size(127, 35);
            this.UsernameTxt.TabIndex = 1;
            this.UsernameTxt.TabStop = false;
            this.UsernameTxt.Text = "Username";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.ForeColor = System.Drawing.SystemColors.Menu;
            this.PasswordTxt.Location = new System.Drawing.Point(243, 301);
            this.PasswordTxt.MaxLength = 0;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.ReadOnly = true;
            this.PasswordTxt.Size = new System.Drawing.Size(127, 35);
            this.PasswordTxt.TabIndex = 1;
            this.PasswordTxt.TabStop = false;
            this.PasswordTxt.Text = "Password";
            // 
            // forgotPassButton
            // 
            this.forgotPassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassButton.Location = new System.Drawing.Point(393, 345);
            this.forgotPassButton.Name = "forgotPassButton";
            this.forgotPassButton.Size = new System.Drawing.Size(166, 31);
            this.forgotPassButton.TabIndex = 2;
            this.forgotPassButton.Text = "Forgot Password?";
            this.forgotPassButton.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.title_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 559);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.forgotPassButton);
            this.Controls.Add(this.LoginButton);
            this.Name = "FrmLogin";
            this.Text = "Awesome Poker Game";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Button forgotPassButton;
    }
}