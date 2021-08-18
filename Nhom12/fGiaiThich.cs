using Nhom12.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom12
{
    public partial class fGiaiThich : Form
    {   
        ThuatToanSuyDienTien tt = new ThuatToanSuyDienTien();

        public static DataGridView dgvGiaiThich = new DataGridView();

        public fGiaiThich()
        {
            InitializeComponent();
            dgvGiaiThich = dataGridView1;
        }
        private void dgvStyle()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.ForeColor = Color.Black;
        }
        private void fKetQua_Load(object sender, EventArgs e)
        {
            dgvStyle();
            List<GiaiThich> giaiThich = new List<GiaiThich>();
            giaiThich.AddRange(fKetQua.allGiaiThich());
            int dem = 0;
            foreach (GiaiThich gt in giaiThich)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[dem].Clone();
                row.Height = 50;
                row.Cells[0].Value = dem;
                row.Cells[1].Value = gt.r.ID1;
                String a = "";
                for (int i = 0; i < gt.TG.Count; i++)
                    a += gt.TG[i]+", ";
                row.Cells[2].Value = a;

                a = "";
                for (int i = 0; i < gt.SAT.Count; i++)
                {
                    a += gt.SAT[i].ID1+", ";
                }
                row.Cells[3].Value = a;
                dataGridView1.Rows.Add(row);
                dem++;
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            fMain.OpenChildForm(new fTuVan());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fMain.OpenChildForm(new fKetQua());
        }
    }
}
