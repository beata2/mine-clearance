using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 扫雷
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("请输入完整！！", "提示", MessageBoxButtons.OK);
                return;
            }
            int h, w, m;
            h = Convert.ToInt16(textBox1.Text);      
            w = Convert.ToInt16(textBox2.Text);
            m = Convert.ToInt16(textBox3.Text);

            if (m > h * w)
            {
                MessageBox.Show("雷量太大，请重新输入！", "提示", MessageBoxButtons.OK);
                return;
            }
            if (h < 5 || h > 24 || w < 5 || w > 40 || m < 5 || m > 668)
            {
                MessageBox.Show("系统错误,请按要求填写！", "提示", MessageBoxButtons.OK);
                return;
            }

            扫雷.Form1.zdyXNum = w;
            扫雷.Form1.zdyYNum = h;
            扫雷.Form1.zdyMineNum = m;

            this.Close();
            DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;

        }
    }
}
