using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_zadacha.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int Warranty { get; set; }
        public double PriceForOne { get; set; }
        public int Ammount { get; set; }
    }
}
