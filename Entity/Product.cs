using GameSellDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellDemo.Entity
{
    class Product :IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}
