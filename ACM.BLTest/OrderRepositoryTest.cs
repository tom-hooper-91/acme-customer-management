using System;
using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
    public class OrderRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //arrange
            var orderRepository = new OrderRepository();

            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //act
            var actual = orderRepository.Retrieve(10);

            //assert
            Assert.Equal(expected.OrderDate, actual.OrderDate);
        }
    }
}