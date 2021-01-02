﻿using PetShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.IServices
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int id);
        bool Add(Customer Customer);
        bool Update(Customer Customer);
        bool Delete(int id);

    }
}
