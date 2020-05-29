using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderEf
{
    public class Order
    {
        [Key]
        public int id { get; set; } //订单id
        public string clientName { get; set; } //客户名称
        public string date { get; set; }
        public string address { get; set; }
        public List<OrderItem> goods { get; set; } //物品列表
        public double value { get; set; } //订单总价值

        public Order(string cN, string Date, string addr)
        {
            //this.id = ID;
            this.clientName = cN;
            this.date = Date;
            this.address = addr;
            this.goods = new List<OrderItem>();
            value = 0;
            foreach (OrderItem item in goods)
            {
                value += item.Value();
            }
        }

        public override string ToString()
        {
            string temStr = this.id.ToString() + "\r\n"
                + this.clientName + "\r\n"
                + this.date + "\r\n"
                + this.address;
            foreach (OrderItem i in goods)
            {
                temStr += i.ToString();
            }
            return temStr;
        }
    }
}
