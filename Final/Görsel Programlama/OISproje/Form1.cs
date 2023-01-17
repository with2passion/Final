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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapılıyor!!!", "Mesaj Çıktısı");
            this.Close();
            //close ile sistem tamamen kapanırken hide ile winform kapansa bile çalışır halde oluyor.
            //this.Hide();
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersGiris g = new DersGiris();
            g.MdiParent = this.ParentForm;
            g.Show();
            toolStripStatusLabel1.Text = "Ders Giriş Formuna Tıklandı";
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersListele l = new DersListele();
            l.MdiParent = this.ParentForm;
            l.Show();
            toolStripStatusLabel1.Text = "Ders Listele Formuna Tıklandı";
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Personelistele s = new Personelistele();
            s.MdiParent = this.ParentForm;
            s.Show();
            toolStripStatusLabel1.Text = "Personel Listele Formuna Tıklandı";
        }

        private void girişToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Personelgiris p = new Personelgiris();
            p.MdiParent = this.ParentForm;
            p.Show();
            toolStripStatusLabel1.Text = "Personel Giriş Formuna Tıklandı";
        }

        private void listeleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OgrenciL o = new OgrenciL();
            o.MdiParent = this.ParentForm;
            o.Show();
            toolStripStatusLabel1.Text = "Öğrenci Listele Formuna Tıklandı";
        }

        private void girişToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OgrenciG r = new OgrenciG();
            r.MdiParent = this.ParentForm;
            r.Show();
            toolStripStatusLabel1.Text = "Öğrenci Giriş Formuna Tıklandı";
        }

        private void derslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciD o = new OgrenciD();
            o.MdiParent = this.ParentForm;
            o.Show();
            toolStripStatusLabel1.Text = "Öğrenci Ders Formuna Tıklandı";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DersGiris s = new DersGiris();
            s.MdiParent = this.ParentForm;
            s.Show();
            DersListele q = new DersListele();
            q.MdiParent = this.ParentForm;
            q.Show();
            // Personelgiris o = new Personelgiris();
            // o.MdiParent = this.ParentForm;
            // o.Show();
            // Personeliste x = new Personeliste();
            // x.MdiParent = this.ParentForm;
            // x.Show();
            //OgrenciG k = new OgrenciG();
            //k.MdiParent = this.ParentForm;
            //k.Show();
            //OgrenciL ç = new OgrenciL();
            //ç.MdiParent = this.ParentForm;
            //ç.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
