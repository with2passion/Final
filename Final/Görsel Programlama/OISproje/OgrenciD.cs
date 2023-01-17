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
    public partial class OgrenciD : Form
    {
        public OgrenciD()
        {
            InitializeComponent();
        }

        WFormDBEntities db = new WFormDBEntities();

        private void OgrenciD_Load(object sender, EventArgs e)
        {
            var ctx = new WFormDBEntities();
            var ogrenciDersTabs = ctx.OgrenciDersTab.ToList();
            var bindingList = new BindingList<OgrenciDersTab>(ogrenciDersTabs);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows[0].Cells[0].Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dataGridView1.Rows[0].Cells[1].Value = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = "XYZ";
            row.Cells[1].Value = 50.2;
            dataGridView1.Rows.Add(row);
        }
    }
}
