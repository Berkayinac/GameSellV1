using GameSellDemo.Abstract;
using GameSellDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Concrete
{
    class CustomerManager :  ICustomerService
    {
        ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Add(Customer customer)
        {
            _customerCheckService.CheckCustomer(customer);
            Console.WriteLine("Kayıt olan kişinin adı:" + customer.FirstName + "... Kayıt tamamlandı.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + "Kayıt Silindi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + "Kayıt Güncellendi.");
        }
    }
}
