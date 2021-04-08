using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //business class
    class ApplicationManager
    {
        //Method ijection
        public void MakeAnApplication(ICreditManager credit, List<ILoggerService> loggerServices)
        {
            credit.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
         
        public void MakeCreditPreNotification(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate(); 
            }
        }
    }
}
