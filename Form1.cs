using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox
{
    public partial class Form1 : Form
    {
        public int Length { get; set; }
        public int total { get; set; }
        public String add { get; set; }
        public String sel { get; set; }
        public int boll1 { get; set; }
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        Random crandom = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Chk6.Checked = true;
            RdbS2.Checked = true;
            RdbO2.Checked = true;
            LblMsg.Text = "歡迎使用！";
            LblMsg2.Text = "目前金額";
            string[] aryNoodle = new string[] {"焗烤義大利麵", "焗烤飯", "焗烤土司"};
             a = crandom.Next(1000, 9999);
             b = crandom.Next(1000, 9999);
            string c = a.ToString();
            label6.Text = c;

        }


        private void BtnOK_Click(object sender, EventArgs e)
        {
            string[] aryNoodle = new string[] { "焗烤義大利麵", "焗烤飯", "焗烤土司" };
            int total = 0;
            String sel = "主餐:", add = "";

            if (DTP1.Value.DayOfWeek == DayOfWeek.Monday)
            {
                label3.Text = "星期一只供應焗烤義大利麵";
                Chk5.Checked = true;
            }

            if (Chk5.Checked == true)
                sel += "焗烤義大利麵；";
            else if (Chk6.Checked == true)
                sel += "焗烤飯；";
            else
                sel += "焗烤土司；";

            if (Chk5.Checked == true && TB1.Text.Length == 8)
            {
                total += 60;
                pictureBox1.Image = imageList1.Images[0];
            }
            if (Chk6.Checked == true && TB1.Text.Length == 8)
            {
                total += 65;
                pictureBox1.Image = imageList1.Images[1];

                if(DTP1.Value.DayOfWeek == DayOfWeek.Monday)
                {
                    Chk5.Checked = true;
                    MessageBox.Show("星期一只供應焗烤義大利麵", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                }
            }
            if (Chk7.Checked == true && TB1.Text.Length == 8)
            {
                total += 70;
                pictureBox1.Image = imageList1.Images[2];

                if (DTP1.Value.DayOfWeek == DayOfWeek.Monday)
                {
                    Chk5.Checked = true;
                    MessageBox.Show("星期一只供應焗烤義大利麵", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                }
            }

            sel += "用餐地點："; 
            if (RdbS1.Checked == true) 
                sel += "內用";
            else if (RdbS2.Checked == true)
                sel += "外帶";

            sel += "；起司種類："; 
            if (RdbO1.Checked == true)
                sel += "莫札瑞拉起司";
            else if (RdbO2.Checked == true)
                sel += "切達起司";
            else
                sel += "帕瑪森起士";
            if (Chk1.Checked == true) 
            {
                total += 40;
                add += "薄片吐司";
            }
            if (Chk2.Checked == true)  
            {
                total += 10;
                add += (add == "" ? "" : "，") + "茶葉蛋"; 
            }
            if (Chk3.Checked == true)
            {
                total += 20;
                add += (add == "" ? "" : "，") + "綠茶";
            }
            if (Chk4.Checked == true)
            {
                total += 20;
                add += (add == "" ? "" : "，") + "紅茶";
            }

            if (TB1.Text.Length != 8)
            {
                MessageBox.Show("學號長度錯誤", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if (TB1.Text == "")
            {
                MessageBox.Show("請輸入學號", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else
            {
                boll1 = 1;
                MessageBox.Show("請五樓熱食部領取餐點", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                LblMsg.Text = "總價:" + total + "元\n" + sel + (add == "" ? "" : "\n加點:" + add)+ "\n學生學號:" + TB1.Text+"\n下訂時間:"+ DateTime.Now.ToShortDateString()+""+ DateTime.Now.ToShortTimeString()
                + "\n預訂時間:"+DTP1.Value;
            }

        }

        private void BtnOK2_Click(object sender, EventArgs e)
        {
            int total = 0;
            String sel = "主餐:", add = "";

            if (Chk5.Checked == true)
                sel += "焗烤義大利麵；";
            else if (Chk6.Checked == true)
                sel += "焗烤飯；";
            else
                sel += "焗烤土司；";

            if (Chk5.Checked == true)
            {
                total += 60;
            }
            if (Chk6.Checked == true)
            {
                total += 65;
            }
            if (Chk7.Checked == true)
            {
                total += 70;
            }

            sel += "用餐地點：";
            if (RdbS1.Checked == true)
                sel += "內用";
            else if (RdbS2.Checked == true)
                sel += "外帶";

            sel += "；起司種類：";
            if (RdbO1.Checked == true)
                sel += "莫札瑞拉起司";
            else if (RdbO2.Checked == true)
                sel += "切達起司";
            else
                sel += "帕瑪森起士";
            if (Chk1.Checked == true)
            {
                total += 40;
                add += "薄片吐司";
            }
            if (Chk2.Checked == true)
            {
                total += 10;
                add += (add == "" ? "" : "，") + "茶葉蛋";
            }
            if (Chk3.Checked == true)
            {
                total += 20;
                add += (add == "" ? "" : "，") + "綠茶";
            }
            if (Chk4.Checked == true)
            {
                total += 20;
                add += (add == "" ? "" : "，") + "紅茶";
            }
            LblMsg3.Text = total + "元";

        }

        private void BtnOK3_Click(object sender, EventArgs e)
        {

            if (Chk5.Checked == true)
            {
                pictureBox1.Image = imageList1.Images[0];
            }
            if (Chk6.Checked == true)
            {
                pictureBox1.Image = imageList1.Images[1];
            }
            if (Chk7.Checked == true)
            {
                pictureBox1.Image = imageList1.Images[2];
            }

        }

        private void BtnOK4_Click(object sender, EventArgs e)
        {

            int total = 0;
            String sel = "主餐:", add = "";

            if (Chk5.Checked == true)
                sel += "焗烤義大利麵；";
            else if (Chk6.Checked == true)
                sel += "焗烤飯；";
            else
                sel += "焗烤土司；";

            if (Chk5.Checked == true)
            {
                total += 60;
            }
            if (Chk6.Checked == true)
            {
                total += 65;
            }
            if (Chk7.Checked == true)
            {
                total += 70;
            }

            sel += "用餐地點：";
            if (RdbS1.Checked == true)
                sel += "內用";
            else if (RdbS2.Checked == true)
                sel += "外帶";

            sel += "；起司種類：";
            if (RdbO1.Checked == true)
                sel += "莫札瑞拉起司";
            else if (RdbO2.Checked == true)
                sel += "切達起司";
            else
                sel += "帕瑪森起士";
            if (Chk1.Checked == true)
            {
                total += 40;
                add += "薄片吐司";
            }
            if (Chk2.Checked == true)
            {
                total += 10;
                add += (add == "" ? "" : "，") + "茶葉蛋";
            }
            if (Chk3.Checked == true)
            {
                total += 20;
                add += (add == "" ? "" : "，") + "綠茶";
            }
            if (Chk4.Checked == true)
            {
                total += 20;
                add += (add == "" ? "" : "，") + "紅茶";
            }

            if (TB1.Text.Length != 8)
            {
                MessageBox.Show("學號長度錯誤", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if (TB1.Text == "")
            {
                MessageBox.Show("請輸入學號", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if(boll1 != 1)
            {
                MessageBox.Show("請先確認訂單", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else
            {


                MessageBox.Show(LblMsg.Text = "總價:" + total + "元\n" + sel + (add == "" ? "" : "\n加點:" + add) + "\n學生學號:" + TB1.Text + "\n下訂時間:" + DateTime.Now.ToShortDateString() + "" + DateTime.Now.ToShortTimeString()
                + "\n預訂時間:" + DTP1.Value + "\n發票號碼:" + b, "帳單", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (b == a) 
                {
                    MessageBox.Show("您的發票號碼與本期號碼相同，請至學務處領取獎品", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("可惜!您沒有中獎", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                }

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DTP1.Value.DayOfWeek == DayOfWeek.Monday)
            {
                label3.Text = "星期一只供應焗烤義大利麵";
                Chk5.Checked = true;
            }
        }

        private void BtnOK5_Click(object sender, EventArgs e)
        {
            TB1.Text= "";
        }
    }
}
