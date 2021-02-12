using GameProject.Entities;
using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager
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
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncu eklendi.");
            }
            else
            {
                Console.WriteLine("Oyuncu doğrulanamadı. Kayıt başarısız oldu.");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncunun bilgileri güncellendi.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncunun bilgileri silindi.");
        }
    }
}
