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

        [Fact]
        public void SaveTestValid()
        {
            //arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                Description = "A bunch of 4 bright yellow sunflowers",
                ProductName = "Sunflowers",
                HasChanged = true
            };

            //act
            var actual = productRepository.Save(updatedProduct);

            //assert
            Assert.True(actual);
        }

        [Fact]
        public void SaveTestMissingPrice()
        {
            //arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                Description = "A bunch of 4 bright yellow sunflowers",
                ProductName = "Sunflowers",
                HasChanged = true
            };

            //act
            var actual = productRepository.Save(updatedProduct);

            //assert
            Assert.False(actual);
        }
    }
}