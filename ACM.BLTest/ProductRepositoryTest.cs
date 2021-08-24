using System;
using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //arrange
            var productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                Description = "Assorted size bunch of 4 yellow Sunflowers",
                CurrentPrice = 16.96M
        };

            //act
            var actual = productRepository.Retrieve(2);

            //assert
            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(expected.Description, actual.Description);
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}