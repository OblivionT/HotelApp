namespace OtelBilgiSistemi
{
    partial class FormGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiriş));
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnGiriş = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnDebugAdmin = new System.Windows.Forms.Button();
            this.btnDebugCustomer = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(99, 80);
            this.txtKullanıcıAdı.MaxLength = 20;
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(132, 20);
            this.txtKullanıcıAdı.TabIndex = 0;
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(99, 125);
            this.txtŞifre.MaxLength = 15;
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.PasswordChar = '•';
            this.txtŞifre.Size = new System.Drawing.Size(132, 20);
            this.txtŞifre.TabIndex = 4;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 83);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(64, 13);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Kullanıcı Adı";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(21, 128);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(28, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Şifre";
            // 
            // btnGiriş
            // 
            this.btnGiriş.Image = ((System.Drawing.Image)(resources.GetObject("btnGiriş.Image")));
            this.btnGiriş.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiriş.Location = new System.Drawing.Point(99, 167);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(132, 33);
            this.btnGiriş.TabIndex = 19;
            this.btnGiriş.Text = "Giriş";
            this.btnGiriş.UseVisualStyleBackColor = true;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 55);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(135, 19);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 24);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Giriş";
            // 
            // btnDebugAdmin
            // 
            this.btnDebugAdmin.Location = new System.Drawing.Point(12, 247);
            this.btnDebugAdmin.Name = "btnDebugAdmin";
            this.btnDebugAdmin.Size = new System.Drawing.Size(101, 23);
            this.btnDebugAdmin.TabIndex = 21;
            this.btnDebugAdmin.Text = "Debug Admin";
            this.btnDebugAdmin.UseVisualStyleBackColor = true;
            this.btnDebugAdmin.Click += new System.EventHandler(this.btnDebugAdmin_Click);
            // 
            // btnDebugCustomer
            // 
            this.btnDebugCustomer.Location = new System.Drawing.Point(208, 247);
            this.btnDebugCustomer.Name = "btnDebugCustomer";
            this.btnDebugCustomer.Size = new System.Drawing.Size(101, 23);
            this.btnDebugCustomer.TabIndex = 22;
            this.btnDebugCustomer.Text = "Debug Customer";
            this.btnDebugCustomer.UseVisualStyleBackColor = true;
            this.btnDebugCustomer.Click += new System.EventHandler(this.btnDebugCustomer_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(9, 217);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(309, 13);
            this.lblWarning.TabIndex = 23;
            this.lblWarning.Text = "*******THESE TWO BUTTONS ARE FOR GITHUB ONLY*******";
            // 
            // FormGiriş
            // 
            this.AcceptButton = this.btnGiriş;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 282);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnDebugCustomer);
            this.Controls.Add(this.btnDebugAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGiriş);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Name = "FormGiriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Bilgi Sistemi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDebugAdmin;
        private System.Windows.Forms.Button btnDebugCustomer;
        private System.Windows.Forms.Label lblWarning;
    }
}

