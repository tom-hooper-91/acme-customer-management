// BA That using directive wasn't being used so you may as well yeet it :)
using System.Collections.Generic;
using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void The_customer_repository_returns_the_expected_customer() // BA I try to use long (maybe overly long) and really descriptive names for tests
        {
            // BA I use this "arrange - act - assert" comment convention too. Helps me with the structure of my tests.
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
            /* BA Normally you'd only have one assert per test. In this instance though these four asserts are really one 'logical' assert - 
               if you consider them together they're saying "this customer looks as expected". So, all cool.
             */
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.CustomerId, actual.CustomerId);
        }

        [Fact]
        public void Existing_customers_are_retrieved_with_addresses()
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
                    new() // BA In C# (some newish version) and up you don't need to explicitly say what it is you're newing up in some circumstances
                    {
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot Row",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new()
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

            for (var i = 0; i < expected.AddressList.Count; i++) // BA The whol var/explicit type question is a bit of a lifestyle choice question really. Resharper thinks 'var' though so I tend to use var.
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