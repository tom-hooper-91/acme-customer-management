﻿using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        //constructors
        public Order()
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        //properties

        public int OrderId{
            get;
            private set;
        }
        public DateTime OrderDate { get; set; }

        //methods

        public bool Validate()
        {
            //code to validate
            return true;
        }

        public Order Retrieve(int orderId)
        {
            //code to locate Order
            return new Order();
        }

        public List<Order> Retrieve()
        {
            //code to return all Orders
            return new List<Order>();
        }

        public bool Save()
        {
            //code to save current Order
            return true;
        }
    }
}