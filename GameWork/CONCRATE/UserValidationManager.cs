using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1994 && gamer.FirstName=="EMRE" && gamer.LastName=="YILMAZ" 
                && gamer.IdentityNumber==123456)
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
