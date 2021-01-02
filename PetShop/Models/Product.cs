using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PetType { get; set; }
        public float Cost { get; set; }
        
    }
}
