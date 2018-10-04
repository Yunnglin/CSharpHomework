using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    static class OrderService
    {//添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
     //在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
        public static List<Order> orders;//储存订单

        public static void AddOrder(Order order) => orders.Add(order);//添加订单

        public static void RemoveOrder(Order order) => orders.Remove(order);//删除订单

        public static void RemoveAllOrders() => orders.Clear();//清空订单

        public static void DisplayAllOrders()//显示所有订单信息
        {
            foreach (var order in orders)
            {
                Console.WriteLine("OrderNumber: " + order.OrderNum);
                Console.WriteLine("Client Name: " + order.ClientName);
                foreach (var od in order.orderDetails)
                {
                    Console.WriteLine("Product Brand: " + od.Brand.ToString());
                    Console.WriteLine("Product Number: " + od.ProductsNum);
                    Console.WriteLine("Price per product: " + od.Price);
                    Console.WriteLine("--------------------------");
                }

                Console.WriteLine("===============================");
                Console.WriteLine();
            }
        }

        public static void DisplayOrder(Order order)//显示该订单信息
        {
            Console.WriteLine("OrderNumber: " + order.OrderNum);
            Console.WriteLine("Client Name: " + order.ClientName);
            foreach (var od in order.orderDetails)
            {
                Console.WriteLine("Product Brand: " + od.Brand.ToString());
                Console.WriteLine("Product Number: " + od.ProductsNum);
                Console.WriteLine("Price per product: " + od.Price);
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine("===============================");
            Console.WriteLine();
        }

        public static void FindOrderByOrderNum(string num)//根据订单号查询
        {
            bool exit = false;
            foreach (var order in orders)
            {
                if (string.Equals(num, order.OrderNum))
                {
                    exit = true;
                    DisplayOrder(order);
                }
            }
            if (exit==false)
            {
                Console.WriteLine("Sorry, no such order of this number exits. ");
            }
        }

        public static void FindOrderByClientName(string name)//根据客户名查询
        {
            bool exit = false;
            foreach (var order in orders)
            {
                if (string.Equals(name, order.ClientName))
                {
                    exit = true;
                    DisplayOrder(order);
                }
            }
            if (exit == false)
            {
                Console.WriteLine("Sorry, no such order of this client name exits. ");
            }
        }

        public static void FindOrderByProductBrand(Products brand)//查询包含该产品的订单
        {
            bool exit = false;
            foreach (var order in orders)
            {
                foreach (var od in order.orderDetails)
                {
                    if (brand == od.Brand)
                    {
                        exit = true;
                        DisplayOrder(order);
                    }
                }
               
            }
            if (exit == false)
            {
                Console.WriteLine("Sorry, no such order of this brand exits. ");
            }
        }

        //用for倒序遍历删除
    }
}
