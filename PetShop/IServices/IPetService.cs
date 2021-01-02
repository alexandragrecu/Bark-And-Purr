using PetShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.IServices
{
    public interface IPetService
    {
        List<Pet> GetAll();
        Pet GetById(int id);
        bool Add(Pet pet);
        bool Update(Pet pet);
        bool Delete(int id);

    }
}
