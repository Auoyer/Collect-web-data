namespace 时间
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tB3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.tB4 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.tB5 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.tB6 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "年：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 18);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.toolTip1.SetToolTip(this.button1, "当前年份加1");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(81, 15);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(47, 21);
            this.tB1.TabIndex = 2;
            this.tB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB1.Enter += new System.EventHandler(this.tB1_Enter);
            this.tB1.Leave += new System.EventHandler(this.tB1_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 18);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.toolTip1.SetToolTip(this.button2, "当前年份减1");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 18);
            this.button3.TabIndex = 7;
            this.button3.Text = "-";
            this.toolTip1.SetToolTip(this.button3, "当前月份减1");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tB2
            // 
            this.tB2.Location = new System.Drawing.Point(81, 41);
            this.tB2.Name = "tB2";
            this.tB2.Size = new System.Drawing.Size(47, 21);
            this.tB2.TabIndex = 6;
            this.tB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB2.Enter += new System.EventHandler(this.tB2_Enter);
            this.tB2.Leave += new System.EventHandler(this.tB2_Leave);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(133, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(18, 18);
            this.button4.TabIndex = 5;
            this.button4.Text = "+";
            this.toolTip1.SetToolTip(this.button4, "当前月份加1");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "月：";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(57, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(18, 18);
            this.button5.TabIndex = 11;
            this.button5.Text = "-";
            this.toolTip1.SetToolTip(this.button5, "当前日份减1");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tB3
            // 
            this.tB3.Location = new System.Drawing.Point(81, 69);
            this.tB3.Name = "tB3";
            this.tB3.Size = new System.Drawing.Size(47, 21);
            this.tB3.TabIndex = 10;
            this.tB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB3.Enter += new System.EventHandler(this.tB3_Enter);
            this.tB3.Leave += new System.EventHandler(this.tB3_Leave);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(133, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(18, 18);
            this.button6.TabIndex = 9;
            this.button6.Text = "+";
            this.toolTip1.SetToolTip(this.button6, "当前日份加1");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "日：";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(57, 101);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(18, 18);
            this.button7.TabIndex = 15;
            this.button7.Text = "-";
            this.toolTip1.SetToolTip(this.button7, "当前时钟减1");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tB4
            // 
            this.tB4.Location = new System.Drawing.Point(81, 99);
            this.tB4.Name = "tB4";
            this.tB4.Size = new System.Drawing.Size(47, 21);
            this.tB4.TabIndex = 14;
            this.tB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB4.Enter += new System.EventHandler(this.tB4_Enter);
            this.tB4.Leave += new System.EventHandler(this.tB4_Leave);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(133, 100);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(18, 18);
            this.button8.TabIndex = 13;
            this.button8.Text = "+";
            this.toolTip1.SetToolTip(this.button8, "当前时钟加1");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "时：";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(57, 129);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(18, 18);
            this.button9.TabIndex = 19;
            this.button9.Text = "-";
            this.toolTip1.SetToolTip(this.button9, "当前分钟减1");
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tB5
            // 
            this.tB5.Location = new System.Drawing.Point(81, 127);
            this.tB5.Name = "tB5";
            this.tB5.Size = new System.Drawing.Size(47, 21);
            this.tB5.TabIndex = 18;
            this.tB5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB5.Enter += new System.EventHandler(this.tB5_Enter);
            this.tB5.Leave += new System.EventHandler(this.tB5_Leave);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(133, 128);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(18, 18);
            this.button10.TabIndex = 17;
            this.button10.Text = "+";
            this.toolTip1.SetToolTip(this.button10, "当前分钟加1");
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "分：";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(57, 158);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(18, 18);
            this.button11.TabIndex = 23;
            this.button11.Text = "-";
            this.toolTip1.SetToolTip(this.button11, "当前秒钟减1");
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // tB6
            // 
            this.tB6.Location = new System.Drawing.Point(81, 156);
            this.tB6.Name = "tB6";
            this.tB6.Size = new System.Drawing.Size(47, 21);
            this.tB6.TabIndex = 22;
            this.tB6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB6.Enter += new System.EventHandler(this.tB6_Enter);
            this.tB6.Leave += new System.EventHandler(this.tB6_Leave);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(133, 157);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(18, 18);
            this.button12.TabIndex = 21;
            this.button12.Text = "+";
            this.toolTip1.SetToolTip(this.button12, "当前秒钟加1");
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "秒：";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(29, 196);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(46, 23);
            this.button13.TabIndex = 24;
            this.button13.Text = "取消";
            this.toolTip1.SetToolTip(this.button13, "恢复对文本款的编辑");
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(109, 196);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(43, 23);
            this.button14.TabIndex = 25;
            this.button14.Text = "设置";
            this.toolTip1.SetToolTip(this.button14, "将文本框的时间设置为系统时间");
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(29, 229);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(123, 23);
            this.button15.TabIndex = 26;
            this.button15.Text = "锁定系统时间";
            this.toolTip1.SetToolTip(this.button15, "锁定系统时间，禁止他人改动");
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(29, 256);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(123, 23);
            this.button16.TabIndex = 27;
            this.button16.Text = "获取并设置网络时间";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 282);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.tB6);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.tB5);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tB4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tB3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统时间";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tB2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tB3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox tB4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox tB5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox tB6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

