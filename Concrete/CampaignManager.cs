using GameSellDemo.Abstract;
using GameSellDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + " Kampanyası Eklendi.");
        }

        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + " Kampanyası Silindi.");
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "Kampanyası Guncellendi ");
        }
    }
}
