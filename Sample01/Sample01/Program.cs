using System;

namespace Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables --------------------------------------------------------------------------------------------
            string shopName = "Carrefour";
            int numberProducts = 10;
            string completeProducts;
            Console.WriteLine($"Welcome to {shopName}.There are {numberProducts} products available in your shopping cart.");


            Product product1 = new Product();
            product1.ProductName = "bread";
            product1.ProductNumber = 2;


            Product product2 = new Product();
            product2.ProductName = "apple juice";
            product2.ProductNumber = 8;

            //Array of products ---------------------------------------------------------------------------------------
            Product[] products = new Product[] { product1, product2 };

            //Loops: Ways to display the items from the list ----------------------------------------------------------
            Console.WriteLine("\n === For Loop ===");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"- {products[i].ProductName}: {products[i].ProductNumber}");
            }

            Console.WriteLine("\n === While Loop ===");
            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine($"- {products[j].ProductName}: {products[j].ProductNumber}");
                j++;
            }

            Console.WriteLine("\n === Foreach Loop ===");
            foreach (var product in products)
            {
                Console.WriteLine($"- {product.ProductName}: {product.ProductNumber}");
            }

            Console.WriteLine("\n Are the products complete? (y/n)");
            completeProducts = Console.ReadLine();

            //Condition statement -------------------------------------------------------------------------------------
            if (completeProducts == "y" || completeProducts == "Y")
            {
                Console.WriteLine("\n Thank you very much. Have a nice day! :)");
            }
            else
            {
                Console.WriteLine("\n Oeps, we are going to look for a solution :(");
            }

        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public int ProductNumber { get; set; }
    }
}
