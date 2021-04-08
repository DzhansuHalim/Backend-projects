using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Payment plan calculated for transport credit");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
