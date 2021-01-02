﻿using PetShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.IRepositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        T FindById(int id);

        bool SaveChanges();
    }
}
