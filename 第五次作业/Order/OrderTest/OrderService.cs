using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace OrderTest
{
    public class Order
    {
        public int id; //订单id
        public string clientName; //客户名称
        public DateTime date;
        public string address;
        public List<OrderItem> goods; //物品列表
        public double value; //订单总价值

        public Order() { }

        public Order(int ID, string cN, DateTime Date, string addr)
        {
            this.id = ID;
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

        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return obj != null && o.id == id;
        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public bool AddItem(string cname, int cnum, double cprice) //添加商品
        {
            OrderItem item = new OrderItem(cname, cnum, cprice);
            if (goods.Contains(item))
            {
                return false;
            }

            goods.Add(item);
            value += item.Value();
            return true;
        }

        public bool ModifyItem(string cname, int cnum, double cprice)
        {

            OrderItem item = new OrderItem(cname, cnum, cprice);
            if (!(goods.Contains(item)))
            {
                return false;
            }
            var itemToModify = goods.Where(x => x.Equals(item)).FirstOrDefault();
            itemToModify = item;
            return true;
        }

        public OrderItem deleteItemByName(string name) //删除,返回第一个删除的对象
        {
            var reOrder = goods.Where(x => x.cargo == name).FirstOrDefault();
            goods.RemoveAll(x => x.cargo == name);
            return reOrder;
        }
    }

    public class OrderItem
    {
        public string cargo; //货物名称
        int num; //货物数量
        double price; //货物价格

        public OrderItem() { }

        public OrderItem(string c, int n, double p)
        {
            cargo = c;
            num = n;
            price = p;
        }

        public override bool Equals(object obj)
        {
            OrderItem o = obj as OrderItem;
            return o != null && o.cargo == cargo;
        }

        public override int GetHashCode()
        {
            return this.cargo.GetHashCode();
        }
        public double Value()
        {
            return num * price;
        }

        public override string ToString()
        {
            return "name: " + cargo.ToString() + "\r\n"
                + "num: " + num.ToString() + "\r\n"
                + "price: " + price.ToString() + "\r\n";

        }

    }

    [Serializable]
    public class OrderService
    {
        public List<Order> orderList;
        private static XmlSerializer Ex = new XmlSerializer(typeof(List<Order>));

        public OrderService()
        {
            orderList = new List<Order>();
        }
        public bool addOrder(Order o) //添加
        {
            if (orderList.Contains(o))
            {
                return false;
            }

            orderList.Add(o);
            return true;
        }

        public Order deleteOrderById(int Id) //删除,返回第一个删除的对象
        {
            var reOrder = orderList.Where(x => x.id == Id).FirstOrDefault();
            orderList.RemoveAll(x => x.id == Id);
            return reOrder;
        }

        public bool modifyOrder(Order o, int id) //修改
        {
            var order = orderList.Where(c => c.id == 2).FirstOrDefault();
            if (order != null)
            {
                order = o;
                return true;
            }
            else return false;
            
        }

        static int sortId(Order x, Order y) //按id排序
        {
            if (x.id > y.id) return -1;        //从小到大        
            else if (x.id == y.id) return 0;
            else return 1;
        }
        public IEnumerable<string> enumerableFuc()
        {
            foreach (Order item in this.orderList)
            {
                yield return item.ToString();
            }
        }

        public void Export(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                Ex.Serialize(fs, orderList);
            }
        }

        public OrderService[] Import(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                OrderService[] ser1 = (OrderService[])Ex.Deserialize(fs);
                return ser1;
            }
        }


    }
}
