using System.Collections.Generic;
using ACM.BL.Entities;

namespace ACM.BL.Repositories
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            //Create instance of the Address class
            //Pass in the requested Id

            Address address = new Address(addressId);

            //code that retrieves a single Address

            //temporary hard coded value to return a populated Address

            if (addressId == 1)
            {
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot Row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save()
        {
            //code that saves the defined Address
            return true;
        }
    }
}

