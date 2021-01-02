using Microsoft.EntityFrameworkCore;
using PetShop.Entities;
using PetShop.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Repositories
{
    public class PetRepository : GenericRepository<Pet>, IPetRepository 
    {
        public PetRepository(AppContext context) : base(context){}

        public Pet GetByIdJoined(int id)
        {
            var pet = _context.Pets.Where(pet => pet.Id == id)
                .Include(pet => pet.Customer)
                .FirstOrDefault();

            return pet;
        }


    }
}
