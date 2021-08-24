﻿using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EntityBase
    {
        //constructors
        
        public Customer() : this(0)//invokes the overloaded constructor
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        //properties

        public int CustomerId{// can only be set internally within the class
            get;
            private set;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerType { get; set; }

        public List<Address> AddressList { get; set; }

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

        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString() => FullName;
    }
}
