using System;
using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Bilbo";
            //act
            string actual = customer.FullName;
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };

            string expected = "Baggins";
            //act
            string actual = customer.FullName;
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            //arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };

            string expected = "Bilbo";
            //act
            string actual = customer.FullName;
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            //arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount++;

            var c2 = new Customer();
            c1.FirstName = "Frodo";
            Customer.InstanceCount++;

            var c3 = new Customer();
            c1.FirstName = "Rosie";
            Customer.InstanceCount++;
            //act
            //assert
            Assert.Equal(3, Customer.InstanceCount);
        }
    }
}
