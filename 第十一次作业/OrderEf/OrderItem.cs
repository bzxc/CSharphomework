using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderEf
{
    public class OrderItem
    {
        [Key]
        public int id { get; set; }
        public string cargo { get; set; } //货物名称
        public int num { get; set; } //货物数量
        public double price { get; set; } //货物价格
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public override string ToString()
        {
            return "name: " + cargo.ToString() + "\r\n"
                + "num: " + num.ToString() + "\r\n"
                + "price: " + price.ToString() + "\r\n";

        }

        public double Value()
        {
            return num * price;
        }
    }
}
