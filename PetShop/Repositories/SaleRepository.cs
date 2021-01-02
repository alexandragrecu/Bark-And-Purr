using Microsoft.EntityFrameworkCore;
using PetShop.Entities;
using PetShop.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Repositories
{
    public class SaleRepository : GenericRepository<Sale>, ISaleRepository
    {
        public SaleRepository(AppContext context) : base(context)
        {
        }

        public Sale GetByIdJoined(int id)
        {
            var Sale = _context.Sales.Where(s => s.Id == id)
                .Include(s => s.Customer)

                .FirstOrDefault();

            return Sale;
        }
    }
}
