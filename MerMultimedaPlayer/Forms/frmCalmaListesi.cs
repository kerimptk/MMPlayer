using MerMultimedaPlayer.Bll;
using MerMultimedaPlayer.Entity;
using StreamCoders.Rtsp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace MerMultimedaPlayer
{
    public partial class frmCalmaListesi : Form
    {
        public static List<object> tst = new List<object>();
        public static bool IsPostBack = false;

        private List<calma_listesi_kart> calma_listesi;
        tblCalmaListeKartManager _tblCalmaListeKartManager;
        private List<calma_liste_detay> calma_Listesi_Kart_Detay;
        tblCalmaListeKartDetayManager _tblCalmaListeKartDetayManager;
        public frmCalmaListesi()
        {
            InitializeComponent();
            _tblCalmaListeKartManager = new tblCalmaListeKartManager();
            _tblCalmaListeKartDetayManager = new tblCalmaListeKartDetayManager();
        }

        private void Guncelle()
        {
            try
            {
                calma_listesi_kart clk = new calma_listesi_kart();
                clk.id = Int32.Parse(lstCalmaListesiID.SelectedItem.ToString());
                clk.liste_adi = txtListeAdi.Text;
                clk.sil_id = 1;
                clk.guncelleme_tarihi = DateTime.Now;

                _tblCalmaListeKartManager.Update(clk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir haya oluştu..: " + ex.ToString());
            }
            finally
            {
                btnListeyiYenidenAdlandir.Text = "Listeyi Yeniden Adlandır";
                DuzenlemeAktif(false);
                ListeYukle();
            }
        }

        private void DuzenlemeAktif(bool item)
        {
            lstListeDetay.Enabled = item;
            btnListeyiYenidenAdlandir.Enabled = item;
            btnListeyiSil.Enabled = item;
            btnListeyeParcaEkle.Enabled = item;
            btnSecilenParcayiSil.Enabled = item;
            btnListeyiYenidenAdlandir.Text = "Listeyi Yeniden Adlandır";
            btnListeyiDuzenle.Enabled = !item;
        }

        private void ListeYukle()
        {
            lstboxCalmaListeleri.Items.Clear();
            calma_listesi = _tblCalmaListeKartManager.GetList().ToList();
            foreach (var item in calma_listesi)
            {
                lstboxCalmaListeleri.Items.Add(item.liste_adi);
                lstCalmaListesiID.Items.Add(item.id);
            }
        }

        private void ParcalariYukle()
        {
            foreach (var item in calma_Listesi_Kart_Detay)
            {
                if (item.calma_listesi_id.ToString() == lstCalmaListesiID.SelectedItem.ToString())
                {
                    lstListeDetay.Items.Add(item.parca_url);
                    lstDetayID.Items.Add(item.id);
                }
            }
        }

        private void frmCalmaListesi_Load(object sender, System.EventArgs e)
        {
            ListeYukle();
        }

        private void ListeSil()
        {
            DialogResult result;
            string silinecek = lstboxCalmaListeleri.SelectedIndex.ToString();
            result = MessageBox.Show(lstboxCalmaListeleri.SelectedItem.ToString() +
                " isimli listeyi silmek istediğinizden emin misiniz?",
                MessageBoxIcon.Question.ToString(), MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                foreach (var item in calma_Listesi_Kart_Detay)
                {
                    if (item.calma_listesi_id.ToString() == lstCalmaListesiID.SelectedItem.ToString())
                    {
                        _tblCalmaListeKartDetayManager.Delete(item);
                    }
                }

                lstListeDetay.Items.Clear();
                lstCalmaListesiID.Items.Clear();
                txtListeAdi.Text = "";

                calma_listesi_kart clkd = calma_listesi[int.Parse(silinecek)];
                _tblCalmaListeKartManager.Delete(clkd);
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi");
            }
        }

        private void lstboxCalmaListeleri_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            calma_Listesi_Kart_Detay = _tblCalmaListeKartDetayManager.GetList().ToList();
            lstCalmaListesiID.SelectedIndex = lstboxCalmaListeleri.SelectedIndex;
            if (lstboxCalmaListeleri.SelectedIndex >= 0)
            {
                txtListeAdi.Text = lstboxCalmaListeleri.SelectedItem.ToString();
                lstListeDetay.Items.Clear();
                ParcalariYukle();
            }
        }

        private void btnListeyiYenidenAdlandir_Click(object sender, System.EventArgs e)
        {
            txtListeAdi.Enabled = true;
            if (btnListeyiYenidenAdlandir.Text == "Güncelle")
            {
                Guncelle();
            }
            else
            {
                btnListeyiYenidenAdlandir.Text = "Güncelle";
            }
        }

        private void brnCikis_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        private void btnListeyiDuzenle_Click(object sender, System.EventArgs e)
        {
            if (lstboxCalmaListeleri.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz listeyi seçiniz...");
            }
            else
            {
                DuzenlemeAktif(true);
            }
        }

        private void btnListeyiSil_Click(object sender, System.EventArgs e)
        {
            ListeSil();
            lstboxCalmaListeleri.Items.Clear();
            ListeYukle();
        }

        private void btnIptal_Click(object sender, System.EventArgs e)
        {
            DuzenlemeAktif(false);
        }
        private void btnSecilenParcayiSil_Click(object sender, System.EventArgs e)
        {
            lstDetayID.SelectedIndex = lstListeDetay.SelectedIndex;
            if (lstListeDetay.Items.Count != 1 && lstListeDetay.SelectedIndex == -1)
            {
                MessageBox.Show("Silinecek parçayı seçmediniz...");
            }
            else
            {
                DialogResult result;
                string silinecek = lstListeDetay.SelectedIndex.ToString();
                result = MessageBox.Show("Seçili isimli parçayı silmek istediğinizden emin misiniz?",
                    MessageBoxIcon.Question.ToString(), MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (lstListeDetay.Items.Count == 1)
                    {
                        ListeSil();
                    }
                    else
                    {
                        calma_liste_detay clkd = calma_Listesi_Kart_Detay[int.Parse(silinecek)];
                        _tblCalmaListeKartDetayManager.Delete(clkd);
                        lstListeDetay.Items.Clear();
                        ParcalariYukle();
                    }
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi");
                }
            }
        }

        private void btnListeyeParcaEkle_Click(object sender, EventArgs e)
        {
            calma_listesi_kart clad = new calma_listesi_kart();
            calma_liste_detay clkd = new calma_liste_detay();

            openFileDialog1.Filter = "Media Files(*.Mp3;*.Wav;*.Wma)|*.Mp3;*.Wav;*.Wma|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
                {
                    lstEklenecekler.Items.Add(openFileDialog1.FileNames[i].ToString());
                }
            }
            int DosyaSayisi = lstEklenecekler.Items.Count;
            try
            {
                foreach (var item in lstEklenecekler.Items)
                {
                    clkd.calma_listesi_id = Int32.Parse(lstCalmaListesiID.SelectedItem.ToString());
                    clkd.parca_url = item.ToString();
                    clkd.sil_id = 1;
                    clkd.olusturma_tarihi = DateTime.Now;
                    clkd.guncelleme_tarihi = DateTime.Now;
                    _tblCalmaListeKartDetayManager.Add(clkd);
                }
                MessageBox.Show(DosyaSayisi + "  adet medya dosyası listeye eklendi..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Başarsız Bekelenmeyen bir hata" +
                    "oluştu. Lütfen yöneticinize başvurunuz.", "Hata!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ParcalariYukle();
                lstEklenecekler.Items.Clear();
                DuzenlemeAktif(false);
            }
        }

        private void btnListeyiOynat_Click(object sender, EventArgs e)
        {
            List<object> olist = new List<object>();
            foreach (var item in lstListeDetay.Items)
            {
                olist.Add(item);
            }

            frmCalmaListesi.tst = olist;
            frmCalmaListesi.IsPostBack = true;

            this.Close();
        }
    }
}