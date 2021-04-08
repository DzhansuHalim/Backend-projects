using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class UserValidateManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.Id == 1 && gamer.Name == "Coni" && gamer.IdentityNo == 1234 && gamer.BirthYear == 1980)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
