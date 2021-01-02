using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Entities
{
    public class Pet : BaseEntity
    {
        public string PetCategory { get; set; }
        public string Breed { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public int Age { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
