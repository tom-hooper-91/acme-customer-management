using System;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        //constructors

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        //properties

        private AddressRepository addressRepository { get; set; }

        //methods

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
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanged)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        //call an insert stored procedure
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
