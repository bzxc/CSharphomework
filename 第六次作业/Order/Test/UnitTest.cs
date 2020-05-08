using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTest;
using System;


namespace Test
{
    public class UnitTest
    {
        [TestClass]
        public class ServiceUnittest
        {
            private readonly OrderService os;

            public ServiceUnittest() 
            {
                os = new OrderService();
            }

            [TestMethod]
            public void AddTest() 
            {
                OrderService os1 = new OrderService();
                Order o = new Order(1, "newName", DateTime.Now, "newAd");
                os1.addOrder(o);
                Assert.AreEqual(os1.orderList[0], o);
            }

            public void modifyTest1()
            {
                Order o = new Order(1, "newName", DateTime.Now, "newAd");
                Order o1 = new Order(2, "newName", DateTime.Now, "newAd");
                os.addOrder(o);
                os.modifyOrder(o1, 1);
                Assert.AreNotEqual(os.orderList[0], o);
            }

            public void ExportTest()
            {
                
            }

        }
        
    }
}
