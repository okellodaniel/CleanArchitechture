using System.Collections.Generic;
using DomainLayer.Models;

namespace RepositoryLayer.Repository
{
    
        public interface IRepository<T> where T: BaseEntity
        {
            IEnumerable<T> GetAll();
            T Get(int Id);
            void insert(T entity);
            void Update(T entity);
            void Remove(T entity);
            void SaveChanges();
        }
    
}