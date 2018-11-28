using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace program1
{
  public enum Products
    {
        HUAWEI,
        vivo,
        OPPO,
        SAMSUNG,
        Apple,
        XIAOMI
    };
    [Serializable]
    public class OrderDetail//商品明细
    {
        [Key]
        public Products Brand { get; set; }
        public int ProductsNum { get; set; }
        public decimal Price { get; set; }

        public OrderDetail(
            Products brand=Products.HUAWEI,
            int productsNum=1,
            decimal price=2000)
        {
            Brand = brand;
            ProductsNum = productsNum;
            Price = price;
        }

        public OrderDetail() { }
    }
}
