using Microsoft.EntityFrameworkCore;
using PetShop.Entities;
using PetShop.IRepositories;
using PetShop.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _repository;
        public PetService(IPetRepository repository)
        {
            this._repository = repository;
        }
        public bool Add(Pet pet)
        {
            _repository.Add(pet);
            return _repository.SaveChanges();
        }

        public bool Delete(int id)
        {
            var pet = _repository.FindById(id);
            _repository.Delete(pet);
            return _repository.SaveChanges();
        }

        public List<Pet> GetAll()
        {
            return _repository.GetAll();
        }

        public Pet GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Update(Pet pet)
        {
            _repository.Update(pet);
            return _repository.SaveChanges();
        }
    }
}
