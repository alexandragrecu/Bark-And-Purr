using Microsoft.EntityFrameworkCore;
using PetShop.Entities;
using PetShop.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppContext context) : base(context)
        {
        }

        public Product GetByIdJoined(int id)
        {
            var Product = _context.Products.Where(p => p.Id == id)
                .Include(p => p.Sale)
                
                .FirstOrDefault();

            return Product;
        }
    }
}
