using GameSellDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Abstract
{
    interface ISellService
    {
        void Sell(Customer customer, Product sell, Campaign campaign);
    }
}
