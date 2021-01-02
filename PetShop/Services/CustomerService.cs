using PetShop.Entities;
using PetShop.IRepositories;
using PetShop.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
       
        public CustomerService(ICustomerRepository repository)
        {
            this._repository = repository;
        }
        public bool Delete(int id)
        {
            var customer = this.GetById(id);
            _repository.Delete(customer);
            return _repository.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public Customer GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Add(Customer customer)
        {
            _repository.Add(customer);
            return _repository.SaveChanges();
        }

        public bool Update(Customer customer)
        {
            _repository.Update(customer);
            return _repository.SaveChanges();
        }
    }
}
