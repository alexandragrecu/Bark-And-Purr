using Microsoft.EntityFrameworkCore;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop
{
    public class AppContext : DbContext
    {
        public AppContext (DbContextOptions options) : base(options) { }

        DbSet<Pet> Pets { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Sale> Sales { get; set; }

    }
}
