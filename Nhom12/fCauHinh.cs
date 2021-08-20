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
using System.Data.SqlClient;
namespace Nhom12
{
    public partial class fCauHinh : Form
    {
        DBConnection dbConn = new DBConnection();
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("ID không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvLaptop.DataSource = dpCauHinh.showLapTopByID(txtID.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLaptop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvLaptop.CurrentRow.Index;
            txtID.Text = dgvLaptop.Rows[i].Cells[0].Value.ToString();
            txtMoTa.Text = dgvLaptop.Rows[i].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = dbConn.getConnect();
                conn.Open();
               
                string sql = "insert into CauHinh values (@id,@mt)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@mt", txtMoTa.Text);
                if (txtMoTa.Text == "")
                {
                    MessageBox.Show("MÔ TẢ CẤU HÌNH KHÔNG ĐƯỢC ĐỂ TRỐNG", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cmd.ExecuteNonQuery();
                fCauHinh_Load(sender, e);

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key"))
                    MessageBox.Show("KHÔNG THÊM ĐƯỢC CẤU HÌNH MỚI VÌ TRÙNG ID", "error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = dbConn.getConnect();
                conn.Open();

                String sql = "UPDATE CauHinh SET  Description=@mt WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mt", txtMoTa.Text);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                if (txtMoTa.Text == "")
                {
                    MessageBox.Show("MÔ TẢ CẤU HÌNH KHÔNG ĐƯỢC ĐỂ TRỐNG", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cmd.ExecuteNonQuery();
                fCauHinh_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = dbConn.getConnect();
                conn.Open();
                String sql = "DELETE CauHinh WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.ExecuteNonQuery();

                fCauHinh_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
