using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Payment plan calculated for personal finance credit");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
