using System;
using System.Collections.Generic;
using System.Text;
using GameSaleProject.Entitites;

namespace GameSaleProject.Abstract
{
    public interface ISalesService
    {
        void Sales(Game game, Gamer gamer);
        void CampaignSales(Game game, Gamer gamer, Campaign campaign);
    }
}
