using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void First_name_and_last_name_are_concatenated_in_reverse_order_separated_by_a_comma()
        {
            //arrange
            var customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            var expected = "Baggins, Bilbo";
            //act
            var actual = customer.FullName;
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void If_there_is_no_first_name_only_the_last_name_is_returned_in_FullName()
        {
            //arrange
            var customer = new Customer
            {
                LastName = "Baggins"
            };

            var expected = "Baggins";
            //act
            var actual = customer.FullName;
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
            c1.FirstName = "Frodo"; // BA Should this be c2.FirstName? Actually, if this is a test that the InstanceCount gets incremented correctly, do we need to be doing anything with names in this test?
            Customer.InstanceCount++;

            var c3 = new Customer();
            c1.FirstName = "Rosie";
            Customer.InstanceCount++;
            //act
            //assert
            Assert.Equal(3, Customer.InstanceCount);
        }

        [Fact]
        public void ValidateValid()
        {
            //arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = true;
            //act
            var actual = customer.Validate();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingLastName()
        {
            //arrange
            var customer = new Customer
            { 
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = false;
            //act
            var actual = customer.Validate();
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
