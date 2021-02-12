using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager
    {
        public void Add(Campaign campaign )
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya eklenmiştir.");
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya güncellenmiştir.");
        }
        public void Start(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya başlamıştır. Kampanyanın sona erme tarihi: " + campaign.CampaignEndDate);
        }
        public void End(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya sona ermiştir.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya başarıyla silindi.");
        }
    }
}
