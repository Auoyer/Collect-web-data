using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 时间
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.mima = textBox1.Text.Trim().ToLower();
            if (Form1.mima == "red")
            {
                Form1.canLock = true;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
