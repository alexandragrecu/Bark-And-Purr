using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string PetCategory { get; set; }
        public string Breed { get; set; }
        public float weight { get; set; }
        public float height { get; set; }
        public int age { get; set; }

    }
}
