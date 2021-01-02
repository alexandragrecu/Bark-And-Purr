using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Sale
    {
        public int Id { get; set; }
        // customer id
        public int CId { get; set; }
        public DateTime date { get; set; }
        public float total { get; set; }
    }
}
