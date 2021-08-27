using System;
using System.Collections.Generic;

namespace ACM.BL.Entities
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
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        //methods

        public bool Validate()
        {
            bool isValid = true;

            if (ProductId <= 0) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
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
