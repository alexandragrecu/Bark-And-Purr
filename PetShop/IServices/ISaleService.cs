using PetShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.IServices
{
    public interface ISaleService
    {
        List<Sale> GetAll();
        Sale GetById(int id);
        bool Insert(Sale sale);
        bool Update(Sale sale);
        bool Delete(int id);

    }
}
