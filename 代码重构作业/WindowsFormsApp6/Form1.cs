﻿using System;
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

        public void addComments(String s)
        {
            Program.text += s;
            Program.texts[Program.tab] = s;

            this.richTextBox1.Text = Program.text;
            Program.tab++;
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

        private void button0_Click(object sender, EventArgs e)
        {
            this.addComments("0");
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            this.addComments(".");

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            this.addComments("+");
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            this.addComments("-");
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            this.addComments("*");
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            this.addComments("/");
        }

        private void button_left_bracket_Click(object sender, EventArgs e)
        {
            this.addComments("(");
        }

        private void button_right_bracket_Click(object sender, EventArgs e)
        {
            this.addComments(")");
        }

        public void button_equ_Click(object sender, EventArgs e)
        {
            calculate x = new calculate();
            this.richTextBox1.Text=x.equal();
            Log y = new Log();
            y.save();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (Program.tab > 0)
            {
                Program.tab -= 1;
            }
            Program.text = "";
            for (int i = 0; i < Program.tab; i++)
            {
                Program.text += Program.texts[i];
            }

            this.richTextBox1.Text = Program.text;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            Program.text = "";
            this.richTextBox1.Text = Program.text;
        }

        private void button_left_move_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = calculate.move(Program.Precord - 1);
        }


        private void button_right_move_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = calculate.move(Program.Precord + 1);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_history_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\history.txt");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
