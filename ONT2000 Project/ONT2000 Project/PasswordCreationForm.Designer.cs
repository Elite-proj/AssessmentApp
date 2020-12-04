namespace ONT2000_Project
{
    partial class PasswordCreationForm
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
            this.components = new System.ComponentModel.Container();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.userIcon = new FontAwesome.Sharp.IconPictureBox();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.passwordIcon = new FontAwesome.Sharp.IconPictureBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnCheckEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordError)).BeginInit();
            this.SuspendLayout();
            // 
            // emailPanel
            // 
            this.emailPanel.BackColor = System.Drawing.Color.White;
            this.emailPanel.Location = new System.Drawing.Point(161, 152);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(450, 1);
            this.emailPanel.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(221, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 37);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TabStop = false;
            this.txtEmail.Text = "Email Address";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.userIcon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userIcon.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.userIcon.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userIcon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.userIcon.IconSize = 43;
            this.userIcon.Location = new System.Drawing.Point(161, 93);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(54, 43);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userIcon.TabIndex = 7;
            this.userIcon.TabStop = false;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.White;
            this.passwordPanel.Location = new System.Drawing.Point(161, 223);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(450, 1);
            this.passwordPanel.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(221, 180);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(390, 37);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Create New Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // passwordIcon
            // 
            this.passwordIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwordIcon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.passwordIcon.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordIcon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.passwordIcon.IconSize = 43;
            this.passwordIcon.Location = new System.Drawing.Point(161, 174);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(54, 43);
            this.passwordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.passwordIcon.TabIndex = 10;
            this.passwordIcon.TabStop = false;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Gold;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnContinue.Location = new System.Drawing.Point(264, 280);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(206, 58);
            this.btnContinue.TabIndex = 13;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnCheckEmail
            // 
            this.btnCheckEmail.BackColor = System.Drawing.Color.Gold;
            this.btnCheckEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCheckEmail.Location = new System.Drawing.Point(264, 344);
            this.btnCheckEmail.Name = "btnCheckEmail";
            this.btnCheckEmail.Size = new System.Drawing.Size(206, 58);
            this.btnCheckEmail.TabIndex = 14;
            this.btnCheckEmail.Text = "CHECK";
            this.btnCheckEmail.UseVisualStyleBackColor = false;
            this.btnCheckEmail.Click += new System.EventHandler(this.btnCheckEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Provide your Email for identification";
            // 
            // emailError
            // 
            this.emailError.ContainerControl = this;
            // 
            // passwordError
            // 
            this.passwordError.ContainerControl = this;
            // 
            // PasswordCreationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckEmail);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.passwordIcon);
            this.Controls.Add(this.emailPanel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.userIcon);
            this.Name = "PasswordCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordCreationForm";
            this.Load += new System.EventHandler(this.PasswordCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.TextBox txtEmail;
        private FontAwesome.Sharp.IconPictureBox userIcon;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox txtPassword;
        private FontAwesome.Sharp.IconPictureBox passwordIcon;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnCheckEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider emailError;
        private System.Windows.Forms.ErrorProvider passwordError;
    }
}