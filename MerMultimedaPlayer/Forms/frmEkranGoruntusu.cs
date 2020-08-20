using System;
using System.Drawing;
using System.Windows.Forms;

namespace MerMultimedaPlayer
{
    public partial class frmEkranGoruntusu : Form
    {
        public frmEkranGoruntusu()
        {
            InitializeComponent();
        }

        private void EkranGoruntusuAl()
        {
            Bitmap bm = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(bm);
            g.CopyFromScreen(this.Left, this.Top, 0, 0, this.Size);
            pctrEkranGoruntusu.Image = bm;
        }

        private void frmEkranGoruntusu_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            System.Threading.Thread.Sleep(100);
            EkranGoruntusuAl();
            this.Opacity = 100;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();//yeni bir kaydetme diyaloğu oluşturuyoruz.
            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";//.bmp veya .jpg olarak kayıt imkanı sağlıyoruz.
            sfd.Title = "Kayıt";//dialog penceremizin başlığını belirliyoruz.
            sfd.FileName = "resim";//kaydedilen resmimizin adını 'resim' olarak belirliyoruz.
            DialogResult sonuç = sfd.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pctrEkranGoruntusu.Image.Save(sfd.FileName);//Böylelikle resmi istediğimiz yere kaydediyoruz.
            }
        }
    }
}