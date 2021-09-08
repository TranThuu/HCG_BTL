using Nhom12.DAO;
using Nhom12.DTO;
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

        List<String> newRule = new List<string>();
        String vePhai = "";
        String veTrai="";
        public fLuat()
        {
            InitializeComponent();
            btnReMove.Visible = false;
            txtID.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
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
                //Thêm vế trái
                DataTable dt2 = dpCauHinh.showCauHinh();
                cmbVT.DataSource = dt2;
                cmbVT.DisplayMember = "Description";
                cmbVT.ValueMember = "ID";
                if (lbVT.Text != "")
                    btnReMove.Visible = true;
                //Thêm vế phải
                DataTable dt = dpLaptop.showLaptop();
                int countdt2 = dt2.Rows.Count;
                for(int i=0;i< countdt2; i++)
                {
                    dt.Rows.Add(dt2.Rows[i][0], dt2.Rows[i][1]);
                }
                cmbVP.DataSource = dt;
                cmbVP.DisplayMember = "Name";
                cmbVP.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvStyle();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnReMove.Visible = true;
            String vt = checkNotVT.Checked ? ("!" + cmbVT.SelectedValue.ToString()) : cmbVT.SelectedValue.ToString();
            newRule.Add(vt);
            veTrai+=vt+"^";
            lbVT.Text = veTrai.Remove(veTrai.Length - 1);
            checkNotVT.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbVT.Text == "")
                    throw new Exception("Hãy thêm vế trái cho tập luật");
                
                //Loại bỏ luật dư thừa khi thêm luật
                ThuatToanSuyDienTien sdt = new ThuatToanSuyDienTien(newRule, dpLuat.listLuat2());
                List<String> GT = sdt.ThuatToan();
                vePhai = checkNotVP.Checked ? ("!" + cmbVP.SelectedValue.ToString()) : cmbVP.SelectedValue.ToString();
                String notVP = checkNotVP.Checked ? (cmbVP.SelectedValue.ToString()) : ("!" + cmbVP.SelectedValue.ToString());
                Boolean result = GT.Contains(vePhai);
                Boolean mauThuan = GT.Contains(notVP);
                if (mauThuan)
                {
                    MessageBox.Show("Thêm Luật KHÔNG thành công, do mâu thuẫn với CSTT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!result)
                    {
                        LoaiBoSuKienDuThua();
                        dpLuat.InsertLuat(txtID.Text, lbVT.Text, vePhai);
                        btnCancel_Click(sender, e);
                        MessageBox.Show("Thêm Luật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm Luật KHÔNG thành công, do luật bị dư thừa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                checkNotVP.Checked = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvLaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnReMove.Visible = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                int index = e.RowIndex;
                txtID.Text = dgvLaptop.Rows[index].Cells[0].Value.ToString();
                cmbVP.SelectedValue = dgvLaptop.Rows[index].Cells[2].Value.ToString();
                lbVT.Text = dgvLaptop.Rows[index].Cells[1].Value.ToString();
                veTrai = lbVT.Text + "^";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            newRule.Clear();
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
                MessageBox.Show("Sửa Luật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancel_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            newRule.Clear();
            veTrai = "";
            lbVT.Text = "";
            fLuat_Load(sender, e); 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa luật này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    dpLuat.XoaLuat(txtID.Text);
                    MessageBox.Show("Xóa Luật thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Hủy xóa Luật thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                btnCancel_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnLoaiBoLuatThua_Click(object sender, EventArgs e)
        {
            try
            {
                //DataTable dt = dpLuat.showLuat();
                List<String> tapDuThua = new List<string>();
                List<Luat> listluat = dpLuat.listLuat2();
                List<Luat> listluat2 = dpLuat.listLuat2();
                int LuatCount = listluat.Count;

                for (int i = 0; i < LuatCount; i++)
                {
                    List<String> vt = listluat[i].VeTrai.Split('^').ToList();
                    listluat2 = new List<Luat>(listluat);
                    listluat2.RemoveAt(i);
                    ThuatToanSuyDienTien sdt = new ThuatToanSuyDienTien(vt, listluat2);
                    List<String> GT = sdt.ThuatToan();
                    Boolean result = GT.Contains(listluat[i].VePhai);
                    if (result)
                    {
                        tapDuThua.Add(listluat[i].ID1.ToString());
                        listluat.RemoveAt(i);
                        LuatCount--;
                        i--;
                    }
                }
                String tapDuThuaString = "";
                foreach (String a in tapDuThua)
                    tapDuThuaString += a + ", ";
                DialogResult kq = MessageBox.Show("Các luật dư thừa: " + tapDuThuaString + "\n Bạn có muốn xóa chúng không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (kq == DialogResult.OK)
                {
                    foreach (String a in tapDuThua)
                        dpLuat.XoaLuat(a);
                    MessageBox.Show("Xóa các luật dư thừa thành công!", "Thông báo", MessageBoxButtons.OK);
                    btnCancel_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void LoaiBoSuKienDuThua()
        {
            List<string> r1 = new List<string>();
            List<string> r2 = new List<string>();
            string vt = "";
            foreach (string sk in newRule)
            {
                r1.Add(sk);
                r2.Add(sk);
            }
            String suKien = "";
            List<string> suKienDuThua = new List<string>();
            for (int i = 0; i < newRule.Count(); i++)
            {
                suKien = newRule[i];
                r1.RemoveAt(i);//xóa sự kiện đang xét 
                vt = veTrai.Replace(suKien,string.Empty);//vế trái bằng vế trái của luật trừ sự kiện đang xét
                vePhai = checkNotVP.Checked ? ("!" + cmbVP.SelectedValue.ToString()) : cmbVP.SelectedValue.ToString();
                dpLuat.InsertLuat(txtID.Text, vt, vePhai);
                ThuatToanSuyDienTien sdt = new ThuatToanSuyDienTien(r1, dpLuat.listLuat2());
                List<string> TG = sdt.ThuatToan();
                Boolean result = TG.Contains(vePhai);
                if (result)
                {
                    suKienDuThua.Add(suKien);
                    r2.Remove(suKien);
                }
                r1.Add(newRule[i]);//thêm lại sự kiện đang xét để đc luật ban đầu
                dpLuat.XoaLuat(txtID.Text);
            }
            String suKienDuThuaString = "";
            foreach (String a in suKienDuThua)
            {
                suKienDuThuaString += a + ", ";
            }
            if (suKienDuThuaString != "")
            {
                MessageBox.Show("Các sự kiện dư thừa " + suKienDuThuaString, "Thông báo", MessageBoxButtons.OK);
            }
            vt = "";
            foreach(string a in r2)
            {
                vt += a + " ^";//vế trái sau khi bỏ các sự kiện thừa
            }
            String vtString = "";
            vtString = vt.Remove(vt.Length - 1);
            lbVT.Text = vtString;//hiển thị lên label
        }

        private void btnSKDT_Click(object sender, EventArgs e)
        {
            LoaiBoSuKienDuThua();
        }
    }
}
