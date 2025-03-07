using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharphone
{
    public class SmartPhone 
    {
        public int Id { get; set; }
        public string Brand { get; set; } 
        public string Model { get; set; }
        public int StorageSizeMb { get; set; }
        public double Price { get; set; }

        public int Stock { get; set; }  

        public SmartPhone(int id, string brand, string model, int storageSizeMb, double price, int stock)
        {
            Id = id;
            Brand = brand;
            Model = model;
            StorageSizeMb = storageSizeMb;
            Price = price;
            Stock = stock;
        }
        
    }
}
