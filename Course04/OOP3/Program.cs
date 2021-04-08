using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            TransportCreditManager transportCreditManager = new TransportCreditManager();
            MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();

            
            ILoggerService databseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
             

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(personalFinanceCreditManager, new List<ILoggerService>() { fileLoggerService, databseLoggerService });



            List<ICreditManager> credits = new List<ICreditManager>() {transportCreditManager, mortgageLoanManager };
            applicationManager.MakeCreditPreNotification(credits); 

        }
    }
}
