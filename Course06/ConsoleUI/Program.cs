using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program   
    {
        //SOLID
        //Open Closed Principle
        static void Main(string[] args)
        {

            //GetProducts
            Console.WriteLine(" \n ===================== Products ===================== \n");
            ProductManager productManager = new ProductManager(new InMemoryProductDal ());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }


            ////GetCustomers
            //Console.WriteLine("\n ===================== Customers ===================== \n");
            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //Console.WriteLine(customerManager.GetCustomerById("FOLKO").ContactName.ToString());



            ////GetCategories
            //Console.WriteLine("\n ===================== Categories ===================== \n");
            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //Console.WriteLine(categoryManager.GetCategoryById(1).CategoryName.ToString());


        }
    }
}
