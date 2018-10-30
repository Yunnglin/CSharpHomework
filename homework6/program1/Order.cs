using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace program1
{
    [Serializable]
    public class Order
    {//属性大写开头，字段小写开头

        public static string GenerateRandomCode(int length)
        {
            var result = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                var r = new Random(Guid.NewGuid().GetHashCode());
                result.Append(r.Next(0, 10));
            }
            return result.ToString();
        }

        public string OrderNum { set; get; }

        public string ClientName { set; get; }

        public decimal TotalMoney
        {
            get
            {
                decimal totalMoney = OrderDetails
                 .Select(detail => detail.ProductsNum * detail.Price)
                 .Sum();
                return totalMoney;
            }
        }

        public Order() {
            this.OrderNum= DateTime.Now.Year.ToString() + '-'
                    + DateTime.Now.Hour.ToString() + '-'
                    + DateTime.Now.Second.ToString() + '-'
                    + GenerateRandomCode(5);
        }

    
        // [XmlElement(ElementName ="OrderDetails")]
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        public void AddOrderDetails(OrderDetail orderDetails) => this.OrderDetails.Add(orderDetails);//添加条目

        public void RemoveOrderDetails(OrderDetail orderDetails) => this.OrderDetails.Remove(orderDetails);//删除条目

        public void ClearOrderDetails() => OrderDetails.Clear();//清空条目

        public decimal GetTotalMoney()
        {
            decimal totalMoney = OrderDetails
                  .Select(detail => detail.ProductsNum * detail.Price)
                  .Sum();
            return totalMoney;
        }
    }
}
