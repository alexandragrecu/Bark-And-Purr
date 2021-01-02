using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public float total { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
