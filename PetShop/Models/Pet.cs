using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [Required]
        public string PetCategory { get; set; }
        [Required]
        public string Breed { get; set; }
        public float weight { get; set; }
        public float height { get; set; }
        public int age { get; set; }
        public virtual Customer Customer { get; set; }


    }
}
