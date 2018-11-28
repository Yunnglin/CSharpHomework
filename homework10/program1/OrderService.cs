using System;
using System.Collections.Generic;
using System.IO;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;


namespace program1

{   [Serializable]
//添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
   public class OrderService
    {

        public void AddOrder(Order order) {//添加订单
            using(var db=new DataBase())
            {
               db.Orders.Add(order);
                db.SaveChanges();
            }
          
        }

        public void RemoveOrder(string orderNum)//删除订单
        {
            using (var db = new DataBase())
            {
                var order = db.Orders.Include("OrderDetails").SingleOrDefault(o => o.OrderNum == orderNum);
                db.OrderDetails.RemoveRange(order.OrderDetails);
                db.Orders.Remove(order);
            }

        }

        public void Update(Order order)//增添订单详情
        {
            using (var db = new DataBase())
            {
                db.Orders.Attach(order);
                db.Entry(order).State = EntityState.Modified;
                order.OrderDetails.ForEach(
                    od => db.Entry(od).State = EntityState.Modified);
                db.SaveChanges();
            }
        }

        public Order GetOrder(String Id)//返回订单
        {
            using (var db = new DataBase())
            {
                return db.Orders.Include("OrderDetails"). SingleOrDefault(o => o.OrderNum == Id);
            }
        }

        public List<Order> GetAllOrders()//返回所有订单
        {
            using (var db = new DataBase())
            {
                return db.Orders.Include("OrderDetails").ToList<Order>();
            }
        }

        public List<Order> FindOrderByClientName(string name)//根据客户名查询，显示订单内容
        {
            using (var db = new DataBase())
            {
                return db.Orders.Include("OrderDetails")
                  .Where(o => o.ClientName.Equals(name)).ToList<Order>();
            }
        }

        public List<Order> FindOrderByProductBrand(Products brand)//查询包含该产品的订单，显示订单内容
        {
            using (var db = new DataBase())
            {
                var query = db.Orders.Include("OrderDetails")
                     .Where(o => o.OrderDetails.Where(
            od => od.Brand.Equals(brand)).Count() > 0);
                return query.ToList();
            }
        }

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

            return orderService;
        }

        public void xslT(string path)
        {
            //注意层级之间的关系
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path+".xml");

                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();

                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(path+".xslt");

                FileStream outFileStream = File.OpenWrite(path + ".html");
                XmlTextWriter writer = new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                xt.Transform(nav, null, writer);


            }
            catch (XmlException e)
            {
                Console.WriteLine("XML Exception:" + e.ToString());
            }
            catch (XsltException e)
            {
                Console.WriteLine("XSLT Exception:" + e.ToString());
            }
        }

        public static string ConvertXML(XmlDocument InputXMLDocument, string XSLTFilePath, XsltArgumentList XSLTArgs)
        {
            System.IO.StringWriter sw = new System.IO.StringWriter();
            XslCompiledTransform xslTrans = new XslCompiledTransform();
            xslTrans.Load(XSLTFilePath);
            xslTrans.Transform(InputXMLDocument.CreateNavigator(), XSLTArgs, sw);
            return sw.ToString();
        }
    }
}
