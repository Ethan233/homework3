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

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string result ;
        int tab = 0;
        //记录指针
        int Precord = 0;
        //记录数
        int RecordNum = 0;
        public String text = "";
        //存储记录
        public String[] record = new String[10];
        //存储表达式
        public String[] texts = new String[10000];
        //加载js引擎
        Microsoft.JScript.Vsa.VsaEngine ve = Microsoft.JScript.Vsa.VsaEngine.CreateEngine();

        //处理表达式
        public void addComments(String s)
        {
            this.text += s;
            this.texts[tab] = s;

            this.richTextBox1.Text = this.text;
            tab++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.addComments("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.addComments("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.addComments("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.addComments("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.addComments("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.addComments("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.addComments("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.addComments("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.addComments("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.addComments("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.addComments(".");

        }

        /// <summary>
        /// =按钮的触发事件,最终计算结果并显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button12_Click(object sender, EventArgs e)
        {
            try
            {
                //就是结果
                result = Microsoft.JScript.Eval.JScriptEvaluate(this.text, ve).ToString();
                this.richTextBox1.Text = result;
                this.record[RecordNum] = this.text;
                this.text = result;

                this.RecordNum++;

                this.Precord = this.RecordNum;

            }
            catch (Exception)
            {
                this.richTextBox1.Text = "输入错误！";
                this.text = "";
                tab = 0;
            }

            string result1 = @"D:\history.txt";
            FileStream fs = new FileStream(result1, FileMode.Append);
            StreamWriter wr = null;
            wr = new StreamWriter(fs);
            wr.WriteLine(record[RecordNum - 1] + "=" + richTextBox1.Text);
            wr.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.addComments("+");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.addComments("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.addComments("*");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.addComments("/");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.addComments("(");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.addComments(")");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (tab > 0)
            {
                tab -= 1;
            }
            this.text = "";
            for (int i = 0; i < tab; i++)
            {
                this.text += this.texts[i];
            }

            this.richTextBox1.Text = this.text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.text = "";
            this.richTextBox1.Text = this.text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Precord--;
            if (Precord < 0)
            {
                Precord = 0;
            }
            this.text = this.record[Precord];
            this.richTextBox1.Text = this.record[Precord];
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Precord++;
            if (Precord > RecordNum)
            {
                Precord = RecordNum;
            }
            this.text = this.record[Precord];
            this.richTextBox1.Text = this.record[Precord];

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\history.txt");
        }
    }
}
