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

          public GamerManager(IUserValidationService userValidationService)
          {
              _userValidationService = userValidationService;
          }   

          public void Add(Gamer gamer)
          {

               if (_userValidationService.Validate(gamer) == true)
               {
                   Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu kayıt edildi." + '\n');
               }
               else
               {
                   Console.WriteLine("Doğru bilgi giriniz.Kayıt başarısız!");
               }
                     
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

