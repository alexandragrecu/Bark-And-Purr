using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.IServices
{
    public interface IPetService
    {
        IEnumerable<Pet> GetAll();
        Pet GetById(int id);
        void Add(Pet newPet);
        bool Update(Pet pet);
        bool Delete(int id);
    }
}
