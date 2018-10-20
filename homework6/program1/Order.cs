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
        public string OrderNum { set; get; }
        public string ClientName { set; get; }

        public Order() { }

        private List<OrderDetail> orderDetails=new List<OrderDetail>();//一个订单包含多个订单信息，存储
       // [XmlElement(ElementName ="OrderDetails")]
        public List<OrderDetail> OrderDetails
        {
            get { return orderDetails; }
            set { orderDetails = value; }
        }

        public void AddOrderDetails(OrderDetail orderDetails) => this.orderDetails.Add(orderDetails);//添加条目

        public void RemoveOrderDetails(OrderDetail orderDetails) => this.orderDetails.Remove(orderDetails);//删除条目

        public void ClearOrderDetails() =>orderDetails.Clear();//清空条目

        public decimal GetTotalMoney()
        {
            decimal prices = orderDetails
                .Select(detail => detail.ProductsNum * detail.Price)
                .Sum();
            return prices;
        }
    }
}
