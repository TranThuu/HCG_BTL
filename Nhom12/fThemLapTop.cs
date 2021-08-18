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
using System.IO;
namespace Nhom12
{
    
    public partial class fThemLapTop : Form
    {
        DP_Laptop dpLapTop = new DP_Laptop();
        List<string> lstTen;
        string fileName = "";
        public fThemLapTop()
        {
            InitializeComponent();
        }

        private void fThemLapTop_Load(object sender, EventArgs e)
        {
            ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            cbbCPU.Items.Add("Pentium/Celeron");
            cbbCPU.Items.Add("Core i3");
            cbbCPU.Items.Add("Core i5");
            cbbCPU.Items.Add("Core i7");
            cbbCPU.Items.Add("ADM");
            cbbCPU.Items.Add("Apple");
            cbbHDH.Items.Add("Windows");
            cbbHDH.Items.Add("MacOS");
            cbbHDH.Items.Add("Linux");
            cbbRAM.Items.Add("4 GB");
            cbbRAM.Items.Add("8 GB");
            cbbRAM.Items.Add("16 GB");
            cbbOCung.Items.Add("SSD 1 TB");
            cbbOCung.Items.Add("SSD 512 GB");
            cbbOCung.Items.Add("SSD 256 GB");
            cbbOCung.Items.Add("SSD 128 GB");
            cbbOCung.Items.Add(">HDD 1 TB");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(ValiData())
            {
                try
                {
                    dpLapTop.themLapTop(txtID.Text, txtTen.Text, int.Parse(txtGia.Text), cbbCPU.SelectedItem.ToString(), cbbRAM.SelectedItem.ToString(),
                        cbbOCung.SelectedItem.ToString(), txtManHinh.Text, txtCard.Text, cbbHDH.SelectedItem.ToString(), txtKichThuoc.Text,ptbAnh.Image);
                    DialogResult kq = MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (kq == DialogResult.OK)
                    {
                        Close();
                    }
                }
                catch(Exception ex)
                {
                    if(ex.Message.Contains("duplicate key"))
                    {
                        MessageBox.Show("Kiểm tra tùng khóa chính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image file(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // display image to picturebox
                    ptbAnh.Image = Image.FromFile(ofd.FileName);
                    fileName = ofd.FileName;
                }
            }
        }
        private bool ValiData()
        {
            if(txtID.Text=="")
            {
                MessageBox.Show("ID không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return false;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return false;
            }
            if (txtGia.Text == "")
            {
                MessageBox.Show("Giá không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGia.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtGia.Text);
                    if (int.Parse(txtGia.Text) <= 0)
                    {
                        MessageBox.Show("Giá phải lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtGia.Focus();
                        return false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn phải nhập vào một số nguyên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGia.Focus();
                    return false;
                }
            }
            if (txtManHinh.Text=="")
            {
                MessageBox.Show("Màn hình được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManHinh.Focus();
                return false;
            }
            if(cbbCPU.Text=="" || cbbOCung.Text=="" || cbbRAM.Text=="" ||cbbHDH.Text=="")
            {
                MessageBox.Show("Bạn phải chọn 1 trường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }    

            return true;
        }
    }
}
