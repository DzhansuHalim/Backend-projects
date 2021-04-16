using Business.Abstract;
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
            GetProducts();
            //GetCustomers(); 
            //GetCategories(); 

        }

        private static void GetCategories()
        {
            //GetCategories
            Console.WriteLine("\n ===================== Categories ===================== \n");
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //Console.WriteLine(categoryManager.GetCategoryById(1).CategoryName.ToString());
        }

        private static void GetCustomers()
        {
            Console.WriteLine("\n ===================== Customers ===================== \n");
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //Console.WriteLine(customerManager.GetCustomerById("FOLKO").ContactName.ToString());
        }

        private static void GetProducts()
        {
            Console.WriteLine(" \n ===================== Products ===================== \n");
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            //foreach (var product in productManager.GetByUnitPrice(10, 100))
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
    
        }
    }
}
