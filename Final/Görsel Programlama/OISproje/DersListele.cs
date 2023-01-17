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
    public partial class DersListele : Form
    {
        public DersListele()
        {
            InitializeComponent();
        }

        WFormDBEntities db = new WFormDBEntities();

        private void DersListele_Load(object sender, EventArgs e)
        {
            var ctx = new WFormDBEntities();
            var dersTabs = ctx.DersTab.ToList();
            var bindingList = new BindingList<DersTab>(dersTabs);
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
                    renk.BackColor = Color.Pink;
                    renk.ForeColor = Color.Purple;
                }

                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Sil")
            {
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    bindingSource1.RemoveCurrent();

            }


        }
        
    }


    
}
