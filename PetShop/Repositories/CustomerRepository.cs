using PetShop.Entities;
using PetShop.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppContext context) : base(context)
        {
        }
        public Customer GetByEmailAndPassword(string email, string password)
        {
            return _table.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
        }
    }
}
