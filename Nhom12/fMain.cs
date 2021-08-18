using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace Nhom12
{
    public partial class fMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private static Form currentChildForm;

        public static Label lb2 = new Label();
        public static Panel plContent = new Panel();
        public static Label lbTitle = new Label();
        public fMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            currentChildForm = new Form();
            pnlSubMenu.Visible = false;
            lb2 = label2;
            plContent = panelContent;
            lbTitle = labTitle;

        }
        private struct RGBColors {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color, int y)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(76, 75, 105);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y+y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //
                iconTeam.IconChar = currentBtn.IconChar;
                iconTeam.IconColor = color;
                labTitle.ForeColor = color;


            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(50, 49, 69);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public static void OpenChildForm(Form childForm)
        {
            
            if(lb2 != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            plContent.Controls.Add(childForm);
            plContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Visible = true;
            lbTitle.Text = childForm.Text;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            labTitle.Visible = false;
        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6,0);
            OpenChildForm(new fTuVan());
        }

        private void btnCoSoTriThuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2,0);
            if (pnlSubMenu.Visible == false)
            {
                pnlSubMenu.Visible = true;
            }
            else
                pnlSubMenu.Visible = false;
            //OpenChildForm(new fCoSoTriThuc());
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3,0);
            OpenChildForm(new fHuongDan());
        }

        private void btnNhom_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1,0);
            OpenChildForm(new fTeam());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5,0);
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconTeam.IconChar = IconChar.Fish;
            iconTeam.IconColor = Color.DeepSkyBlue;
            labTitle.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Reset();
        }
        //drag from
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLaptop_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2,181+120);
            OpenChildForm(new fLaptop());
        }

        private void btnLuat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6,181+120);
            OpenChildForm(new fLuat());
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1,181+120);
            OpenChildForm(new fCauHinh());
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
