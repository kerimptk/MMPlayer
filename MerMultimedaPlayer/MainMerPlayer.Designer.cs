namespace MerMultimedaPlayer
{
    partial class MainMerPlayer
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMerPlayer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oynatmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oynatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durdurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duraklatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekranGÖrüntüsüAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekranResmiAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamEkranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesiAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesiAzaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekranvideosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstCalinan = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtCalmaListesiAdi = new System.Windows.Forms.TextBox();
            this.btnKarisikCal = new System.Windows.Forms.Button();
            this.btnCalmaListesiOlustur = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnOynat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MediaKonum = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaKonum)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.oynatmaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.ekranGÖrüntüsüAlToolStripMenuItem,
            this.sesToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.ekranvideosuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 6, 4, 6);
            this.menuStrip1.Size = new System.Drawing.Size(825, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaAçToolStripMenuItem,
            this.dosyaKapatToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // dosyaAçToolStripMenuItem
            // 
            this.dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            this.dosyaAçToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.dosyaAçToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.dosyaAçToolStripMenuItem.Text = "Dosya Aç";
            this.dosyaAçToolStripMenuItem.Click += new System.EventHandler(this.dosyaAçToolStripMenuItem_Click);
            // 
            // dosyaKapatToolStripMenuItem
            // 
            this.dosyaKapatToolStripMenuItem.Name = "dosyaKapatToolStripMenuItem";
            this.dosyaKapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.dosyaKapatToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.dosyaKapatToolStripMenuItem.Text = "Dosya Kapat";
            this.dosyaKapatToolStripMenuItem.Click += new System.EventHandler(this.dosyaKapatToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // oynatmaToolStripMenuItem
            // 
            this.oynatmaToolStripMenuItem.Name = "oynatmaToolStripMenuItem";
            this.oynatmaToolStripMenuItem.Size = new System.Drawing.Size(109, 23);
            this.oynatmaToolStripMenuItem.Text = "Çalma Listeleri";
            this.oynatmaToolStripMenuItem.Click += new System.EventHandler(this.oynatmaToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oynatToolStripMenuItem,
            this.durdurToolStripMenuItem,
            this.duraklatToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.düzenToolStripMenuItem.Text = "Oynatıcı";
            // 
            // oynatToolStripMenuItem
            // 
            this.oynatToolStripMenuItem.Enabled = false;
            this.oynatToolStripMenuItem.Name = "oynatToolStripMenuItem";
            this.oynatToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.oynatToolStripMenuItem.Text = "Oynat";
            this.oynatToolStripMenuItem.Click += new System.EventHandler(this.oynatToolStripMenuItem_Click);
            // 
            // durdurToolStripMenuItem
            // 
            this.durdurToolStripMenuItem.Enabled = false;
            this.durdurToolStripMenuItem.Name = "durdurToolStripMenuItem";
            this.durdurToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.durdurToolStripMenuItem.Text = "Duraklat";
            this.durdurToolStripMenuItem.Click += new System.EventHandler(this.durdurToolStripMenuItem_Click);
            // 
            // duraklatToolStripMenuItem
            // 
            this.duraklatToolStripMenuItem.Enabled = false;
            this.duraklatToolStripMenuItem.Name = "duraklatToolStripMenuItem";
            this.duraklatToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.duraklatToolStripMenuItem.Text = "Durdur";
            this.duraklatToolStripMenuItem.Click += new System.EventHandler(this.duraklatToolStripMenuItem_Click);
            // 
            // ekranGÖrüntüsüAlToolStripMenuItem
            // 
            this.ekranGÖrüntüsüAlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekranResmiAlToolStripMenuItem,
            this.tamEkranToolStripMenuItem});
            this.ekranGÖrüntüsüAlToolStripMenuItem.Name = "ekranGÖrüntüsüAlToolStripMenuItem";
            this.ekranGÖrüntüsüAlToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.ekranGÖrüntüsüAlToolStripMenuItem.Text = "Görüntü";
            // 
            // ekranResmiAlToolStripMenuItem
            // 
            this.ekranResmiAlToolStripMenuItem.Name = "ekranResmiAlToolStripMenuItem";
            this.ekranResmiAlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.ekranResmiAlToolStripMenuItem.Size = new System.Drawing.Size(280, 24);
            this.ekranResmiAlToolStripMenuItem.Text = "Ekran Resmi Al";
            this.ekranResmiAlToolStripMenuItem.Click += new System.EventHandler(this.ekranResmiAlToolStripMenuItem_Click);
            // 
            // tamEkranToolStripMenuItem
            // 
            this.tamEkranToolStripMenuItem.Name = "tamEkranToolStripMenuItem";
            this.tamEkranToolStripMenuItem.Size = new System.Drawing.Size(280, 24);
            this.tamEkranToolStripMenuItem.Text = "Tam Ekran";
            this.tamEkranToolStripMenuItem.Click += new System.EventHandler(this.tamEkranToolStripMenuItem_Click);
            // 
            // sesToolStripMenuItem
            // 
            this.sesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesiAçToolStripMenuItem,
            this.sesiAzaltToolStripMenuItem,
            this.sesiKapatToolStripMenuItem});
            this.sesToolStripMenuItem.Name = "sesToolStripMenuItem";
            this.sesToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.sesToolStripMenuItem.Text = "Ses";
            // 
            // sesiAçToolStripMenuItem
            // 
            this.sesiAçToolStripMenuItem.Name = "sesiAçToolStripMenuItem";
            this.sesiAçToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.sesiAçToolStripMenuItem.Text = "Sesi Aç";
            this.sesiAçToolStripMenuItem.Click += new System.EventHandler(this.sesiAçToolStripMenuItem_Click);
            // 
            // sesiAzaltToolStripMenuItem
            // 
            this.sesiAzaltToolStripMenuItem.Name = "sesiAzaltToolStripMenuItem";
            this.sesiAzaltToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.sesiAzaltToolStripMenuItem.Text = "Sesi Kıs";
            this.sesiAzaltToolStripMenuItem.Click += new System.EventHandler(this.sesiAzaltToolStripMenuItem_Click);
            // 
            // sesiKapatToolStripMenuItem
            // 
            this.sesiKapatToolStripMenuItem.Name = "sesiKapatToolStripMenuItem";
            this.sesiKapatToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.sesiKapatToolStripMenuItem.Text = "Sesi Kapat";
            this.sesiKapatToolStripMenuItem.Click += new System.EventHandler(this.sesiKapatToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // ekranvideosuToolStripMenuItem
            // 
            this.ekranvideosuToolStripMenuItem.Name = "ekranvideosuToolStripMenuItem";
            this.ekranvideosuToolStripMenuItem.Size = new System.Drawing.Size(12, 23);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // lstCalinan
            // 
            this.lstCalinan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCalinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lstCalinan.FormattingEnabled = true;
            this.lstCalinan.ItemHeight = 15;
            this.lstCalinan.Location = new System.Drawing.Point(0, 35);
            this.lstCalinan.Name = "lstCalinan";
            this.lstCalinan.Size = new System.Drawing.Size(185, 394);
            this.lstCalinan.TabIndex = 2;
            this.lstCalinan.SelectedValueChanged += new System.EventHandler(this.lstcalinan_SelectedValueChanged);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(648, 34);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(177, 342);
            this.listBox2.TabIndex = 3;
            this.listBox2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.txtCalmaListesiAdi);
            this.panel1.Controls.Add(this.btnKarisikCal);
            this.panel1.Controls.Add(this.btnCalmaListesiOlustur);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.btnSonraki);
            this.panel1.Controls.Add(this.btnOnceki);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnOynat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 74);
            this.panel1.TabIndex = 4;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.DarkGray;
            this.trackBar1.Location = new System.Drawing.Point(604, 15);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(212, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.ValueChanged += new System.EventHandler(this.SesBari_ValueChanged);
            // 
            // txtCalmaListesiAdi
            // 
            this.txtCalmaListesiAdi.Enabled = false;
            this.txtCalmaListesiAdi.Location = new System.Drawing.Point(3, 8);
            this.txtCalmaListesiAdi.Name = "txtCalmaListesiAdi";
            this.txtCalmaListesiAdi.Size = new System.Drawing.Size(176, 20);
            this.txtCalmaListesiAdi.TabIndex = 6;
            // 
            // btnKarisikCal
            // 
            this.btnKarisikCal.Image = global::MerMultimedaPlayer.Properties.Resources.karisikcal;
            this.btnKarisikCal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKarisikCal.Location = new System.Drawing.Point(458, 8);
            this.btnKarisikCal.Name = "btnKarisikCal";
            this.btnKarisikCal.Size = new System.Drawing.Size(58, 58);
            this.btnKarisikCal.TabIndex = 0;
            this.btnKarisikCal.UseVisualStyleBackColor = true;
            this.btnKarisikCal.Click += new System.EventHandler(this.btnKarisikCal_Click);
            // 
            // btnCalmaListesiOlustur
            // 
            this.btnCalmaListesiOlustur.Location = new System.Drawing.Point(3, 29);
            this.btnCalmaListesiOlustur.Name = "btnCalmaListesiOlustur";
            this.btnCalmaListesiOlustur.Size = new System.Drawing.Size(106, 36);
            this.btnCalmaListesiOlustur.TabIndex = 5;
            this.btnCalmaListesiOlustur.Text = "Çalma Listesi Oluştur";
            this.btnCalmaListesiOlustur.UseVisualStyleBackColor = true;
            this.btnCalmaListesiOlustur.Click += new System.EventHandler(this.btnCalmaListesiOlustur_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Enabled = false;
            this.btnIptal.Location = new System.Drawing.Point(115, 29);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(64, 37);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSonraki
            // 
            this.btnSonraki.Image = global::MerMultimedaPlayer.Properties.Resources.sonraki;
            this.btnSonraki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSonraki.Location = new System.Drawing.Point(391, 8);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(58, 58);
            this.btnSonraki.TabIndex = 0;
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btnOnceki
            // 
            this.btnOnceki.Image = global::MerMultimedaPlayer.Properties.Resources.onceki;
            this.btnOnceki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnceki.Location = new System.Drawing.Point(324, 8);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(58, 58);
            this.btnOnceki.TabIndex = 0;
            this.btnOnceki.UseVisualStyleBackColor = true;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Image = global::MerMultimedaPlayer.Properties.Resources.pause;
            this.btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPause.Location = new System.Drawing.Point(257, 8);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(58, 58);
            this.btnPause.TabIndex = 0;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnOynat
            // 
            this.btnOynat.Enabled = false;
            this.btnOynat.Image = global::MerMultimedaPlayer.Properties.Resources.play;
            this.btnOynat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOynat.Location = new System.Drawing.Point(191, 8);
            this.btnOynat.Name = "btnOynat";
            this.btnOynat.Size = new System.Drawing.Size(58, 58);
            this.btnOynat.TabIndex = 0;
            this.btnOynat.UseVisualStyleBackColor = true;
            this.btnOynat.Click += new System.EventHandler(this.btnOynat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // MediaKonum
            // 
            this.MediaKonum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MediaKonum.Cursor = System.Windows.Forms.Cursors.Default;
            this.MediaKonum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MediaKonum.Location = new System.Drawing.Point(0, 345);
            this.MediaKonum.Maximum = 200;
            this.MediaKonum.Name = "MediaKonum";
            this.MediaKonum.Size = new System.Drawing.Size(634, 45);
            this.MediaKonum.TabIndex = 9;
            this.MediaKonum.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.MediaKonum.ValueChanged += new System.EventHandler(this.MediaKonum_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel2.Controls.Add(this.MediaKonum);
            this.panel2.Location = new System.Drawing.Point(191, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 390);
            this.panel2.TabIndex = 10;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(634, 345);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMerPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(825, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lstCalinan);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(841, 537);
            this.Name = "MainMerPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mer Multimedia Player";
            this.Load += new System.EventHandler(this.MainMerPlayer_Load);
            this.VisibleChanged += new System.EventHandler(this.MainMerPlayer_VisibleChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaKonum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem oynatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durdurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duraklatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekranGÖrüntüsüAlToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolStripMenuItem ekranResmiAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekranvideosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamEkranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oynatmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesiAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesiAzaltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesiKapatToolStripMenuItem;
        private System.Windows.Forms.ListBox lstCalinan;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnOynat;
        private System.Windows.Forms.Button btnCalmaListesiOlustur;
        private System.Windows.Forms.TextBox txtCalmaListesiAdi;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOnceki;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnKarisikCal;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.TrackBar MediaKonum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
    }
}

