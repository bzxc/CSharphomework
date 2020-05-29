using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models
{
    public class OrderItem
    {
        //[Key]
        public int Id { get; set; } //订单id
        
        public string cargo { get; set; } //货物名称
        int num { get; set; } //货物数量
        double price { get; set; } //货物价格
        
        //[ForeignKey("OrderId")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}