using Microsoft.EntityFrameworkCore;
using PetShop.IServices;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class PetService : IPetService
    {
        private AppContext _context;

        public PetService (AppContext context)
        {
            _context = context;
        }

        public void Add(Pet newPet)
        {
            _context.Add(newPet);
            _context.SaveChanges();

        }

        public bool Delete(int id)
        {
            var pet = GetById(id);
            if (pet == null)
            {
                return false;
            }
            _context.Remove(pet);
            if (_context.SaveChanges() > 0)
            {
                return true;
            }
            return false;

        }

        public IEnumerable<Pet> GetAll()
        {
            return _context.Pets;
        }

        public Pet GetById(int id)
        {
            return GetAll()
                .FirstOrDefault(pet => pet.Id == id);
        }

        public bool Update(Pet pet)
        {
            _context.Update(pet);
            if (_context.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
