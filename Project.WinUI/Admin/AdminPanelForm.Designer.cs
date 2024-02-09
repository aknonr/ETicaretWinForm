namespace Project.WinUI.Admin
{
    partial class AdminPanelForm
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
            this.KullaniciAyarlari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KullaniciAyarlari
            // 
            this.KullaniciAyarlari.Location = new System.Drawing.Point(42, 17);
            this.KullaniciAyarlari.Name = "KullaniciAyarlari";
            this.KullaniciAyarlari.Size = new System.Drawing.Size(188, 63);
            this.KullaniciAyarlari.TabIndex = 0;
            this.KullaniciAyarlari.Text = "Kullanici Ayarlari";
            this.KullaniciAyarlari.UseVisualStyleBackColor = true;
            this.KullaniciAyarlari.Click += new System.EventHandler(this.bntKullaniciGor_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KullaniciAyarlari);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KullaniciAyarlari;
    }
}