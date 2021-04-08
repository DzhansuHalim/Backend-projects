using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("The gamer is added");
            }
            else
            {
                Console.WriteLine("The gamer is not added");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("The gamer is deleted");
        }

        public void Umdate(Gamer gamer)
        {
            Console.WriteLine("The gamer is updated");
        }
    }
}
