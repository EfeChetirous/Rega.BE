﻿using Microsoft.EntityFrameworkCore;
using Rega.DataHandler.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rega.DataHandler.Repository
{
    public class EfRepository<T> : IEfRepository<T> where T : BaseEntity
    {
        protected readonly RegaDbContext _dbContext;

        public EfRepository(RegaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public IEnumerable<T> ListAll()
        {
            return _dbContext.Set<T>().AsEnumerable();
        }

        public async Task<List<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public T Add(T entity)
        {
            entity.DateCreated = entity.DateCreated == null ? DateTime.Now : entity.DateCreated.Value;
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            entity.DateCreated = entity.DateCreated == null ? DateTime.Now : entity.DateCreated.Value;
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public void Update(T entity)
        {
            entity.DateCreated = entity.DateModified == null ? DateTime.Now : entity.DateModified.Value;
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                entity.DateCreated = entity.DateModified == null ? DateTime.Now : entity.DateModified.Value;
                _dbContext.Entry(entity).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }
        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
