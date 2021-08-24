using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderItem
    {
        //constructors
        public OrderItem()
        {
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        //properties

        public int OrderItemId{
            get;
            private set;
        }
        public Product product { get; set; }
        public int PurchasePrice { get; set; }

        //methods

        public bool Validate()
        {
            //code to validate
            return true;
        }

        public OrderItem Retrieve(int orderItemId)
        {
            //code to locate OrderItem
            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            //code to return all OrderItems
            return new List<OrderItem>();
        }

        public bool Save()
        {
            //code to save current OrderItem
            return true;
        }
    }
}
