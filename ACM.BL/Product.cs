﻿using System;
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
        public int CurrentPrice { get; set; }

        //methods

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice <= 0) isValid = false;

            return isValid;
        }

        public Product Retrieve(int productId)
        {
            //code to locate product
            return new Product();
        }

        public List<Product> Retrieve()
        {
            //code to return all products
            return new List<Product>();
        }

        public bool Save()
        {
            //code to save current product
            return true;
        }
    }
}