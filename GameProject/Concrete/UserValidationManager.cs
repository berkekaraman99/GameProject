using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Berke" && gamer.LastName == "Karaman" && gamer.BirthYear == "1999" && gamer.NationallityId == "12341207438")
            {
                return true;
            }
            else if (gamer.FirstName == "Yusuf" && gamer.LastName == "Yazıcı" && gamer.BirthYear == "2000" && gamer.NationallityId == "23049583623")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
