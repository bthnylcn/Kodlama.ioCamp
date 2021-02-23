using System;
using System.Collections.Generic;
using System.Text;
using GameSaleProject.Abstract;
using GameSaleProject.Entitites;

namespace GameSaleProject.Concrete
{
        public class UserValidationManager : IUserValidationService
        {
             public bool Validate(Gamer gamer)
             {
                 if(gamer.BirthYear==1967 && gamer.FirstName=="Kurt"&&
                gamer.LastName=="Cobain" && gamer.IdentityNumber== 123123123123)
            { return true;
            }
            else
            {
                return false;
            }
             }
    }
    
}
