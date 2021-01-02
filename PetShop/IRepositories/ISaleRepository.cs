using PetShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.IRepositories
{
    public interface ISaleRepository: IGenericRepository<Sale>
    {
        Sale GetByIdJoined(int id);
    }
}
