using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Repository
{
    
    
    public class Repository<T> : IRepository<T> where T: BaseEntity
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> entities;

        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T Get(int Id)
        {
            return entities.SingleOrDefault(c => c.Id == Id);
        }

        public void insert(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            _applicationDbContext.SaveChanges(); 
        }

        public void Remove(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            _applicationDbContext.SaveChanges();
        }

        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}