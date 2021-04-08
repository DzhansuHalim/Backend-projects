using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
