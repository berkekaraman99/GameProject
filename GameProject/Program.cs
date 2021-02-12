using System;
using GameProject.Entities;
using GameProject.Concrete;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncular oluşturulur
            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer() { Id = 1, FirstName = "Berke", LastName = "Karaman", BirthYear = "1999", NationallityId = "12341207438" };
            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            Gamer gamer2 = new Gamer() { Id = 2, FirstName = "Yusuf", LastName = "Yazıcı", BirthYear = "2000", NationallityId = "23049583623" };

            //Oyuncular eklenir
            gamerManager1.Add(gamer1);
            gamerManager2.Add(gamer2);
            Console.WriteLine("---------------------------------------");

            //Oyunlar oluşturulur ve eklenir
            GameManager gameManager = new GameManager();
            Game game1 = new Game() { Id = 1, GameName = "GTA V", GamePrice = 77.0 };
            gameManager.Add(game1);
            Game game2 = new Game() { Id = 2, GameName = "Minecraft : Bedrock Edition", GamePrice = 85.0 };
            gameManager.Add(game2);
            Game game3 = new Game() { Id = 3, GameName = "PUBG", GamePrice = 43.50 };
            gameManager.Add(game3);
            Console.WriteLine("---------------------------------------");

            //Kampanyalar oluşturulur ve eklenir
            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign() { Id = 1, CampaignName = "EVDE KAL!", CampaignEndDate = "31.12.2021" };
            Campaign campaign2 = new Campaign() { Id = 2, CampaignName = "Yeni Başlangıç", CampaignEndDate = "28.02.2021" };
            Campaign campaign3 = new Campaign() { Id = 3, CampaignName = "Efsane Günler", CampaignEndDate = "15.02.2021" };
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Add(campaign3);
            Console.WriteLine("---------------------------------------");

            //Kampanya başlatılır
            campaignManager.Start(campaign1);
            campaignManager.Update(campaign1);
            Console.Write("\n");

            //SalesManager oluşturulur ve satış yapılır
            SalesManager salesManager = new SalesManager();
            salesManager.CampaignSale(game2, gamer1, campaign1);
            salesManager.CampaignSale(game1, gamer2, campaign1);
            salesManager.NormalSale(game3, gamer2);
            Console.WriteLine("---------------------------------------");

            //Kampanya sona erdirilir
            campaignManager.End(campaign1);
            campaignManager.Delete(campaign1);
        }
    }
}
