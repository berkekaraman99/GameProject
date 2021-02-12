using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SalesManager
    {
        public void NormalSale(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncu " + game.GameName + " adlı oyunu satın aldı.");
        }
        public void CampaignSale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncu " + campaign.CampaignName + " adlı kampanyadan yararlanarak " + game.GameName + " adlı oyunu satın aldı.");
        }
        public void Return(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncu " + game.GameName + " adlı oyunu iade etti.");
        }
    }
}
