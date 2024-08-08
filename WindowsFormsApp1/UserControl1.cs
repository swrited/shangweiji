using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {

        public UserControl1()
        {
            InitializeComponent();
          
            search_port(serialPort1, comboBox1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)//按下确认
        {
            //该测试是将输入的字符转为数字，并且加1测试输出
            string string_kp = null;
            string string_ki = null;
            string string_kd = null;
            float ce_kp = 0;
            float ce_ki = 0;
            float ce_kd = 0;
            string_kp = textBox1.Text;
            string_ki = textBox2.Text;
            string_kd = textBox3.Text;
            System.Diagnostics.Debug.WriteLine(string_kp);
            try
            {
                ce_kp = float.Parse(string_kp) + 1;
                System.Diagnostics.Debug.WriteLine(ce_kp);
                errorProvider1.Clear();

            }
            catch
            {
                errorProvider1.SetError(textBox1, "非法输入");
                System.Diagnostics.Debug.WriteLine("错误输入");
            }
            try
            {
                ce_ki = float.Parse(string_ki) + 1;
                System.Diagnostics.Debug.WriteLine(ce_ki);
                errorProvider2.Clear();

            }
            catch
            {
                errorProvider2.SetError(textBox2, "非法输入");
                System.Diagnostics.Debug.WriteLine("错误输入");
            }
            try
            {
                ce_kd = float.Parse(string_kd) + 1;
                System.Diagnostics.Debug.WriteLine(ce_kd);
                errorProvider3.Clear();
            }
            catch 
            {
                errorProvider3.SetError(textBox3, "非法输入");
                System.Diagnostics.Debug.WriteLine("错误输入");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            search_port(serialPort1, comboBox1);
        }
        private void search_port(SerialPort my_port, ComboBox my_box)
        {
            string[] num_port = new string[20];
            string mid_string;
            my_box.Items.Clear();//清空combobox的内容
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    mid_string = "com" + i.ToString();
                    my_port.PortName = mid_string;
                    my_port.Open();
                    num_port[i - 1] = mid_string;
                    my_box.Items.Add(mid_string);
                    my_port.Close();
                    my_box.Text = num_port[i - 1];
                }
                catch
                { }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "打开串口")
            {
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.Open();
                    button2.Text = "关闭串口";
                    label7.Text = "当前连接状态：已连接";
                    label7.ForeColor = Color.Green;

                }
                catch
                {
                    MessageBox.Show("串口打开错误");
                }

            }
            else if (button2.Text == "关闭串口")
            {
                try
                {
                    serialPort1.Close();
                    button2.Text = "打开串口";
                    label7.Text = "当前连接状态：未连接";
                    label7.ForeColor = Color.Red;

                }
                catch
                { }


            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
