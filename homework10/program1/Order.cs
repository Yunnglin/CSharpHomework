using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace program1
{
    [Serializable]
    public class Order
    {//属性大写开头，字段小写开头
        [Key]
        public string OrderNum { set; get; }

        public string ClientName { set; get; }

        public string PhoneNum { set; get; }
      
        public decimal TotalMoney
        {
            set
            {

            }
            get
            {
                decimal totalMoney = OrderDetails
                 .Select(detail => detail.ProductsNum * detail.Price)
                 .Sum();
                return totalMoney;
            }
        }

        public Order() {
           OrderDetails = new List<OrderDetail>();
        }

        public Order(string customer, string phoneNum,List<OrderDetail> items)
        {
            OrderNum = DateTime.Now.Year.ToString() + '-'
                  + DateTime.Now.Month.ToString() + '-'
                  + DateTime.Now.Day.ToString() + '-'
                  + GenerateRandomCode(3);
            ClientName = customer;
            OrderDetails = items;
            PhoneNum = phoneNum;
        }

        // [XmlElement(ElementName ="OrderDetails")]
        public List<OrderDetail> OrderDetails { get; set; } 

  
        public decimal GetTotalMoney()
        {
            decimal totalMoney = OrderDetails
                  .Select(detail => detail.ProductsNum * detail.Price)
                  .Sum();
            return totalMoney;
        }

        public string GenerateRandomCode(int length)
        {
            var result = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                var r = new Random(Guid.NewGuid().GetHashCode());
                result.Append(r.Next(0, 10));
            }
            return result.ToString();
        }
    }
}
