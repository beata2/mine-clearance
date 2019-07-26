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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = System.Windows.Forms.Application.StartupPath; // bin路径 
            string name;
            name = textBox1.Text;
            if (name == "")
            {
                this.Close();
                return;
            }
            string mystr = "";//mr = "名字\t成绩\t雷数 \n",
            FileStream fs = File.OpenRead(path + "\\英雄榜.txt");
            StreamReader sr = new StreamReader(fs);
            fs.Seek(0, SeekOrigin.Begin);
            while (sr.Peek() > -1)
            {
                mystr += sr.ReadLine() + "\t\t";
                mystr += sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            mystr += name + "\t" + 扫雷.Form1.CostTime.ToString() + "\t" + 扫雷.Form1.MineNum.ToString() + "\r\n";
            FileStream fsa = File.OpenWrite(path + "\\英雄榜.txt");
            StreamWriter sw = new StreamWriter(fsa);
            sw.WriteLine(mystr);
            sw.Close();
            fsa.Close();
            this.Close();

        }
    }
}
