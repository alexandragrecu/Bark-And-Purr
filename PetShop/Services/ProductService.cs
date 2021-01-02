using PetShop.Entities;
using PetShop.IRepositories;
using PetShop.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            this._repository = repository;
        }

        public bool Add(Product product)
        {
            _repository.Add(product);
            return _repository.SaveChanges();
        }

        public bool Delete(int id)
        {
            var product = _repository.FindById(id);
            _repository.Delete(product);
            return _repository.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public Product GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Update(Product product)
        {
            _repository.Update(product);
            return _repository.SaveChanges();
        }
    }
}
