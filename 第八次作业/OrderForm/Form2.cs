using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class Form2 : Form
    {
        public delegate void SendDataInvoke(string changeid, string id, string name, string address);
        public event SendDataInvoke SendData;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addSure_Click(object sender, EventArgs e)
        {
            SendData(textBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text);
            this.Close();
        }

        
    }
}
