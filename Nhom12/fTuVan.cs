using Nhom12.DTO;
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
    public partial class fTuVan : Form
    {
        DataProcessing dtpro = new DataProcessing();
        List<Question>  questions = new List<Question>();
        static List<String> myAnswers = new List<string>();
        int currentQuestion;
        public fTuVan()
        {
            InitializeComponent();
            buildListQuestion();
            hideQuestion();
            hideRadioButton();
        }
        private void buildListQuestion()
        {
            questions.Add(new Question("Mục đích mua Laptop của bạn là gì?", dtpro.SelectID("MD"),"MD"));
            questions.Add(new Question("Đâu là hãng sản xuất Laptop mà bạn muốn?", dtpro.SelectID("H"),"H"));
            questions.Add(new Question("Kích thước màn hình mong muốn của bạn?", dtpro.SelectID("MH"),"MH"));
            questions.Add(new Question("Bạn muốn một chiếc Laptop trong tầm giá nào?", dtpro.SelectID("G"),"G"));
            List<String> answers = dtpro.SelectID("K");
            answers.Add("Không");
            questions.Add(new Question("Bạn có thể chọn một số tính năng khác?",answers,"K"));
        }

        private void hideRadioButton()
        {
            rdb1.Visible = false;rdb1.Checked = false;
            rdb2.Visible = false;rdb2.Checked = false;
            rdb3.Visible = false;rdb3.Checked = false;
            rdb4.Visible = false;rdb4.Checked = false;
            rdb5.Visible = false;rdb5.Checked = false;
            rdb6.Visible = false;rdb6.Checked = false;
            rdb7.Visible = false;rdb7.Checked = false;
            checkBox1.Visible = false;checkBox1.Checked = false;
            checkBox1.Visible = false;checkBox1.Checked = false;
            checkBox2.Visible = false;checkBox2.Checked = false;
            checkBox3.Visible = false;checkBox3.Checked = false;
            checkBox4.Visible = false;checkBox4.Checked = false;
            checkBox5.Visible = false;checkBox5.Checked = false;
            checkBox6.Visible = false;checkBox6.Checked = false;
        }
        private void hideQuestion()
        {
            lbQuestion.Visible = false;
            btnReset.Visible = false;
            btnNext.Visible = false;
            btnBack.Visible = false;
        }
        private void showToolQuestion()
        {
            lbQuestion.Visible = true;
            btnReset.Visible = true;
            btnNext.Visible = true;
            btnBack.Visible = true;
        }
        private void fTuVan_Load(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }
        private void showQuestion(int index)
        {
            hideRadioButton();
            lbQuestion.Text = questions[index].question;
            if (index == questions.Count - 1)
            {
                for (int i = 0; i < questions[index].answers.Count; i++)
                {
                    CheckBox tg = (CheckBox)this.Controls.Find("checkBox" + (i + 1), true).FirstOrDefault();
                    tg.Text = questions[index].answers[i];
                    tg.Visible = true;
                }
            }else
            for (int i = 0; i < questions[index].answers.Count; i++)
                {
                    RadioButton tg = (RadioButton)this.Controls.Find("rdb" + (i + 1), true).FirstOrDefault();
                    tg.Text = questions[index].answers[i];
                    tg.Visible = true;
                }

        }
        private void btnStart_Click(object sender, EventArgs e)
        {   
            lbStart.Visible = false;
            lbStart2.Visible = false;
            btnStart.Visible = false;
            showToolQuestion();
            currentQuestion = 0;
            showQuestion(0);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            btnStart.Visible = true;
            lbStart.Visible = true;
            lbStart2.Visible = true;
            hideQuestion();
            hideRadioButton();
            myAnswers.Clear();
        }
        private void checkRd(RadioButton rd, int index)
        {
            if (rd.Checked)
            {
                myAnswers.Add(questions[currentQuestion].id + index.ToString());
                currentQuestion++;
                showQuestion(currentQuestion);
            }
        }

        private void checkCb()
        {
            int check = -1;
            if(currentQuestion == questions.Count-1)
            {
                if (checkBox1.Checked){ myAnswers.Add(questions[currentQuestion].id + "1");check = 0; }
                if (checkBox2.Checked){ myAnswers.Add(questions[currentQuestion].id + "2");check = 0; }
                if (checkBox3.Checked){ myAnswers.Add(questions[currentQuestion].id + "3");check = 0; }
                if (checkBox4.Checked){ myAnswers.Add(questions[currentQuestion].id + "4");check = 0; }
                if (checkBox5.Checked){ myAnswers.Add(questions[currentQuestion].id + "5");check = 0; }
                if (checkBox6.Checked){ check = 0; }
                
            }
            if (check==0)
                showKetQua();
        }

        private void showKetQua()
        {  
            fMain.OpenChildForm(new fKetQua());
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            checkRd(rdb1,1);
            checkRd(rdb2,2);
            checkRd(rdb3,3);
            checkRd(rdb4,4);
            checkRd(rdb5,5);
            checkRd(rdb6,6);
            checkRd(rdb7,7);
            checkCb();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (myAnswers.Count > 0)
            {
                currentQuestion-=1;
                showQuestion(currentQuestion);
                myAnswers.RemoveAt(myAnswers.Count - 1);
            }
            else
            {

            }
        }
        public static List<String> selectedAnswer()
        {
            return myAnswers;
        }
    }
}
