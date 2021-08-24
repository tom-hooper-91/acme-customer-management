using System;
namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            //Create instance of the Product class
            //Pass in the requested Id

            Product product = new Product(productId);

            //code that retrieves a single Product

            //temporary hard coded value to return a populated Product

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.Description = "Assorted size bunch of 4 yellow Sunflowers";
                product.CurrentPrice = 16.96M;
                
            }

            return product;
        }

        public bool Save()
        {
            //code that saves the defined Product
            return true;
        }
    }
}
