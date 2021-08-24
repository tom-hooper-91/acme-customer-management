using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Product
    {
        //constructors
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        //properties

        public int ProductId
        {
            get;
            private set;
        }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        //methods

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
