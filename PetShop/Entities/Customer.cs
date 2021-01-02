using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PetBreed { get; set; }

        public string Address { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
