using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PetBreed { get; set; }
        public float Adress { get; set; }
    }
}
