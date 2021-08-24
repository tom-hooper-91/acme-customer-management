using System;
using System.Collections.Generic;
using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                FirstName = "Frodo",
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };

            //act
            var actual = customerRepository.Retrieve(1);

            //assert
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.CustomerId, actual.CustomerId);
        }

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Frodo",
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot Row",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
                }
            };

            //act
            var actual = customerRepository.Retrieve(1);

            //assert
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.CustomerId, actual.CustomerId);

            for (int i = 0; i < expected.AddressList.Count; i++)
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }

        }
    }
}