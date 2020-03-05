using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==String.Empty||textBox2.Text==String.Empty)
            {
                MessageBox.Show("输入禁止为空！", "error");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            else
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "+":label1.Text = (x + y).ToString(); break;
                    case "-": label1.Text = (x - y).ToString(); break;
                    case "*": label1.Text = (x * y).ToString(); break;
                    case "/":
                        if (y != 0)
                        {
                            label1.Text = (x / y).ToString();
                        }
                        else MessageBox.Show("除数不能为0！", "error");
                        break;
                    default: break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("+");
            this.comboBox1.Items.Add("-");
            this.comboBox1.Items.Add("*");
            this.comboBox1.Items.Add("/");

            this.comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            comboBox1.SelectedIndex = 0;
        }
    }
}
