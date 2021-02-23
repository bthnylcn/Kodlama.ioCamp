using System;
using System.Collections.Generic;
using GameSaleProject.Concrete;
using GameSaleProject.Entitites;

namespace GameSaleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncu Oluşturma
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Kurt";
            gamer1.LastName = "Cobain";
            gamer1.IdentityNumber = 123123123123;
            gamer1.BirthYear = 1967;

            Gamer gamer2 = new Gamer();
            gamer2.Id = 1;
            gamer2.FirstName = "James";
            gamer2.LastName = "Hetfield";
            gamer2.IdentityNumber = 113123123123;
            gamer2.BirthYear = 1963;

            Gamer[] gamers = new Gamer[] { gamer1, gamer2 };
            
            //Oyuncu Ekleme (Add)
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);

            Console.WriteLine("--------Tüm oyuncular-------");
            foreach (var item in gamers)
            {
                Console.WriteLine(item.FirstName +" "+ item.LastName);

            }
            Console.WriteLine("------------------------------");
            //Oyuncu Silme (Delete)
            gamerManager.Delete(gamer1);
            //Oyuncu Güncelleme (Update)
            gamerManager.Update(gamer1);


            //Oyun Oluşturma
            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Call of Duty: Modern Warfare 2";
            game1.GamePrice = 180;

            //Oyun Ekleme
            GameManager gameManager1 = new GameManager();
            gameManager1.Add(game1);
            //Oyun Silme
            gameManager1.Delete(game1);
            //Oyun Güncelleme
            gameManager1.Update(game1);

            //Kampanya Oluşturma
            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Discount 40";
            campaign1.DiscountRate = 40;

            //Kampanya Ekleme
            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add(campaign1);
            //Kampanya Silme
            campaignManager1.Delete(campaign1);
            //Kampanya Güncelleme
            campaignManager1.Update(campaign1);

            //Satış
            SalesManager salesManager = new SalesManager();
            //Normal Satış
            salesManager.Sales(game1, gamer1);
            //Kampanyalı Satış
            salesManager.CampaignSales(game1, gamer1, campaign1);
        }
    }
}
