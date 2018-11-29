using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
//在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
//提示：需要写Order（订单）、OrderDetails（订单明细），OrderService（订单服务）几个类，
//订单数据可以保存在OrderService中一个List中
//一个订单会包括多个条目，每个条目是一种商品及其数量和价格
//订单明细就是一个条目


namespace program1
{
    class Client
    {
        static void Main(string[] args)
        {

            #region //示例（订单明细）条目，四个测试条目
            //OrderDetails od1 = new OrderDetails
            //{
            //    Brand = Products.Apple,
            //    ProductsNum = 2,
            //    Price=8800,
            //};
            //OrderDetails od2 = new OrderDetails
            //{
            //    Brand = Products.HUAWEI,
            //    ProductsNum = 1,
            //    Price=3200,
            //};
            //OrderDetails od3 = new OrderDetails
            //{
            //    Brand = Products.OPPO,
            //    ProductsNum = 3,
            //    Price=3500,
            //};
            //OrderDetails od4 = new OrderDetails
            //{
            //    Brand = Products.SAMSUNG,
            //    ProductsNum = 2,
            //    Price=3800,
            //};
            #endregion

            #region //示例订单

            List<OrderDetail> od1 = new List<OrderDetail>() {
                 new OrderDetail(Products.Apple, 3, 8800),
           new OrderDetail(Products.HUAWEI, 2, 2800),
        };
            List<OrderDetail> od2 = new List<OrderDetail>() {
               new OrderDetail(Products.OPPO, 1, 3200),
            new OrderDetail(Products.SAMSUNG, 4, 4800),
        };

            List<OrderDetail> od3 = new List<OrderDetail>() {
             new OrderDetail(Products.vivo, 1, 3000),
        };
            List<OrderDetail> od4 = new List<OrderDetail>() {
            new OrderDetail(Products.XIAOMI, 10, 2500)
        };
            Order order1 = new Order("Bob", "+86-10-87654321",od1);

            Order order2 = new Order("Tom", "+86-10-87654321", od2);

            Order order3 = new Order("Alice", "+86-10-87654321",od3);

          Order order4 = new Order("Alex", "+86-10-87654321", od4);
          
            #endregion

            //订单服务,添加了两个订单
            // OrderService.orders = new List<Order>();
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
            orderService.AddOrder(order4);

            //orderService.Export(@"D:\orderService.xml");
            orderService.xslT("D:\\orderService");
          // OrderService os= OrderService.Import(@"D:\orderService.xml");
            //try
            //{
            //    orderService.FindOrderByOrderNum("20181004001");


            //    orderService.FindOrderByClientName("Tom");

            //    orderService.FindOrderByProductBrand(Products.SAMSUNG);

            //    orderService.FindLargeOrder();
            //}
            //catch (DataException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
