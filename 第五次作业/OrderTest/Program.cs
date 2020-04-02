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

        public Order(){}

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
            foreach(OrderItem i in goods)
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

        public OrderItem(){}

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

        public void modifyOrder(Order o, int id) //修改
        {
            var order = orderList.Where(c => c.id == 2).FirstOrDefault();
            order = o;
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
            using(FileStream fs = new FileStream(filename, FileMode.Create))
            {
                Ex.Serialize(fs, orderList);
            }
        }

        public OrderService[] Import(string filename)
        {
            using(FileStream fs = new FileStream(filename, FileMode.Open))
            {
                OrderService[] ser1 = (OrderService[])Ex.Deserialize(fs);
                return ser1;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            OrderService serve = new OrderService();
            Console.WriteLine("欢迎来到订单管理系统");
            while (true)
            {
                Console.WriteLine("请选择操作类型：");
                Console.WriteLine("1.查看所有订单");
                Console.WriteLine("2.添加订单");
                Console.WriteLine("3.修改订单");
                Console.WriteLine("4.删除订单");
                Console.WriteLine("5.退出");
                int c = int.Parse(Console.ReadLine());
                //Console.WriteLine($"{c}");
                switch (c)
                {
                    case 1:
                        if (serve.orderList != null && serve.orderList.Count > 0)
                        {
                            foreach (Order o in serve.orderList)
                            {
                                Console.WriteLine(o.ToString());
                            }
                        }
                        else Console.WriteLine("当前没有订单");
                        break;
                    case 2:
                        Console.WriteLine("请遵循提示输入订单信息：");
                        try
                        {
                            Console.WriteLine("订单号：");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("客户名字：");
                            string cName = Console.ReadLine();
                            Console.WriteLine("地址：");
                            string ad = Console.ReadLine();
                            Order newOrder_1 = new Order(id, cName, DateTime.Now, ad);
                            serve.addOrder(newOrder_1);
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("请输入订单id：");
                            int Id = int.Parse(Console.ReadLine());
                            var id2Order = serve.orderList.Where(x => x.id == Id).FirstOrDefault();
                            if (id2Order != null)
                            {
                                Console.WriteLine("请选择修改内容");
                                Console.WriteLine("1.修改基本订单信息");
                                Console.WriteLine("2.修改商品信息");
                                Console.WriteLine("3.添加商品");
                                Console.WriteLine("4.删除商品");
                                int c_1 = int.Parse(Console.ReadLine());
                                switch (c_1)
                                {
                                    case 1:
                                        Console.WriteLine("请输入新的用户名：");
                                        string newName = Console.ReadLine();
                                        Console.WriteLine("请输入新的地址");
                                        string newAd = Console.ReadLine();

                                        Order newOrder_2 = new Order(Id, newName, DateTime.Now, newAd);
                                        serve.modifyOrder(newOrder_2, Id);
                                        break;

                                    case 2:
                                        Console.WriteLine("请输入货物名；");
                                        string newcName = Console.ReadLine();
                                        Console.WriteLine("请输入货物数量：");
                                        int newcNum = int.Parse(Console.ReadLine());
                                        Console.WriteLine("请输入货物价格：");
                                        int newcPrice = int.Parse(Console.ReadLine());

                                        id2Order.ModifyItem(newcName, newcNum, newcPrice);
                                        break;

                                    case 3:
                                        Console.WriteLine("请输入货物名；");
                                        string newcName_1 = Console.ReadLine();
                                        Console.WriteLine("请输入货物数量：");
                                        int newcNum_1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("请输入货物价格：");
                                        int newcPrice_1 = int.Parse(Console.ReadLine());

                                        id2Order.AddItem(newcName_1, newcNum_1, newcPrice_1);
                                        break;
                                    
                                    case 4:
                                        Console.WriteLine("请输入要删除的商品名：");
                                        string deName = Console.ReadLine();

                                        id2Order.deleteItemByName(deName);
                                        break;

                                    default: break;

                                }

                            }
                            else
                            {
                                Console.WriteLine("没有此单");
                            }

                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                        break;
                    case 4:

                        Console.WriteLine("请输入订单编号：");
                        int newId_1 = int.Parse(Console.ReadLine());
                        serve.deleteOrderById(newId_1);

                        break;
                    case 5:
                        return;
                    case 6:
                        serve.Export("/Users/yee/Desktop/xmltest/test.xml");
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
