namespace ONT2000_Project
{
    partial class SignIn
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new FontAwesome.Sharp.IconButton();
            this.btnSignIn = new FontAwesome.Sharp.IconButton();
            this.btnCloseIcon = new FontAwesome.Sharp.IconButton();
            this.btnHideIcon = new FontAwesome.Sharp.IconButton();
            this.passwordIcon = new FontAwesome.Sharp.IconPictureBox();
            this.userIcon = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(219, 377);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 37);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TabStop = false;
            this.txtEmail.Text = "Email Address";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // emailPanel
            // 
            this.emailPanel.BackColor = System.Drawing.Color.White;
            this.emailPanel.Location = new System.Drawing.Point(159, 423);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(450, 1);
            this.emailPanel.TabIndex = 3;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.White;
            this.passwordPanel.Location = new System.Drawing.Point(159, 524);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(450, 1);
            this.passwordPanel.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(219, 478);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(390, 37);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegister.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnRegister.IconColor = System.Drawing.Color.White;
            this.btnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegister.IconSize = 48;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(159, 645);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Rotation = 0D;
            this.btnRegister.Size = new System.Drawing.Size(450, 49);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSignIn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSignIn.IconColor = System.Drawing.Color.Navy;
            this.btnSignIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignIn.IconSize = 48;
            this.btnSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignIn.Location = new System.Drawing.Point(159, 568);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Rotation = 0D;
            this.btnSignIn.Size = new System.Drawing.Size(450, 49);
            this.btnSignIn.TabIndex = 11;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnCloseIcon
            // 
            this.btnCloseIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCloseIcon.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCloseIcon.IconColor = System.Drawing.Color.Black;
            this.btnCloseIcon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCloseIcon.IconSize = 25;
            this.btnCloseIcon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloseIcon.Location = new System.Drawing.Point(764, 12);
            this.btnCloseIcon.Name = "btnCloseIcon";
            this.btnCloseIcon.Rotation = 0D;
            this.btnCloseIcon.Size = new System.Drawing.Size(29, 25);
            this.btnCloseIcon.TabIndex = 10;
            this.btnCloseIcon.UseVisualStyleBackColor = true;
            this.btnCloseIcon.Click += new System.EventHandler(this.btnCloseIcon_Click);
            this.btnCloseIcon.MouseEnter += new System.EventHandler(this.btnCloseIcon_MouseEnter);
            this.btnCloseIcon.MouseLeave += new System.EventHandler(this.btnCloseIcon_MouseLeave);
            // 
            // btnHideIcon
            // 
            this.btnHideIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHideIcon.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnHideIcon.IconColor = System.Drawing.Color.Black;
            this.btnHideIcon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHideIcon.IconSize = 45;
            this.btnHideIcon.Location = new System.Drawing.Point(714, 12);
            this.btnHideIcon.Name = "btnHideIcon";
            this.btnHideIcon.Rotation = 0D;
            this.btnHideIcon.Size = new System.Drawing.Size(29, 25);
            this.btnHideIcon.TabIndex = 9;
            this.btnHideIcon.UseVisualStyleBackColor = true;
            this.btnHideIcon.Click += new System.EventHandler(this.btnHideIcon_Click);
            this.btnHideIcon.MouseEnter += new System.EventHandler(this.btnHideIcon_MouseEnter);
            this.btnHideIcon.MouseLeave += new System.EventHandler(this.btnHideIcon_MouseLeave);
            // 
            // passwordIcon
            // 
            this.passwordIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwordIcon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.passwordIcon.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordIcon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.passwordIcon.IconSize = 43;
            this.passwordIcon.Location = new System.Drawing.Point(159, 465);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(54, 43);
            this.passwordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.passwordIcon.TabIndex = 4;
            this.passwordIcon.TabStop = false;
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.userIcon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userIcon.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.userIcon.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userIcon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.userIcon.IconSize = 43;
            this.userIcon.Location = new System.Drawing.Point(159, 364);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(54, 43);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userIcon.TabIndex = 1;
            this.userIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ONT2000_Project.Properties.Resources.Nelson__Logo;
            this.pictureBox1.Location = new System.Drawing.Point(159, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(805, 804);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnCloseIcon);
            this.Controls.Add(this.btnHideIcon);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.passwordIcon);
            this.Controls.Add(this.emailPanel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox userIcon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox txtPassword;
        private FontAwesome.Sharp.IconPictureBox passwordIcon;
        private FontAwesome.Sharp.IconButton btnHideIcon;
        private FontAwesome.Sharp.IconButton btnCloseIcon;
        private FontAwesome.Sharp.IconButton btnSignIn;
        private FontAwesome.Sharp.IconButton btnRegister;
    }
}

