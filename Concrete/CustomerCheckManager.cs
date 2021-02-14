using GameSellDemo.Abstract;
using GameSellDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckCustomer(Customer customer)
        {
            if (customer.FirstName == "Berkay" && customer.LastName == "İnaç" && customer.NationalityId == "1234567890" && customer.DateofBirth == new DateTime(2000, 05, 04))
            {
                return true;
            }
            else if (customer.FirstName == "Kutay" && customer.LastName == "İnaç" && customer.NationalityId == "1023456789" && customer.DateofBirth == new DateTime(1994, 05, 03))
            {
                return true;
            }
            else
            {
                throw new Exception("Hatali bilgi Girişi");
            }
        }
    }
}
