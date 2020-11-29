namespace ONT2000_Project
{
    partial class WelcomeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToRegister = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ONT2000_Project.Properties.Resources.nmu_logo;
            this.pictureBox1.Location = new System.Drawing.Point(221, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(216, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO OUR APPLICATION";
            // 
            // btnGoToRegister
            // 
            this.btnGoToRegister.BackColor = System.Drawing.Color.Gold;
            this.btnGoToRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToRegister.Location = new System.Drawing.Point(152, 328);
            this.btnGoToRegister.Name = "btnGoToRegister";
            this.btnGoToRegister.Size = new System.Drawing.Size(184, 50);
            this.btnGoToRegister.TabIndex = 2;
            this.btnGoToRegister.Text = "Register new admin";
            this.btnGoToRegister.UseVisualStyleBackColor = false;
            this.btnGoToRegister.Click += new System.EventHandler(this.btnGoToRegister_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(447, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGoToRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToRegister;
        private System.Windows.Forms.Button button1;
    }
}