using System;
using System.Collections.Generic;
using System.Text;
using GameSaleProject.Entitites;

namespace GameSaleProject.Abstract
{
    public interface IUserValidationService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
