using System;
using System.Collections.Generic;
using System.Text;
using GameSaleProject.Abstract;
using GameSaleProject.Entitites;

namespace GameSaleProject.Concrete
{
        public class UserValidationManager : IUserValidationService
        {
            public bool CheckIfRealPerson(Gamer Gamer)
            {
                return true;
            }
        }
    
}
