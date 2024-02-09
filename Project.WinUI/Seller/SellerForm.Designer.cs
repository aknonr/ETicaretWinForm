namespace Project.WinUI.Seller
{
    partial class SellerForm
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
            this.btnCategoryEkle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCategoryEkle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSeller = new System.Windows.Forms.ListBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnEklemeleriGor = new System.Windows.Forms.Button();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.txtUrunName = new System.Windows.Forms.TextBox();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCategoryEkle
            // 
            this.btnCategoryEkle.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnCategoryEkle.Location = new System.Drawing.Point(209, 124);
            this.btnCategoryEkle.Name = "btnCategoryEkle";
            this.btnCategoryEkle.Size = new System.Drawing.Size(97, 23);
            this.btnCategoryEkle.TabIndex = 0;
            this.btnCategoryEkle.Text = "Category Ekle";
            this.btnCategoryEkle.UseVisualStyleBackColor = false;
            this.btnCategoryEkle.Click += new System.EventHandler(this.btnCategoryEkle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(738, 358);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCategoryEkle
            // 
            this.txtCategoryEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCategoryEkle.Location = new System.Drawing.Point(209, 80);
            this.txtCategoryEkle.Name = "txtCategoryEkle";
            this.txtCategoryEkle.Size = new System.Drawing.Size(309, 20);
            this.txtCategoryEkle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category Name";
            // 
            // lstSeller
            // 
            this.lstSeller.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lstSeller.FormattingEnabled = true;
            this.lstSeller.Location = new System.Drawing.Point(567, 46);
            this.lstSeller.Name = "lstSeller";
            this.lstSeller.Size = new System.Drawing.Size(510, 290);
            this.lstSeller.TabIndex = 5;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnUrunEkle.Location = new System.Drawing.Point(209, 315);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunEkle.TabIndex = 6;
            this.btnUrunEkle.Text = "Urun Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnEklemeleriGor
            // 
            this.btnEklemeleriGor.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnEklemeleriGor.Location = new System.Drawing.Point(738, 410);
            this.btnEklemeleriGor.Name = "btnEklemeleriGor";
            this.btnEklemeleriGor.Size = new System.Drawing.Size(150, 31);
            this.btnEklemeleriGor.TabIndex = 8;
            this.btnEklemeleriGor.Text = "Eklemeleri Gör";
            this.btnEklemeleriGor.UseVisualStyleBackColor = false;
            this.btnEklemeleriGor.Click += new System.EventHandler(this.btnEklemeleriGor_Click);
            // 
            // txtUrunID
            // 
            this.txtUrunID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUrunID.Location = new System.Drawing.Point(209, 226);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(309, 20);
            this.txtUrunID.TabIndex = 11;
            // 
            // txtUrunName
            // 
            this.txtUrunName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUrunName.Location = new System.Drawing.Point(209, 252);
            this.txtUrunName.Name = "txtUrunName";
            this.txtUrunName.Size = new System.Drawing.Size(309, 20);
            this.txtUrunName.TabIndex = 12;
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUrunFiyat.Location = new System.Drawing.Point(209, 278);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(309, 20);
            this.txtUrunFiyat.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Urun Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Urun Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Urun Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(209, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 23);
            this.label4.TabIndex = 19;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1169, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUrunFiyat);
            this.Controls.Add(this.txtUrunName);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.btnEklemeleriGor);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.lstSeller);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoryEkle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCategoryEkle);
            this.Name = "SellerForm";
            this.Text = "SellerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategoryEkle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtCategoryEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSeller;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnEklemeleriGor;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.TextBox txtUrunName;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}