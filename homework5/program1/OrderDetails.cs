using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    enum Products
    {
        HUAWEI,
        vivo,
        OPPO,
        SAMSUNG,
        Apple,
        XIAOMI
    };

    class OrderDetails//商品明细
    {
        internal Products Brand { get; set; }
        public int ProductsNum { get; set; }
        public decimal Price { get; set; }

        public OrderDetails(Products brand,int productsNum,decimal price)
        {
            Brand = brand;
            ProductsNum = productsNum;
            Price = price;
        }
    }
}
