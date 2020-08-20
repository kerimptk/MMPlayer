using MerMultimedaPlayer.Bll;
using MerMultimedaPlayer.Entity;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MerMultimedaPlayer
{
    public partial class MainMerPlayer : Form
    {
        public List<object> clist = new List<object>();
        private List<calma_listesi_kart> calma_listesi;
        tblCalmaListeKartManager _tblCalmaListeKartManager;
        private List<calma_liste_detay> calma_Listesi_Kart_Detay;
        tblCalmaListeKartDetayManager _tblCalmaListeKartDetayManager;
        int index = 1;

        public MainMerPlayer()
        {
            InitializeComponent();

            _tblCalmaListeKartManager = new tblCalmaListeKartManager();
            _tblCalmaListeKartDetayManager = new tblCalmaListeKartDetayManager();
        }

        private void AktifPasif(bool item)
        {
            oynatToolStripMenuItem.Enabled = item;
            durdurToolStripMenuItem.Enabled = !item;
            duraklatToolStripMenuItem.Enabled = !item;
            btnOynat.Enabled = item;
            btnPause.Enabled = !item;
            btnKarisikCal.Enabled = !item;
        }

        private void OncekiniCal()
        {
            if (lstCalinan.Items.Count != 0 && lstCalinan.SelectedIndex != null)
            {
                if (lstCalinan.SelectedIndex <= 0)
                {
                    lstCalinan.SelectedIndex = lstCalinan.Items.Count - 1;
                }
                else
                {
                    lstCalinan.SelectedIndex -= 1;
                }
            }
        }

        private void SonrakiniCal()
        {
            if (lstCalinan.Items.Count != 0 && lstCalinan.SelectedIndex != null)
            {
                if (lstCalinan.Items.Count == lstCalinan.SelectedIndex + 1)
                {
                    lstCalinan.SelectedIndex = 0;
                }
                else
                {
                    lstCalinan.SelectedIndex += 1;
                }
            }
        }

        private void IndexAl()
        {
            calma_listesi = _tblCalmaListeKartManager.GetList().ToList();
            foreach (var item in calma_listesi)
            {
                index = item.id;
                label1.Text = index.ToString();
            }
        }

        private void Oynat()
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            AktifPasif(false);
        }

        private void Duraklat()
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            AktifPasif(true);
        }

        private void Durdur()
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            AktifPasif(true);
        }

        private void ListeyeEkle()
        {
            calma_listesi_kart clad = new calma_listesi_kart();
            calma_liste_detay clkd = new calma_liste_detay();

            try
            {
                foreach (var item in listBox2.Items)
                {
                    clkd.calma_listesi_id = index;
                    clkd.parca_url = item.ToString();
                    clkd.sil_id = 1;
                    clkd.olusturma_tarihi = DateTime.Now;
                    clkd.guncelleme_tarihi = DateTime.Now;
                    _tblCalmaListeKartDetayManager.Add(clkd);
                }
                MessageBox.Show("Çalma Listesi Başarı ile Oluşturuldu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Başarsız Bekelenmeyen bir hata" +
                    "oluştu. Lütfen yöneticinize başvurunuz.", "Hata!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                AktifPasif(false);
            }
        }

        private void CalmaListesiOlustur()
        {
            calma_listesi_kart clad = new calma_listesi_kart();
            clad.sil_id = 1;
            clad.liste_adi = txtCalmaListesiAdi.Text;
            clad.olusturma_tarihi = DateTime.Now;
            clad.guncelleme_tarihi = DateTime.Now;

            try
            {
                _tblCalmaListeKartManager.Add(clad);
                IndexAl();
                ListeyeEkle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Başarsız Bekelenmeyen bir hata" +
                    "oluştu. Lütfen yöneticinize başvurunuz.", "Hata!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                AktifPasif(false);
            }
        }

        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Media Files(*.Mp3;*.Wav;*.Wma)|*.Mp3;*.Wav;*.Wma|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
                {
                    lstCalinan.Items.Add((i + 1 + "  ") + openFileDialog1.SafeFileNames[i].ToString());
                    listBox2.Items.Add(openFileDialog1.FileNames[i].ToString());
                }
            }
        }

        private void dosyaKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "";
            lstCalinan.Items.Clear();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oynatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oynat();
        }

        private void durdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Duraklat();
        }

        private void duraklatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Durdur();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Kerim Potuk tarafından hazırlanmıştır.");
        }

        private void ekranResmiAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEkranGoruntusu ss = new frmEkranGoruntusu();
            ss.ShowDialog();
        }

        private void tamEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.URL != null || axWindowsMediaPlayer1.URL != "")
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
        }

        private void oynatmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalmaListesi CalmaListesi = new frmCalmaListesi();
            this.Hide();
            CalmaListesi.ShowDialog();
            this.Show();
        }

        private void sesiAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 10;
        }

        private void sesiAzaltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 10;
        }

        private void sesiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MediaKonum_ValueChanged(sender, e);
        }
        private void MediaKonum_ValueChanged(object sender, EventArgs e)
        {
            MediaKonum.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
        }
        public void lstcalinan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstCalinan.SelectedIndex >= 0)
            {
                listBox2.SelectedIndex = lstCalinan.SelectedIndex;
                axWindowsMediaPlayer1.URL = listBox2.SelectedItem.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                AktifPasif(false);
                timer1.Start();
            }
        }

        private void btnOynat_Click(object sender, EventArgs e)
        {
            Oynat();
        }

        private void btnCalmaListesiOlustur_Click(object sender, EventArgs e)
        {
            if (lstCalinan.Items.Count != 0)
            {
                txtCalmaListesiAdi.Enabled = true;
                btnIptal.Enabled = true;
                btnCalmaListesiOlustur.Text = "Kaydet";
                if (btnCalmaListesiOlustur.Text.Equals("Kaydet") && txtCalmaListesiAdi.Text != "")
                {
                    CalmaListesiOlustur();
                }
            }
            else
            {
                MessageBox.Show("Listeye parça eklemeden çalma listesi oluşturamazsınız....");
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtCalmaListesiAdi.Enabled = false;
            btnIptal.Enabled = false;
            btnCalmaListesiOlustur.Text = "Çalma Listesi Oluştur";
        }

        private void MainMerPlayer_Load(object sender, EventArgs e)
        {
            trackBar1.Value = 50;
            IndexAl();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Duraklat();
        }

        private void SesBari_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            SonrakiniCal();
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            OncekiniCal();
        }

        private void btnKarisikCal_Click(object sender, EventArgs e)
        {
            Random randomCal = new Random();
            int randomCalinacak = randomCal.Next(0, lstCalinan.Items.Count);
            if (lstCalinan.Items.Count != 0)
            {
                lstCalinan.SelectedIndex = randomCalinacak;
            }
        }

        private void MainMerPlayer_VisibleChanged(object sender, EventArgs e)
        {
            if (frmCalmaListesi.IsPostBack)
            {
                clist = frmCalmaListesi.tst;

                if (clist.Count > 0)
                {
                    foreach (var item in clist)
                    {
                        listBox2.Items.Add(item);
                        lstCalinan.Items.Add(item);
                    }
                }
                trackBar1.Value = 50;
                IndexAl();

                frmCalmaListesi.IsPostBack = false;
            }
        }
    }
}
