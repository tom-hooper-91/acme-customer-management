using ACM.BL;
using System.Collections.Generic;
using ACM.BL.Entities;
using Acme.Common;
using Xunit;

namespace Acme.CommonTest
{
    public class LoggingServiceTest
    {
        [Fact]
        public void WriteToFileTest()
        {
            //arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                FirstName = "Frodo",
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me",
                AddressList = null
            };

            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                Description = "A garden rake with a steel head",
                CurrentPrice = 6M
            };

            changedItems.Add(product);

            //act
            LoggingService.WriteToFile(changedItems);

            //assert
            //Nothing to assert
        }
    }
}