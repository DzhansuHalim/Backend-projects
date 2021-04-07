using System;
using System.Collections.Generic;

namespace Course03
{
    class Program
    {

        static void Main(string[] args)
        {
            //Here we are going to use the ref, out and params
            RefOutParamsManager refOutParamsManager = new RefOutParamsManager();
            int number1 = 20;
            int number2 = 100;

            var result = refOutParamsManager.Add(number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);// we have changed the value of number1 in the method, but we see that the value is still 20


            var result2 = refOutParamsManager.AddWithRef (ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);// we see that the value is 30

            var result3 = refOutParamsManager.AddWithOut(out number1, number2);
            Console.WriteLine(result3);
            Console.WriteLine(number1);// we see that the value is 30

            // Differences between ref and out are:
            // - ref: the variable must be declared with value before we use the ref
            // - out: the variable must not be declared before (it can), but should be declared with value in the method

            Console.WriteLine(refOutParamsManager.AddWithParams(1, 3, 6, 8, 9)); // with params you can add items how much you want

            MyList<string> myList = new MyList<string>();
            myList.AddItem("Tony");
            Console.WriteLine(myList.Count);

            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.AddItem("Coni", 23);
            myDictionary.AddItem("Tomy", 40);
            myDictionary.GetItems();
            Console.WriteLine(" Count items: " + myDictionary.Count);

            
        }
    }
}
