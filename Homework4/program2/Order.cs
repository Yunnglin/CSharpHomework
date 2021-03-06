﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Order
    {//属性大写开头，字段小写开头
        public string OrderNum { set; get; }
        public string ClientName { set; get; }

        public List<OrderDetails> orderDetails;//一个订单包含多个订单信息，存储

        public void AddOrderDetails(OrderDetails orderDetails) => this.orderDetails.Add(orderDetails);//添加条目

        public void RemoveOrderDetails(OrderDetails orderDetails) => this.orderDetails.Remove(orderDetails);//删除条目

        public void ClearOrderDetails() =>orderDetails.Clear();//清空条目
    }
}
