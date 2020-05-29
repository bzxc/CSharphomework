using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEf
{
    class Program
    {
        static void Main(string[] args)
        {
            try
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
                            if (OrderService.GetAllOrders() != null && OrderService.GetAllOrders().Count > 0)
                            {
                                foreach (Order o in OrderService.GetAllOrders())
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
                               // Console.WriteLine("订单号：");
                                //int id = int.Parse(Console.ReadLine());
                                Console.WriteLine("客户名字：");
                                string cName = Console.ReadLine();
                                Console.WriteLine("地址：");
                                string ad = Console.ReadLine();
                                Console.WriteLine("日期：");
                                string da = Console.ReadLine();
                                Order newOrder_1 = new Order(cName, da, ad);
                                OrderService.addOrder(newOrder_1);
                            }
                            catch (Exception e)
                            {
                                throw e;
                            }
                            break;
                            /*
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
                            break;*/
                        case 4:

                            Console.WriteLine("请输入订单编号：");
                            int newId_1 = int.Parse(Console.ReadLine());
                            OrderService.DeleteOrder(newId_1);

                            break;
                        case 5:
                            return;
                        case 6:
                            //serve.Export("/Users/yee/Desktop/xmltest/test.xml");
                            break;
                        default:
                            break;
                    }

                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
