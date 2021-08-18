using Nhom12.DAO;
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
    public partial class fCauHinh : Form
    {
        DP_CauHinh dpCauHinh = new DP_CauHinh();
        public fCauHinh()
        {
            InitializeComponent();
        }
        private void dgvStyle()
        {
            dgvLaptop.BorderStyle = BorderStyle.None;
            dgvLaptop.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvLaptop.ForeColor = Color.Black;
        }

        private void fCauHinh_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dpCauHinh.showCauHinh();
                dgvLaptop.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvStyle();
        }
    }
}
