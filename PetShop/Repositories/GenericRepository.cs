﻿using Microsoft.EntityFrameworkCore;
using PetShop.Entities;
using PetShop.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

        protected readonly AppContext _context;
        protected readonly DbSet<T> _table;

        public GenericRepository(AppContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public void Add(T entity)
        {
            entity.CreateTime = DateTime.UtcNow;
            entity.UpdatedTime = DateTime.UtcNow;
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            Update(entity);
        }

        public T FindById(int id)
        {
            return _table.Find(id);
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update(T entity)
        {
            entity.UpdatedTime = DateTime.UtcNow;
            _table.Update(entity);
        }
    }
}
