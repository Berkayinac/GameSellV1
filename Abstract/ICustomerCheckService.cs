using GameSellDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Abstract
{
    interface ICustomerCheckService
    {
        bool CheckCustomer(Customer customer);
    }
}
