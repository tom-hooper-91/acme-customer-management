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

            string expected = "Bilbo, Baggins";
            //act
            string actual = customer.FullName;
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
