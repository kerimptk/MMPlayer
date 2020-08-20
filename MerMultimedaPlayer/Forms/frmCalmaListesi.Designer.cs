namespace MerMultimedaPlayer
{
    partial class frmCalmaListesi
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
            this.lstboxCalmaListeleri = new System.Windows.Forms.ListBox();
            this.lstListeDetay = new System.Windows.Forms.ListBox();
            this.btnListeyiOynat = new System.Windows.Forms.Button();
            this.btnListeyiDuzenle = new System.Windows.Forms.Button();
            this.btnListeyiSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSecilenParcayiSil = new System.Windows.Forms.Button();
            this.btnListeyeParcaEkle = new System.Windows.Forms.Button();
            this.btnListeyiYenidenAdlandir = new System.Windows.Forms.Button();
            this.txtListeAdi = new System.Windows.Forms.TextBox();
            this.brnCikis = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lstCalmaListesiID = new System.Windows.Forms.ListBox();
            this.lstDetayID = new System.Windows.Forms.ListBox();
            this.lstEklenecekler = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstboxCalmaListeleri
            // 
            this.lstboxCalmaListeleri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstboxCalmaListeleri.FormattingEnabled = true;
            this.lstboxCalmaListeleri.Location = new System.Drawing.Point(0, 0);
            this.lstboxCalmaListeleri.Name = "lstboxCalmaListeleri";
            this.lstboxCalmaListeleri.Size = new System.Drawing.Size(266, 368);
            this.lstboxCalmaListeleri.TabIndex = 1;
            this.lstboxCalmaListeleri.SelectedIndexChanged += new System.EventHandler(this.lstboxCalmaListeleri_SelectedIndexChanged);
            // 
            // lstListeDetay
            // 
            this.lstListeDetay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstListeDetay.Enabled = false;
            this.lstListeDetay.FormattingEnabled = true;
            this.lstListeDetay.Location = new System.Drawing.Point(272, 0);
            this.lstListeDetay.Name = "lstListeDetay";
            this.lstListeDetay.Size = new System.Drawing.Size(285, 472);
            this.lstListeDetay.TabIndex = 2;
            // 
            // btnListeyiOynat
            // 
            this.btnListeyiOynat.Location = new System.Drawing.Point(0, 5);
            this.btnListeyiOynat.Name = "btnListeyiOynat";
            this.btnListeyiOynat.Size = new System.Drawing.Size(130, 100);
            this.btnListeyiOynat.TabIndex = 3;
            this.btnListeyiOynat.Text = "Listeyi Oynat";
            this.btnListeyiOynat.UseVisualStyleBackColor = true;
            this.btnListeyiOynat.Click += new System.EventHandler(this.btnListeyiOynat_Click);
            // 
            // btnListeyiDuzenle
            // 
            this.btnListeyiDuzenle.Location = new System.Drawing.Point(134, 5);
            this.btnListeyiDuzenle.Name = "btnListeyiDuzenle";
            this.btnListeyiDuzenle.Size = new System.Drawing.Size(130, 100);
            this.btnListeyiDuzenle.TabIndex = 3;
            this.btnListeyiDuzenle.Text = "Lİstesi Düzenle";
            this.btnListeyiDuzenle.UseVisualStyleBackColor = true;
            this.btnListeyiDuzenle.Click += new System.EventHandler(this.btnListeyiDuzenle_Click);
            // 
            // btnListeyiSil
            // 
            this.btnListeyiSil.Enabled = false;
            this.btnListeyiSil.Location = new System.Drawing.Point(563, 207);
            this.btnListeyiSil.Name = "btnListeyiSil";
            this.btnListeyiSil.Size = new System.Drawing.Size(175, 50);
            this.btnListeyiSil.TabIndex = 3;
            this.btnListeyiSil.Text = "Listeyi Sil";
            this.btnListeyiSil.UseVisualStyleBackColor = true;
            this.btnListeyiSil.Click += new System.EventHandler(this.btnListeyiSil_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnListeyiOynat);
            this.panel1.Controls.Add(this.btnListeyiDuzenle);
            this.panel1.Location = new System.Drawing.Point(0, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 112);
            this.panel1.TabIndex = 4;
            // 
            // btnSecilenParcayiSil
            // 
            this.btnSecilenParcayiSil.Enabled = false;
            this.btnSecilenParcayiSil.Location = new System.Drawing.Point(563, 156);
            this.btnSecilenParcayiSil.Name = "btnSecilenParcayiSil";
            this.btnSecilenParcayiSil.Size = new System.Drawing.Size(175, 45);
            this.btnSecilenParcayiSil.TabIndex = 3;
            this.btnSecilenParcayiSil.Text = "Seçilen Parçayı Sil";
            this.btnSecilenParcayiSil.UseVisualStyleBackColor = true;
            this.btnSecilenParcayiSil.Click += new System.EventHandler(this.btnSecilenParcayiSil_Click);
            // 
            // btnListeyeParcaEkle
            // 
            this.btnListeyeParcaEkle.Enabled = false;
            this.btnListeyeParcaEkle.Location = new System.Drawing.Point(563, 105);
            this.btnListeyeParcaEkle.Name = "btnListeyeParcaEkle";
            this.btnListeyeParcaEkle.Size = new System.Drawing.Size(175, 45);
            this.btnListeyeParcaEkle.TabIndex = 3;
            this.btnListeyeParcaEkle.Text = "Listeye Parça Ekle";
            this.btnListeyeParcaEkle.UseVisualStyleBackColor = true;
            this.btnListeyeParcaEkle.Click += new System.EventHandler(this.btnListeyeParcaEkle_Click);
            // 
            // btnListeyiYenidenAdlandir
            // 
            this.btnListeyiYenidenAdlandir.Enabled = false;
            this.btnListeyiYenidenAdlandir.Location = new System.Drawing.Point(563, 54);
            this.btnListeyiYenidenAdlandir.Name = "btnListeyiYenidenAdlandir";
            this.btnListeyiYenidenAdlandir.Size = new System.Drawing.Size(175, 45);
            this.btnListeyiYenidenAdlandir.TabIndex = 3;
            this.btnListeyiYenidenAdlandir.Text = "Listeyi Yeniden Adlandır";
            this.btnListeyiYenidenAdlandir.UseVisualStyleBackColor = true;
            this.btnListeyiYenidenAdlandir.Click += new System.EventHandler(this.btnListeyiYenidenAdlandir_Click);
            // 
            // txtListeAdi
            // 
            this.txtListeAdi.Enabled = false;
            this.txtListeAdi.Location = new System.Drawing.Point(563, 2);
            this.txtListeAdi.Multiline = true;
            this.txtListeAdi.Name = "txtListeAdi";
            this.txtListeAdi.Size = new System.Drawing.Size(171, 46);
            this.txtListeAdi.TabIndex = 5;
            // 
            // brnCikis
            // 
            this.brnCikis.Location = new System.Drawing.Point(563, 420);
            this.brnCikis.Name = "brnCikis";
            this.brnCikis.Size = new System.Drawing.Size(175, 50);
            this.brnCikis.TabIndex = 3;
            this.brnCikis.Text = "Çıkış";
            this.brnCikis.UseVisualStyleBackColor = true;
            this.brnCikis.Click += new System.EventHandler(this.brnCikis_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(563, 363);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(175, 50);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lstCalmaListesiID
            // 
            this.lstCalmaListesiID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCalmaListesiID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstCalmaListesiID.FormattingEnabled = true;
            this.lstCalmaListesiID.Location = new System.Drawing.Point(563, 263);
            this.lstCalmaListesiID.Name = "lstCalmaListesiID";
            this.lstCalmaListesiID.Size = new System.Drawing.Size(85, 17);
            this.lstCalmaListesiID.TabIndex = 1;
            this.lstCalmaListesiID.Visible = false;
            this.lstCalmaListesiID.SelectedIndexChanged += new System.EventHandler(this.lstboxCalmaListeleri_SelectedIndexChanged);
            // 
            // lstDetayID
            // 
            this.lstDetayID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstDetayID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstDetayID.FormattingEnabled = true;
            this.lstDetayID.Location = new System.Drawing.Point(563, 294);
            this.lstDetayID.Name = "lstDetayID";
            this.lstDetayID.Size = new System.Drawing.Size(85, 17);
            this.lstDetayID.TabIndex = 6;
            this.lstDetayID.Visible = false;
            // 
            // lstEklenecekler
            // 
            this.lstEklenecekler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstEklenecekler.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstEklenecekler.FormattingEnabled = true;
            this.lstEklenecekler.Location = new System.Drawing.Point(563, 324);
            this.lstEklenecekler.Name = "lstEklenecekler";
            this.lstEklenecekler.Size = new System.Drawing.Size(85, 17);
            this.lstEklenecekler.TabIndex = 6;
            this.lstEklenecekler.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // frmCalmaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 474);
            this.Controls.Add(this.lstEklenecekler);
            this.Controls.Add(this.lstDetayID);
            this.Controls.Add(this.txtListeAdi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.brnCikis);
            this.Controls.Add(this.btnListeyiSil);
            this.Controls.Add(this.lstListeDetay);
            this.Controls.Add(this.btnListeyiYenidenAdlandir);
            this.Controls.Add(this.btnListeyeParcaEkle);
            this.Controls.Add(this.btnSecilenParcayiSil);
            this.Controls.Add(this.lstCalmaListesiID);
            this.Controls.Add(this.lstboxCalmaListeleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCalmaListesi";
            this.Text = "Çalma Listeleri";
            this.Load += new System.EventHandler(this.frmCalmaListesi_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxCalmaListeleri;
        private System.Windows.Forms.ListBox lstListeDetay;
        private System.Windows.Forms.Button btnListeyiOynat;
        private System.Windows.Forms.Button btnListeyiDuzenle;
        private System.Windows.Forms.Button btnListeyiSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSecilenParcayiSil;
        private System.Windows.Forms.Button btnListeyeParcaEkle;
        private System.Windows.Forms.Button btnListeyiYenidenAdlandir;
        private System.Windows.Forms.TextBox txtListeAdi;
        private System.Windows.Forms.Button brnCikis;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ListBox lstCalmaListesiID;
        private System.Windows.Forms.ListBox lstDetayID;
        private System.Windows.Forms.ListBox lstEklenecekler;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}