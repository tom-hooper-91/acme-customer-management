using System;
namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            //Create instance of the Order class
            //Pass in the requested Id

            Order order = new Order(orderId);

            //code that retrieves a single Order

            //temporary hard coded value to return a populated Order

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        public bool Save()
        {
            //code that saves the defined Order
            return true;
        }
    }
}
