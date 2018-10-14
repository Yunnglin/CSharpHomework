using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    static class OrderService
    {//添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
     //在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
        public static List<Order> orders;//储存订单

        public static void AddOrder(Order order) => orders.Add(order);//添加订单

        public static void RemoveOrder(Order order) {
            order.ClearOrderDetails();
            orders.Remove(order);
        }//删除订单

        public static void RemoveAllOrders() => orders.Clear();//清空订单

        public static void DisplayAllOrders()//显示所有订单信息
        {
            foreach (var order in orders)
            {
                Console.WriteLine("OrderNumber: " + order.OrderNum);
                Console.WriteLine("Client Name: " + order.ClientName);
                Console.WriteLine("===============================");

                foreach (var od in order.orderDetails)
                {
                    Console.WriteLine("Product Brand: " + od.Brand.ToString());
                    Console.WriteLine("Product Number: " + od.ProductsNum);
                    Console.WriteLine("Price per product: " + od.Price);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine();
                }
            }
        }

        public static void DisplayOrder(Order order)//显示该订单信息
        {
            try
            {
                if (order == null)
                {
                    throw new DataException("No such order exists. ");
                }
                Console.WriteLine("OrderNumber: " + order.OrderNum);
                Console.WriteLine("Client Name: " + order.ClientName);
                Console.WriteLine("===============================");

                foreach (var od in order.orderDetails)
                {
                    Console.WriteLine("Product Brand: " + od.Brand.ToString());
                    Console.WriteLine("Product Number: " + od.ProductsNum);
                    Console.WriteLine("Price per product: " + od.Price);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine();
                }
            }
            catch (DataException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public static List<Order> FindOrderByOrderNum(string num)//根据订单号查询,返回订单对象
        {
            var query = from order in orders
                        where order.OrderNum.Equals(num)
                        select order;
            if (query.Count() == 0)
            {
                throw new DataException("Sorry, no such order of this number exists. ");
            }
            foreach(var order in query)
            {
                DisplayOrder(order);
            }
            return query.ToList();
        }

        public static void FindOrderByClientName(string name)//根据客户名查询，显示订单内容
        {
            var query = from order in orders
                        where order.ClientName.Equals(name)
                        select order;
            if (query.Count() == 0)
            {
                throw new DataException("Sorry, no such order of this name exists. ");
            }
            foreach (var order in query)
            {
                DisplayOrder(order);
            }
        }

        public static void FindOrderByProductBrand(Products brand)//查询包含该产品的订单，显示订单内容
        {
            var query = from order in orders
                        where
                       ( from od in order.orderDetails//嵌套查询
                         where od.Brand == brand
                         select od.Brand).Contains(brand)
                        select order;

            if (query.Count() == 0)
            {
                throw new DataException("Sorry, no such order of this brand exists. ");
            }
            foreach (var order in query)
            {
                DisplayOrder(order);
            }
        }
        
        public static void FindLargeOrder()//查询订单金额大于10000的订单
        {
            var query = orders
                .Where(order => order.GetTotalMoney() >= 10000)
                .Select(order=>order);

            if (query.Count() == 0)
            {
                throw new DataException("Sorry, no such order of this amount exists. ");
            }
            foreach (var order in query)
            {
                DisplayOrder(order);
            }
        }
        public static void ModifyClientName(Order order,string name)//修改订单客户名
        {
            try
            {
                if (order == null)
                {
                    throw new DataException("No such order exists");
                }

                order.ClientName = name;

            }
            catch(DataException e)
            {
                Console.WriteLine("Sorry, " + e.Message);
            }
        }

    }
}
