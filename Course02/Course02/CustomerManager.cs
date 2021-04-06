using System;
using System.Collections.Generic;
using System.Text;

namespace Course02
{
    public class CustomerManager
    {
        public void GetCustomer(Customer[] customers)
        { 
            foreach (var customer in customers)
            {
                Console.WriteLine("- Name: " + customer.Name + "(" + customer.Age + ")");

            }
        }

        public void AddCustomer(Customer customer)
        {
            Console.WriteLine($"\n Added Customer: {customer.Name}({customer.Age}) ");
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine($"\n Deleted Customer: {customer.Name}({customer.Age}) ");
        }

    }
}
