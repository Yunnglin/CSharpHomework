using Microsoft.VisualStudio.TestTools.UnitTesting;
using program1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddOrderTest()
        {
         
                Order order = new Order
                {
                    ClientName = "mao",
                    OrderNum = "11223344",
                };
                OrderService orderService = new OrderService();
                orderService.AddOrder(order);

        }

        [TestMethod()]
        public void RemoveOrderTest()
        {

            Order order = new Order
            {
                ClientName = "mao",
                OrderNum = "11223344",
            };
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            orderService.RemoveOrder(order);
            Assert.IsTrue(orderService.Orders.Count == 0);
        }

        [TestMethod()]
        public void RemoveAllOrdersTest()
        {
            Order order1 = new Order
            {
                ClientName = "mao",
                OrderNum = "11223344",
            };
            Order order2 = new Order
            {
                ClientName = "mao",
                OrderNum = "223344",
            };
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.RemoveAllOrders();
            Assert.IsTrue(orderService.Orders.Count == 0);
        }

        [TestMethod()]
        public void DisplayAllOrdersTest()
        {
           
                Order order1 = new Order
                {
                    ClientName = "mao",
                    OrderNum = "11223344",
                };
                Order order2 = new Order
                {
                    ClientName = "mao",
                    OrderNum = "223344",
                };
                OrderService orderService = new OrderService();
                orderService.AddOrder(order1);
                orderService.AddOrder(order2);
                orderService.DisplayAllOrders();

        }

        [TestMethod()]
        public void DisplayOrderTest()
        {

            Order order1 = new Order
            {
                ClientName = "mao",
                OrderNum = "11223344",
            };
            Order order2 = new Order
            {
                ClientName = "mao",
                OrderNum = "223344",
            };
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.DisplayOrder(order1);

            // Assert.Fail(e.Message);

        }

        [TestMethod()]
        public void FindOrderByOrderNumTest()
        {
           
                Order order1 = new Order
                {
                    ClientName = "mao",
                    OrderNum = "11223344",
                };
                Order order2 = new Order
                {
                    ClientName = "mao",
                    OrderNum = "223344",
                };
                OrderService orderService = new OrderService();
                orderService.AddOrder(order1);
                orderService.AddOrder(order2);
                List<Order> list = orderService.FindOrderByOrderNum("11223344");
                Assert.AreEqual(list.Count, 1);
           
        }

        [TestMethod()]
        // [ExpectedException(typeof(AssertFailedException))]
        public void FindOrderByClientNameTest()
        {

            Order order1 = new Order
            {
                ClientName = "mao",
                OrderNum = "11223344",
            };
            Order order2 = new Order
            {
                ClientName = "mao",
                OrderNum = "223344",
            };
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            List<Order> list = orderService.FindOrderByClientName("mao");
            Assert.AreEqual(list.Count, 2);
            foreach (var order in list)
            {
                Assert.AreEqual(order.ClientName, "mao");
            }


        }

        [TestMethod()]
        public void FindOrderByProductBrandTest()
        {

            Order order1 = new Order
            {
                ClientName = "mao",
                OrderNum = "11223344",
            };
            order1.AddOrderDetails(new OrderDetail(Products.Apple, 12, 5000));
            Order order2 = new Order
            {
                ClientName = "mao",
                OrderNum = "223344",
            };
            order2.AddOrderDetails(new OrderDetail(Products.HUAWEI, 10, 2200));
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            List<Order> list = orderService.FindOrderByProductBrand(Products.Apple);
            Assert.AreEqual(list.Count, 1);
            foreach (var order in list)
            {
                foreach (var od in order.OrderDetails)
                {
                    Assert.AreEqual(od.Brand, Products.Apple);
                }

            }
        }

        [TestMethod()]
        public void FindLargeOrderTest()
        {
            Order order1 = new Order
            {
                ClientName = "mao",
                OrderNum = "11223344",
            };
            order1.AddOrderDetails(new OrderDetail(Products.Apple, 12, 5000));
            Order order2 = new Order
            {
                ClientName = "mao",
                OrderNum = "223344",
            };
            order2.AddOrderDetails(new OrderDetail(Products.HUAWEI, 10, 2200));
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            List<Order> list = orderService.FindLargeOrder();
            Assert.AreEqual(list.Count, 2);
            foreach (var order in list)
            {
                Assert.IsTrue(order.GetTotalMoney() > 10000);
            }
        }

        [TestMethod()]
        public void ModifyClientNameTest()
        {

            Order order1 = new Order
            {
                ClientName = "mao",
                OrderNum = "11223344",
            };
            Order order2 = new Order
            {
                ClientName = "mao",
                OrderNum = "223344",
            };
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.ModifyClientName(order1, "yun");
            Assert.AreEqual(order1.ClientName, "yun");
        }

        [TestMethod()]
        public void ExportTest()
        {
            Order order1 = new Order
            {
                ClientName = "mao",
                OrderNum = "11223344",
            };
            order1.AddOrderDetails(new OrderDetail(Products.Apple, 12, 5000));
            Order order2 = new Order
            {
                ClientName = "mao",
                OrderNum = "223344",
            };
            order2.AddOrderDetails(new OrderDetail(Products.HUAWEI, 10, 2200));
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.Export(@"D:\123.xml");
            System.IO.FileInfo file = new System.IO.FileInfo(@"D:\123.xml");
            Assert.IsTrue(file.Exists);
     
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService orderService = OrderService.Import(@"D:\123.xml");
            Assert.AreEqual(orderService.Orders[0].ClientName, "mao");
        }
    }
}