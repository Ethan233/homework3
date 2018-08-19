namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_history = new System.Windows.Forms.Button();
            this.button_right_move = new System.Windows.Forms.Button();
            this.button_left_move = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_right_bracket = new System.Windows.Forms.Button();
            this.button_left_bracket = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_equ = new System.Windows.Forms.Button();
            this.button_point = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(400, 81);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_history);
            this.groupBox1.Controls.Add(this.button_right_move);
            this.groupBox1.Controls.Add(this.button_left_move);
            this.groupBox1.Controls.Add(this.button_reset);
            this.groupBox1.Controls.Add(this.button_back);
            this.groupBox1.Controls.Add(this.button_right_bracket);
            this.groupBox1.Controls.Add(this.button_left_bracket);
            this.groupBox1.Controls.Add(this.button_div);
            this.groupBox1.Controls.Add(this.button_mul);
            this.groupBox1.Controls.Add(this.button_sub);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.button_equ);
            this.groupBox1.Controls.Add(this.button_point);
            this.groupBox1.Controls.Add(this.button0);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 447);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "简易计算器";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_history
            // 
            this.button_history.Location = new System.Drawing.Point(414, 24);
            this.button_history.Name = "button_history";
            this.button_history.Size = new System.Drawing.Size(41, 81);
            this.button_history.TabIndex = 23;
            this.button_history.Text = "历史记录";
            this.button_history.UseVisualStyleBackColor = true;
            this.button_history.Click += new System.EventHandler(this.button_history_Click);
            // 
            // button_right_move
            // 
            this.button_right_move.Location = new System.Drawing.Point(246, 111);
            this.button_right_move.Name = "button_right_move";
            this.button_right_move.Size = new System.Drawing.Size(209, 34);
            this.button_right_move.TabIndex = 22;
            this.button_right_move.Text = ">";
            this.button_right_move.UseVisualStyleBackColor = true;
            this.button_right_move.Click += new System.EventHandler(this.button_right_move_Click);
            // 
            // button_left_move
            // 
            this.button_left_move.Location = new System.Drawing.Point(8, 111);
            this.button_left_move.Name = "button_left_move";
            this.button_left_move.Size = new System.Drawing.Size(208, 34);
            this.button_left_move.TabIndex = 21;
            this.button_left_move.Text = "<";
            this.button_left_move.UseVisualStyleBackColor = true;
            this.button_left_move.Click += new System.EventHandler(this.button_left_move_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(323, 151);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(132, 45);
            this.button_reset.TabIndex = 20;
            this.button_reset.Text = "清零";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(206, 151);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(93, 45);
            this.button_back.TabIndex = 19;
            this.button_back.Text = "退格";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_right_bracket
            // 
            this.button_right_bracket.Location = new System.Drawing.Point(107, 151);
            this.button_right_bracket.Name = "button_right_bracket";
            this.button_right_bracket.Size = new System.Drawing.Size(93, 45);
            this.button_right_bracket.TabIndex = 18;
            this.button_right_bracket.Text = ")";
            this.button_right_bracket.UseVisualStyleBackColor = true;
            this.button_right_bracket.Click += new System.EventHandler(this.button_right_bracket_Click);
            // 
            // button_left_bracket
            // 
            this.button_left_bracket.Location = new System.Drawing.Point(8, 151);
            this.button_left_bracket.Name = "button_left_bracket";
            this.button_left_bracket.Size = new System.Drawing.Size(93, 45);
            this.button_left_bracket.TabIndex = 17;
            this.button_left_bracket.Text = "(";
            this.button_left_bracket.UseVisualStyleBackColor = true;
            this.button_left_bracket.Click += new System.EventHandler(this.button_left_bracket_Click);
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(323, 355);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(132, 45);
            this.button_div.TabIndex = 16;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_mul
            // 
            this.button_mul.BackColor = System.Drawing.SystemColors.Control;
            this.button_mul.Location = new System.Drawing.Point(323, 304);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(132, 45);
            this.button_mul.TabIndex = 15;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = false;
            this.button_mul.Click += new System.EventHandler(this.button_mul_Click);
            // 
            // button_sub
            // 
            this.button_sub.Location = new System.Drawing.Point(323, 253);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(132, 45);
            this.button_sub.TabIndex = 14;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.button_sub_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(323, 202);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(132, 45);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_equ
            // 
            this.button_equ.Location = new System.Drawing.Point(206, 355);
            this.button_equ.Name = "button_equ";
            this.button_equ.Size = new System.Drawing.Size(93, 45);
            this.button_equ.TabIndex = 12;
            this.button_equ.Text = "=";
            this.button_equ.UseVisualStyleBackColor = true;
            this.button_equ.Click += new System.EventHandler(this.button_equ_Click);
            // 
            // button_point
            // 
            this.button_point.Location = new System.Drawing.Point(107, 355);
            this.button_point.Name = "button_point";
            this.button_point.Size = new System.Drawing.Size(93, 45);
            this.button_point.TabIndex = 11;
            this.button_point.Text = ".";
            this.button_point.UseVisualStyleBackColor = true;
            this.button_point.Click += new System.EventHandler(this.button_point_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(8, 355);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(93, 45);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(206, 304);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 45);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(107, 304);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 45);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 304);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 45);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(206, 253);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(107, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 45);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 418);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_point;
        private System.Windows.Forms.Button button_equ;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_right_bracket;
        private System.Windows.Forms.Button button_left_bracket;
        private System.Windows.Forms.Button button_right_move;
        private System.Windows.Forms.Button button_left_move;
        private System.Windows.Forms.Button button_history;
    }
}

