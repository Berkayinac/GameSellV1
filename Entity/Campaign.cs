using GameSellDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Entity
{
    class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string CampaignType { get; set; }
    }
}
