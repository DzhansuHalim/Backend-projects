using System;
using System.Collections.Generic;
using System.Text;

namespace Course04
{
    //inheritance
    class IndividualCustomer : Customer
    {
        public string IdentityNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }  
    }
}
