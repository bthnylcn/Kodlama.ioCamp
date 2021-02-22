using System;
using System.Collections.Generic;
using System.Text;
using GameSaleProject.Entitites;

namespace GameSaleProject.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
