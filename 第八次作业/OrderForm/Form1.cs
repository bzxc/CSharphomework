using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderTest;

namespace OrderForm
{
    public partial class Form1 : Form
    {
        OrderService orderS;

        public Form1()
        {
            InitializeComponent();
            orderS = new OrderService();
            Order orderTem = new Order(1, "M", DateTime.Now, "a city");
            orderTem.AddItem("test1", 4, 20);
            orderS.addOrder(orderTem);
            orderTem = new Order(2, "S", DateTime.Now, "b city");
            orderTem.AddItem("test2", 5, 20);
            orderS.addOrder(orderTem);
            orderbindingSource.DataSource = orderS.orderList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void orderbindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.SendData += new Form2.SendDataInvoke(frm_sendAdd);

            f2.Show();
            //this.Hide();
        }

        private void frm_sendAdd(string value0, string value1, string value2, string value3)
        {
            int temId = int.Parse(value1);
            orderbindingSource.Add(new Order(temId, value1, DateTime.Now, value3));
        }

        private void modifyOrder_Click(object sender, EventArgs e)
        {
            Form2 f3 = new Form2();
            f3.SendData += new Form2.SendDataInvoke(frm_sendmodify);

            f3.Show();
            //this.Hide();
        }

        private void frm_sendmodify(string value0, string value1, string value2, string value3)
        {
            int temId = int.Parse(value1);
            int temchangeid = int.Parse(value0);
            orderS.modifyOrder(new Order(temId, value1, DateTime.Now, value3), temchangeid);
            updateSource();
        }

        private void updateSource()
        {
            orderbindingSource.DataSource = orderS.orderList;
            orderbindingSource.ResetBindings(false);
        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            Form2 f4 = new Form2();
            f4.SendData += new Form2.SendDataInvoke(frm_senddelete);
            f4.Show();
            //this.Hide();
        }

        private void frm_senddelete(string value0, string value1, string value2, string value3)
        {
            int deId = int.Parse(value0);
            orderS.deleteOrderById(deId);
            updateSource();
        }

    }
}
