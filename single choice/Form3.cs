using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace single_choice
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.button5.Click += new System.EventHandler(this.button5_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); // 非模态显示
            // 或者用 form2.ShowDialog(); // 模态显示，阻塞当前窗口
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); // 非模态显示
            // 或者用 form2.ShowDialog(); // 模态显示，阻塞当前窗口
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDialog.Color;
                }
            }
        }
    }
}
