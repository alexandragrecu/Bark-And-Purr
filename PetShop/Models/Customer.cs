using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string PetBreed { get; set; }
      
        public string Address { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
