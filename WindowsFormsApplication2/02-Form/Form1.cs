using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        SerialPort sp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 打开文件_Click(object sender, EventArgs e)
        {
            var ofd = _03_Function.Function.openFile();
         /*   if (ofd.ShowDialog() == DialogResult.OK)
            {
                File.Copy(ofd.FileName, AppDomain.CurrentDomain.BaseDirectory + "\\a.txt");// 复制到exe目录下

            }*/
            ofd.ShowDialog();
            filename.Text = ofd.FileName.ToString();
            try
            {
                flowLayoutPanel1.BackgroundImage = Image.FromFile(ofd.FileName.ToString());
            }catch(Exception ecp){
              
                MessageBox.Show(ecp.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void filename_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!"".Equals(comboBox5.Text))
            {
                sp = new SerialPort();
                sp.BaudRate =int.Parse(comboBox1.Text);
                MessageBox.Show(comboBox1.Text);
                sp.PortName=comboBox5.Text;
                MessageBox.Show(comboBox5.Text);
                string[] str = SerialPort.GetPortNames();
                //     for(int i=0;i<str.Length;i++)
                //  MessageBox.Show(str.GetValue(i).ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tiparea_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox5_MouseClick(object sender, MouseEventArgs e)
        {
            this.comboBox5.Items.Clear();
            this.comboBox5.Items.AddRange(SerialPort.GetPortNames());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
