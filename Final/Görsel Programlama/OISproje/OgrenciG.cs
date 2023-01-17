using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OISproje
{
    public partial class OgrenciG : Form
    {
        public OgrenciG()
        {
            InitializeComponent();
        }

        WFormDBEntities db = new WFormDBEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Ad Soyad Giriniz");
                return;
            }
            if (txtkayit.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Kayıt Tarihini Giriniz");
                return;
            }
            if (txtno.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Öğrenci Numarasını Giriniz");
                return;
            }
            if (txtdt.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Doğum Tarihini Giriniz");
                return;
            }
            if (txtbolüm.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Bölüm Giriniz");
                return;
            }
            try
            {
                var ctx = new WFormDBEntities();
                var ogrenciTablo = new OgrenciTab()
                {
                    AdSoyad = txtadsoyad.Text,
                    KayitTarih = txtkayit.Text,
                    OgrenciNo = Convert.ToInt32(txtno.Text),
                    DTarih = txtdt.Text,
                    Bolum = txtbolüm.Text,
                };
                ctx.OgrenciTab.Add(ogrenciTablo);
                ctx.SaveChanges();
                MessageBox.Show("Öğrenci başarıyla kaydedilmiştir :) ");
                txtadsoyad.Text = string.Empty;
                txtkayit.Text = string.Empty;
                txtno.Text = string.Empty;
                txtdt.Text = string.Empty;
                txtbolüm.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydedilirken bir sorun oluştu !! => " + ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapılıyor!!!", "Mesaj Çıktısı");
            this.Hide();
        }
    }
}
