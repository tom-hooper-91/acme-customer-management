using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
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

        private string productName;
        public string ProductName
        {
            get
            {
                return productName.InsertSpaces();
            }
            set { productName = value; }
        }
        
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

        public string Log() => $"{ProductId}: {ProductName} Detail: {Description} Status: {EntityState.ToString()}";
    }
}
