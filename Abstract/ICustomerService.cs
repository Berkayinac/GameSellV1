using GameSellDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Abstract
{
    interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
