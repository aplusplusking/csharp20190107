using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Thread t1 = new Thread(() => GetNum(textBox1));t1.Start();
            Thread t2 = new Thread(() => GetNum(textBox2)); t2.Start();
            Thread t3 = new Thread(() => GetNum(textBox3)); t3.Start();
            Thread t4 = new Thread(() => GetNum(textBox4)); t4.Start();
            Thread t5 = new Thread(() => GetNum(textBox5)); t5.Start();
            Thread t6 = new Thread(() => GetNum(textBox6)); t6.Start();
        }
        Random r = new Random();
        private void GetNum(TextBox t)
        {
            int n = r.Next(1, 46);
            t.Text = n.ToString();
        }
    }
    
}
