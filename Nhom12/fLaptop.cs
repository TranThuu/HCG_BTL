using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom12.DAO;

namespace Nhom12
{
    public partial class fLaptop : Form
    {
        DP_Laptop dpLaptop = new DP_Laptop();
        string ID;
        public fLaptop()
        {
            InitializeComponent();
            
        }
        private void dgvStyle()
        {
            dgvLaptop.BorderStyle = BorderStyle.None;
            dgvLaptop.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvLaptop.ForeColor = Color.Black;
        }
        private void fLaptop_Load(object sender, EventArgs e)
        {
            try
            {
                //dgvLaptop.DataSource = dpLaptop.showLapTopPaging(1);
                dgvLaptop.DataSource = dpLaptop.showLaptop();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvStyle();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" & txtTen.Text == "")
                {
                    MessageBox.Show("ID, Name không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtID.Text == "" && txtTen.Text != "")
                {
                    dgvLaptop.DataSource = dpLaptop.showLapTopByName(txtTen.Text);
                }
                else
                {
                    dgvLaptop.DataSource = dpLaptop.showLapTopByID(txtID.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemLapTop frmThem = new fThemLapTop();
            frmThem.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fSuaLapTop frmSua = new fSuaLapTop();
            frmSua.Sender(ID);
            frmSua.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
        //phân trang

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtSoTrang.Text);

            if (page > 1)
                page--;

            txtSoTrang.Text = page.ToString();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtSoTrang.Text);
            int sumRecord = dpLaptop.TongLapTop();
            int lastPage = sumRecord / 9;

            if (sumRecord % 9 != 0)
                lastPage++;

            if (page < lastPage)
                page++;

            txtSoTrang.Text = page.ToString();
        }

        private void txtSoTrang_TextChanged(object sender, EventArgs e)
        {
            dgvLaptop.DataSource = dpLaptop.showLapTopPaging(int.Parse(txtSoTrang.Text));
        }

        private void dgvLaptop_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvLaptop.SelectedRows)
            {
                ID = row.Cells[0].Value.ToString();
            }
        }
    }
}
