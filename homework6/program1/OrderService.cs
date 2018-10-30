using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace program1

{   [Serializable]
//添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
   public class OrderService
    {
     // [XmlElement(ElementName ="OrderService")]
        public List<Order> Orders { get; set; } = new List<Order>();

        public void AddOrder(Order order) {

            Orders.Add(order);
        }//添加订单

        public void RemoveOrder(Order order) => Orders.Remove(order);//删除订单
       
        public  void RemoveAllOrders() => Orders.Clear();//清空订单

        public void DisplayAllOrders()//显示所有订单信息
        {
            foreach (var order in Orders)
            {
                Console.WriteLine("OrderNumber: " + order.OrderNum);
                Console.WriteLine("Client Name: " + order.ClientName);
                Console.WriteLine("===============================");

                foreach (var od in order.OrderDetails)
                {
                    Console.WriteLine("Product Brand: " + od.Brand.ToString());
                    Console.WriteLine("Product Number: " + od.ProductsNum);
                    Console.WriteLine("Price per product: " + od.Price);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine();
                }
            }
        }

        public  void DisplayOrder(Order order)//显示该订单信息
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

                foreach (var od in order.OrderDetails)
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

        public  List<Order> FindOrderByOrderNum(string num)//根据订单号查询,返回订单对象
        {
            var query = from order in Orders
                        where order.OrderNum.Equals(num)
                        select order;
            if (query.Count() == 0)
            {
                throw new DataException("Sorry, no such order of this number exists. ");
            }
            foreach (var order in query)
            {
                DisplayOrder(order);
            }
            return query.ToList();
        }

        public List<Order> FindOrderByClientName(string name)//根据客户名查询，显示订单内容
        {
            var query = from order in Orders
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
            return query.ToList();
        }

        public List<Order> FindOrderByProductBrand(Products brand)//查询包含该产品的订单，显示订单内容
        {
            //var query = from order in orders
            //            where
            //           ( from od in order.orderDetails//嵌套查询
            //             where od.Brand == brand
            //             select od.Brand).Contains(brand)
            //            select order;

            var query = Orders
                .Where(order => order.OrderDetails
                    .Where(od => od.Brand == brand)
                    .Select(od => od.Brand).Contains(brand))
                .Select(orders => orders);

            if (query.Count() == 0)
            {
                throw new DataException("Sorry, no such order of this brand exists. ");
            }
            foreach (var order in query)
            {
                DisplayOrder(order);
            }
            return query.ToList();
        }

        public List<Order> FindLargeOrder()//查询订单金额大于10000的订单
        {
            var query = Orders
                .Where(order => order.GetTotalMoney() >= 10000)
                .Select(order => order);

            if (query.Count() == 0)
            {
                throw new DataException("Sorry, no such order of this amount exists. ");
            }
            foreach (var order in query)
            {
                DisplayOrder(order);
            }
            return query.ToList();
        }

        public void ModifyClientName(Order order, string name)//修改订单客户名
        {
            try
            {
                if (order == null)
                {
                    throw new DataException("No such order exists");
                }

                order.ClientName = name;

            }
            catch (DataException e)
            {
                Console.WriteLine("Sorry, " + e.Message);
            }
        }

        // 1、在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。
        //2、为OrderService类的各个Public方法，编写测试用例，使用合法和非法的输出数据进行测试。

        public OrderService() { }//反序列化需要无参的构造函数
        
        public void Export(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderService));
            string xmlFileName = path;

            FileStream fs = new FileStream(xmlFileName, FileMode.Create);//输出到文件
            xmlSerializer.Serialize(fs, this);
            fs.Close();

            StringWriter sw = new StringWriter();//输出到控制台
            xmlSerializer.Serialize(sw, this);
            sw.Close();

            Console.Write(sw.ToString());
        }

        public static OrderService Import(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderService));
            OrderService orderService = (OrderService)xmlSerializer.Deserialize(file);
            file.Close();

            Console.WriteLine("Import: ");
            orderService.DisplayAllOrders();

            return orderService;
        }
    }
}
