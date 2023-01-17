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
    public partial class Personelistele : Form
    {
        public Personelistele()
        {
            InitializeComponent();
        }

        WFormDBEntities db = new WFormDBEntities();
        private void Personelistele_Load(object sender, EventArgs e)
        {
            var ctx = new WFormDBEntities();
            var okulYonetims = ctx.OkulYonetimTab.ToList();
            var bindingList = new BindingList<OkulYonetimTab>(okulYonetims);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) >= 11)
                {
                    renk.BackColor = Color.Pink;
                    renk.ForeColor = Color.DeepPink;
                }

                else
                {
                    renk.BackColor = Color.Purple;
                    renk.ForeColor = Color.Pink;
                }

                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçilen Kayıt Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                int ogrencidersID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Sil")
            {
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    bindingSource1.RemoveCurrent();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçilen Kayıt Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[7].RowIndex;
                int ogrencidersID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);


                var ogrencidersbul = db.OgrenciDersTab.Find(ogrencidersID);
                db.OgrenciDersTab.Remove(ogrencidersbul);
                db.SaveChanges();
                MessageBox.Show("Ders Ve Öğrenci İlişkisi Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //listele();
            }
        }
    }
}
