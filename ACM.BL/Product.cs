using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Product : EntityBase
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

        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString() => ProductName;// overiding the base method. This is helpful for debugging as the debugger uses the method to display object name
    }
}
