using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string PetType { get; set; }
        public float Cost { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
