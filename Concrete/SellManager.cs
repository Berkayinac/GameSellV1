using GameSellDemo.Abstract;
using GameSellDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Concrete
{
    class SellManager : ISellService
    {
        public void Sell(Customer customer, Product product, Campaign campaign)
        {
            Console.WriteLine("Satın Alan kişinin ismi: " + customer.FirstName + ", " + "Kullandığı Kampanya:" + campaign.CampaignName + ", " + "Satın Alınan Ürünün Adı:" + product.ProductName);
        }
    }
}
