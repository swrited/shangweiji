using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static UserControl1 w1;
        public static UserControl2 w2;


        public Form1()
        {
            InitializeComponent();
            w1 = new UserControl1();
            w1.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(w1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("打印信息到输出窗口");
            w1 = new UserControl1();
            w1.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(w1);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            w2 = new UserControl2();
            w2.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(w2);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
