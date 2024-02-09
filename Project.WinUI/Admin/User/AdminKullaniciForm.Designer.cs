namespace Project.WinUI.Admin
{
    partial class AdminKullaniciForm
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
            this.btnAktifKullanici = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKullaniciAyar = new System.Windows.Forms.Button();
            this.btnKullanicilar = new System.Windows.Forms.Button();
            this.btnPasif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAktifKullanici
            // 
            this.btnAktifKullanici.Location = new System.Drawing.Point(12, 69);
            this.btnAktifKullanici.Name = "btnAktifKullanici";
            this.btnAktifKullanici.Size = new System.Drawing.Size(207, 34);
            this.btnAktifKullanici.TabIndex = 1;
            this.btnAktifKullanici.Text = "Aktif Kullanicilari Goster";
            this.btnAktifKullanici.UseVisualStyleBackColor = true;
            this.btnAktifKullanici.Click += new System.EventHandler(this.btnAktifKullanici_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(449, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(922, 472);
            this.dataGridView1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(267, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 472);
            this.listBox1.TabIndex = 3;
            this.listBox1.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBox1_Format);
            // 
            // btnKullaniciAyar
            // 
            this.btnKullaniciAyar.Location = new System.Drawing.Point(13, 207);
            this.btnKullaniciAyar.Name = "btnKullaniciAyar";
            this.btnKullaniciAyar.Size = new System.Drawing.Size(206, 44);
            this.btnKullaniciAyar.TabIndex = 4;
            this.btnKullaniciAyar.Text = "KullaniciAyarlariDegistir";
            this.btnKullaniciAyar.UseVisualStyleBackColor = true;
            this.btnKullaniciAyar.Click += new System.EventHandler(this.btnKullaniciAyar_Click);
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Location = new System.Drawing.Point(12, 12);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(207, 36);
            this.btnKullanicilar.TabIndex = 5;
            this.btnKullanicilar.Text = "Bütün Kullanicilar";
            this.btnKullanicilar.UseVisualStyleBackColor = true;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // btnPasif
            // 
            this.btnPasif.Location = new System.Drawing.Point(13, 120);
            this.btnPasif.Name = "btnPasif";
            this.btnPasif.Size = new System.Drawing.Size(206, 41);
            this.btnPasif.TabIndex = 6;
            this.btnPasif.Text = "Pasif Kullanicilar";
            this.btnPasif.UseVisualStyleBackColor = true;
            this.btnPasif.Click += new System.EventHandler(this.btnPasif_Click);
            // 
            // AdminKullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 640);
            this.Controls.Add(this.btnPasif);
            this.Controls.Add(this.btnKullanicilar);
            this.Controls.Add(this.btnKullaniciAyar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAktifKullanici);
            this.Name = "AdminKullaniciForm";
            this.Text = "AdminKullanici";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAktifKullanici;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKullaniciAyar;
        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.Button btnPasif;
    }
}