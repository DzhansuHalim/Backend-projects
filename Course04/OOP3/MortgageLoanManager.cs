using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Payment plan calculated for mortgage loan");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
