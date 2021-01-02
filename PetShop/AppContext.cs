using Microsoft.EntityFrameworkCore;
using PetShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop
{
    public class AppContext : DbContext
    {
        public AppContext (DbContextOptions options) : base(options) { }

        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }


      //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
          //  optionsBuilder
            //    .UseSqlServer(@"Data Source=(localdb)\MSSQlLocalDB;Initial Catalog=database_petshop;");
        //}
    }
}
