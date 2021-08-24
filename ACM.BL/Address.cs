﻿using System;
namespace ACM.BL
{
    public class Address
    {
        //constructors
        public Address()
        {
        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        //properties
        public int AddressId{
            get;
            private set;
        }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        //methods

        public bool Validate()
        {
            bool isValid = true;

            if (PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
