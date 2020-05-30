using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
namespace OrderApi.Models
{
    public class Order
    {
        
        //[Key]
        public int Id { get; set; } //订单id
        public string clientName { get; set; } //客户名称
        public string date { get; set; }
        public string address { get; set; }
        public List<OrderItem> goods { get; set;} //物品列表
        public double value { get; set; } //订单总价值

        public Order() { goods = new List<OrderItem>();}
    }
}