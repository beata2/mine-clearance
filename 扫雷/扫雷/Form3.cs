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

namespace 扫雷
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            String path1 = System.Windows.Forms.Application.StartupPath;
            Read_txt(path1);
        }

        public void Read_txt(string path1)//读取txt中的内容
        {
            string mr1 = "名字\t成绩\t总雷数\r\n", mystr1 = "";
            FileStream fs1 = File.OpenRead(path1 + "\\英雄榜.txt");
            StreamReader sr1 = new StreamReader(fs1);
            fs1.Seek(0, SeekOrigin.Begin);
            while (sr1.Peek() > -1)
            {
                mystr1 += sr1.ReadLine() + "\t";
                mystr1 += sr1.ReadLine() + "\t";
                mystr1 += sr1.ReadLine() + "\r\n";
            }
            sr1.Close();
            fs1.Close();
            textBox1.Text = mr1 + mystr1;
        }
        private void button1_Click(object sender, EventArgs e)//关闭
        {
            this.Close();
        }

        private void reset_Click(object sender, EventArgs e)//重置按钮
        {
            string path = System.Windows.Forms.Application.StartupPath; // bin路径 
            System.IO.File.WriteAllText(path + "\\英雄榜.txt", string.Empty);
            Read_txt(path);   
        }
    }
}
