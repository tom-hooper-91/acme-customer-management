using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        //properties

        public int CustomerId{// can only be set internally within the class
            get;
            private set;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public static int InstanceCount { get; set; }

        public string FullName
        {
            get
            {
                string fullname = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }
        }

        //methods

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public Customer Retrieve(int customerID)
        {
            //code that retrieves specific customer
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            //returns all Customers
            return new List<Customer>();
        }

        public bool Save()
        {
            //code that saves the defined customer
            return true;
        }

    }
}
