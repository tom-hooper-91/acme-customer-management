using System;
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
        public DateTimeOffset? OrderDate { get; set; }

        //methods

        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
