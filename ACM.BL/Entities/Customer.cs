using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL.Entities
{
    public class Customer : EntityBase, ILoggable
    {
        //constructors
        
        public Customer() : this(0)//invokes the overloaded constructor
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        //properties

        public int CustomerId{// can only be set internally within the class
            get;
            // BA I think 'private set;' is implicit in c# (recent version)
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerType { get; set; }

        public List<Address> AddressList { get; set; }

        public static int InstanceCount { get; set; }

        /* BA moving the logic out of Customer means you can keep Customer smaller. I debated whether name-related logic is sufficiently
         specific to customer that it *should* stay in here for a while but eventually decided that it's probably better moved out. Whether
        StringHandler is the right place for it is another question - it's not really to do with strings but with names spefically. */
        public string FullName => StringHandler.FormatPersonsName(FirstName, LastName);

        //methods

        public override bool Validate()
        {
            // BA You could write this method more tersely. It might be *less* readable the way I've written it though.
            return !(string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress));
        }

        public override string ToString() => FullName;

        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState}";
    }
}
