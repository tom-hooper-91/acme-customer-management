using System;
namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve (int customerId)
        {
            //Create instance of the Customer class
            //Pass in the requested Id

            Customer customer = new Customer(customerId);

            //code that retrieves a single customer

            //temporary hard coded value to return a populated customer

            if (customerId == 1)
            {
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.EmailAddress = "fbaggins@hobbiton.me";
            }

            return customer;
        }

        public bool Save()
        {
            //code that saves the defined customer
            return true;
        }
    }
}
