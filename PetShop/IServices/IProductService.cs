using PetShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.IServices
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(int id);

    }
}
