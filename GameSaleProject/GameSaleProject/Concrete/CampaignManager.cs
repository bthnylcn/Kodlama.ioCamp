using System;
using System.Collections.Generic;
using System.Text;
using GameSaleProject.Abstract;
using GameSaleProject.Entitites;

namespace GameSaleProject.Concrete
{
        public class CampaignManager : ICampaignService
        {
            public void Add(Campaign campaign)
            {
                Console.WriteLine(campaign.CampaignName + " isimli kampanya eklendi!");
            }

            public void Delete(Campaign campaign)
            {
                Console.WriteLine(campaign.CampaignName + " isimli kampanya silindi!");
            }

            public void Update(Campaign campaign)
            {
                Console.WriteLine(campaign.CampaignName + " isimli kampanya güncellendi!");
            }
        }
    }

