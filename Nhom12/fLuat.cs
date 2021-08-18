using Nhom12.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom12
{
    public partial class fLuat : Form
    {
        DP_Luat dpLuat = new DP_Luat();
        DP_Laptop dpLaptop = new DP_Laptop(); 
        DP_CauHinh dpCauHinh = new DP_CauHinh();
        String veTrai="";
        public fLuat()
        {
            InitializeComponent();
            btnReMove.Visible = false;
            txtID.Enabled = false;
            btnSua.Enabled = false;
        }
        private void dgvStyle()
        {
            dgvLaptop.BorderStyle = BorderStyle.None;
            dgvLaptop.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvLaptop.ForeColor = Color.Black;
        }
        private void fLuat_Load(object sender, EventArgs e)
        {
            try
            {
                dgvLaptop.DataSource = dpLuat.showLuat();
                DataTable d = dpLuat.showLuat();
                txtID.Text = "R" + (d.Rows.Count+1);
         
                DataTable dt = dpLaptop.showLaptop();
                cmbVP.DataSource = dt;
                cmbVP.DisplayMember = "Name";
                cmbVP.ValueMember = "ID";

                DataTable dt2 = dpCauHinh.showCauHinh();
                cmbVT.DataSource = dt2;
                cmbVT.DisplayMember = "Description";
                cmbVT.ValueMember = "ID";
                if (lbVT.Text != "")
                    btnReMove.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvStyle();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            veTrai+=cmbVT.SelectedValue.ToString()+"^";
            lbVT.Text = veTrai.Remove(veTrai.Length - 1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {   
                if (lbVT.Text == "")
                    throw new Exception("Hãy thêm vế trái cho tập luật");
                dpLuat.InsertLuat(txtID.Text, lbVT.Text, cmbVP.SelectedValue.ToString());
                btnCancel_Click(sender, e);
                MessageBox.Show("Thêm Luật thành công!","Thông báo",MessageBoxButtons.OK);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvLaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnReMove.Visible = true;
            btnSua.Enabled = true;
            int index = e.RowIndex;
            txtID.Text = dgvLaptop.Rows[index].Cells[0].Value.ToString();
            cmbVP.SelectedValue = dgvLaptop.Rows[index].Cells[2].Value.ToString();
            lbVT.Text = dgvLaptop.Rows[index].Cells[1].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            veTrai = "";
            lbVT.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbVT.Text == "")
                    throw new Exception("Hãy thêm vế trái cho tập luật");
                dpLuat.SuaLuat(txtID.Text, lbVT.Text, cmbVP.SelectedValue.ToString());
                btnCancel_Click(sender, e);
                MessageBox.Show("Sửa Luật thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {   
            lbVT.Text = "";
            fLuat_Load(sender, e); 
        }
    }
}
