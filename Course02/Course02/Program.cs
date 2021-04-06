using System;

namespace Course02
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Tomy";
            customer1.Age = 22;
            customer1.Email = "tomy@gmail.com";

            Customer customer2 = new Customer();
            customer2.Name = "Coni";
            customer2.Age = 30;
            customer2.Email = "coni@gmail.com";

            Customer customer3 = new Customer();
            customer3.Name = "Derik";
            customer3.Age = 28;
            customer3.Email = "derik@gmail.com";

            Customer[] customers = new Customer[] { customer1, customer2};
            CustomerManager customerManager = new CustomerManager();
             
            Console.WriteLine("=== The customer accounts ===");
            customerManager.GetCustomer(customers);
            customerManager.AddCustomer(customer3);
            customerManager.DeleteCustomer(customer1);

        }
    }
}
