using System;

namespace Course04
{
    class Program
    {
        static void Main(string[] args)
        {
            //First way to create an instance of an object
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "1234";
            customer1.FirstName = "Tony";
            customer1.LastName = "Coni";
            customer1.IdentityNo = "243541";

            //Second way to create an instance of an object
            CoorporateCustomer customer2 = new CoorporateCustomer
            {
                Id = 2,
                CustomerNo = "6754",
                CompanyName = "Golgo",
                TaxNo = "546"
            };

            //The superclass can take the reference number of both subclasses
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
