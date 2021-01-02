using PetShop.Entities;
using PetShop.IRepositories;
using PetShop.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _repository;
        public SaleService (ISaleRepository repository)
        {
            this._repository = repository;
        }
        public bool Delete(int id)
        {
            var sale = _repository.FindById(id);
            _repository.Delete(sale);
            return _repository.SaveChanges();
        }

        public List<Sale> GetAll()
        {
            return _repository.GetAll();
        }

        public Sale GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Insert(Sale sale)
        {
            _repository.Add(sale);
            return _repository.SaveChanges();
        }

        public bool Update(Sale sale)
        {
            _repository.Update(sale);
            return _repository.SaveChanges();
        }
    }
}
