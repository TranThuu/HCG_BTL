using Nhom12.DAO;
using Nhom12.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom12
{
    public partial class fKetQua : Form
    {
        public static ThuatToanSuyDienTien sdt = new ThuatToanSuyDienTien();
        List<string> laptop = new List<string>();
        DP_Laptop lt = new DP_Laptop();

        private void dgvStyle()
        {
            dgvCauHinh.BorderStyle = BorderStyle.None;
            dgvCauHinh.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvCauHinh.ForeColor = Color.Black;
        }
        public fKetQua()
        {
            InitializeComponent();
            btnNext.Visible = false;
            btnBack.Visible = false;
        }
        
        private void fKetQua_Load(object sender, EventArgs e)
        {
            findLaptop();
            if (laptop.Count > 0)
            {
                dgvStyle();
                try
                {
                    showLaptop(0);
                    if (laptop.Count > 1) btnNext.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"..\..\Images\noLaptop.jpg");
                MessageBox.Show("Có vẻ như hệ thống không tìm thấy chiếc Laptop phù hợp với yêu cầu của bạn!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public Image ConvertByArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        void findLaptop()
        {
            List<String> TG = sdt.ThuatToan();
            
            for(int i = 0; i < TG.Count; i++)
            {
                if (TG[i].Contains("LT"))
                    laptop.Add(TG[i]);
            }
        }
        void showLaptop( int index)
        {
            dgvCauHinh.Rows.Clear();
            DataTable dt = lt.inforLaptop(laptop[index]);
            pictureBox1.Image = ConvertByArrayToImage((byte[])dt.Rows[0]["AnhLaptop"]);

            lbTenLaptop.Text = dt.Rows[0]["Name"].ToString();
            int price = (int)dt.Rows[0]["Price"];
            lbGia.Text = price.ToString("###\\.###\\.##0");

            this.dgvCauHinh.Rows.Add("CPU", dt.Rows[0]["CPU"].ToString());
            this.dgvCauHinh.Rows.Add("RAM", dt.Rows[0]["RAM"].ToString());
            this.dgvCauHinh.Rows.Add("Ổ cứng", dt.Rows[0]["OCung"].ToString());
            this.dgvCauHinh.Rows.Add("Màn hình", dt.Rows[0]["ManHinh"].ToString());
            this.dgvCauHinh.Rows.Add("Card màn hình", dt.Rows[0]["CardManHinh"].ToString());
            this.dgvCauHinh.Rows.Add("Kích thước, trọng lượng", dt.Rows[0]["KichThuoc"].ToString());
        }
        private void fGiaiThich_Click(object sender, EventArgs e)
        {
            fMain.OpenChildForm(new fGiaiThich());
        }
        
        private void fLamLai_Click(object sender, EventArgs e)
        {
            fMain.OpenChildForm(new fTuVan());
        }
        public static List<GiaiThich> allGiaiThich()
        {
            return sdt.returnGiaiThich();
        }
        int index=1;
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            try
            {
                btnBack.Visible = true;
                showLaptop(index);
                index++;
                if (index == laptop.Count)
                    btnNext.Visible = false;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                int i = index - 2;
                btnNext.Visible = true;
                showLaptop(i);
                index=i+1;
                if (i == 0)
                    btnBack.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://fptshop.com.vn");
        }
    }
}
