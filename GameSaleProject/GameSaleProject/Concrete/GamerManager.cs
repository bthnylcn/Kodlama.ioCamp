using System;
using System.Collections.Generic;
using System.Text;
using GameSaleProject.Abstract;
using GameSaleProject.Entitites;

namespace GameSaleProject.Concrete
{
        public class GamerManager : IGamerService
        {
            IUserValidationService _userValidationService;

            public GamerManager()
            {
                
            }

            public void Add(Gamer gamer)
            {
               
                    Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu kayıt edildi." + '\n');
                
                
            }

            public void Delete(Gamer gamer)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu silindi!" + '\n');
            }

            public void Update(Gamer gamer)
            {
                
                    Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu güncellendi." + '\n');
                
            }
        }
    }

