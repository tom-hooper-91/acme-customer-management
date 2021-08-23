using System;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId{// can only be set internally within the class
            get;
            private set;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + "," + LastName;
            }
        }
    }
}
