namespace ONT2000_Project
{
    partial class ManageUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnRegisterUser = new FontAwesome.Sharp.IconButton();
            this.txtNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSurnameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.titleError = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.roleError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurnameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "SURNAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "TITLE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "ROLE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "EMAIL:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(286, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(487, 39);
            this.txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(336, 140);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(487, 39);
            this.txtSurname.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(287, 368);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(487, 39);
            this.txtEmail.TabIndex = 7;
            // 
            // cmbTitle
            // 
            this.cmbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(278, 212);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(545, 37);
            this.cmbTitle.TabIndex = 8;
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(278, 296);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(545, 37);
            this.cmbRole.TabIndex = 9;
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.BackColor = System.Drawing.Color.White;
            this.btnRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegisterUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnRegisterUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegisterUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegisterUser.IconSize = 48;
            this.btnRegisterUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterUser.Location = new System.Drawing.Point(397, 466);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Rotation = 0D;
            this.btnRegisterUser.Size = new System.Drawing.Size(265, 60);
            this.btnRegisterUser.TabIndex = 14;
            this.btnRegisterUser.Text = "Register User";
            this.btnRegisterUser.UseVisualStyleBackColor = false;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // txtNameError
            // 
            this.txtNameError.ContainerControl = this;
            // 
            // txtSurnameError
            // 
            this.txtSurnameError.ContainerControl = this;
            // 
            // titleError
            // 
            this.titleError.ContainerControl = this;
            // 
            // emailError
            // 
            this.emailError.ContainerControl = this;
            // 
            // roleError
            // 
            this.roleError.ContainerControl = this;
            // 
            // ManageUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(991, 578);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.cmbTitle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurnameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.ComboBox cmbRole;
        private FontAwesome.Sharp.IconButton btnRegisterUser;
        private System.Windows.Forms.ErrorProvider txtNameError;
        private System.Windows.Forms.ErrorProvider txtSurnameError;
        private System.Windows.Forms.ErrorProvider titleError;
        private System.Windows.Forms.ErrorProvider emailError;
        private System.Windows.Forms.ErrorProvider roleError;
    }
}