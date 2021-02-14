using GameSellDemo.Abstract;
using GameSellDemo.Concrete;
using GameSellDemo.Entity;
using System;

namespace GameSellDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Müşteri Kaydı

            Customer customer1 = new Customer()
            {
                Id = 1,
                FirstName = "Berkay",
                LastName = "İnaç",
                DateofBirth = new DateTime(2000, 05, 04),
                NationalityId = "1234567890"
            };

            Customer customer2 = new Customer()
            {
                Id = 2,
                FirstName = "Kutay",
                LastName = "İnaç",
                NationalityId = "1023456789",
                DateofBirth = new DateTime(1994, 05, 03)
            };

            ICustomerCheckService customerCheckManager = new CustomerCheckManager();
            ICustomerService customerManager = new CustomerManager(customerCheckManager);

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Update(customer2);
            customerManager.Delete(customer1);


            // Kampanya Girişi

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "Hoşgeldin Kampanyası",
                CampaignType = "Tek Kullanımlık Kampanya"
            };

            Campaign campaign2 = new Campaign()
            {
                Id = 2,
                CampaignName = "Aldığının yarısı bedava kampanyası",
                CampaignType = "Tek Kullanımlık Kampanya"
            };


            ICampaignService campaignManager = new CampaignManager();
            campaignManager.CampaignAdd(campaign1);
            campaignManager.CampaignAdd(campaign2);
            campaignManager.CampaignUpdate(campaign2);
            campaignManager.CampaignDelete(campaign1);



            // Oyun Satışı
            Product product1 = new Product()
            {
                Id = 1,
                ProductName = "Platinum paket",
                Price = 100
            };

            Product product2 = new Product()
            {
                Id = 1,
                ProductName = "Altın paket",
                Price = 50
            };

            ISellService sellManager = new SellManager();
            sellManager.Sell(customer2, product1, campaign2);
            sellManager.Sell(customer1, product2, campaign1);

            Console.ReadLine();
        }
    }
}
