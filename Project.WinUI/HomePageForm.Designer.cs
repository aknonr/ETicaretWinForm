namespace Project.WinUI.NewFolder1
{
    partial class HomePageForm
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
            this.txtUserNamr = new System.Windows.Forms.TextBox();
            this.txtPassaword = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnFirmaKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserNamr
            // 
            this.txtUserNamr.Location = new System.Drawing.Point(368, 142);
            this.txtUserNamr.Name = "txtUserNamr";
            this.txtUserNamr.Size = new System.Drawing.Size(100, 20);
            this.txtUserNamr.TabIndex = 0;
            // 
            // txtPassaword
            // 
            this.txtPassaword.Location = new System.Drawing.Point(368, 191);
            this.txtPassaword.Name = "txtPassaword";
            this.txtPassaword.Size = new System.Drawing.Size(100, 20);
            this.txtPassaword.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(294, 256);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 44);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giris";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(416, 256);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(103, 44);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Kaydol";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnFirmaKayit
            // 
            this.btnFirmaKayit.Location = new System.Drawing.Point(548, 256);
            this.btnFirmaKayit.Name = "btnFirmaKayit";
            this.btnFirmaKayit.Size = new System.Drawing.Size(96, 44);
            this.btnFirmaKayit.TabIndex = 5;
            this.btnFirmaKayit.Text = "Firma Kayit";
            this.btnFirmaKayit.UseVisualStyleBackColor = true;
            this.btnFirmaKayit.Click += new System.EventHandler(this.btnFirmaKayit_Click);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFirmaKayit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassaword);
            this.Controls.Add(this.txtUserNamr);
            this.Name = "HomePageForm";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserNamr;
        private System.Windows.Forms.TextBox txtPassaword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnFirmaKayit;
    }
}