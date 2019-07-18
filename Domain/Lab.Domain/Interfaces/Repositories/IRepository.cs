using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Lab.Domain.Core.Models;

namespace Lab.Domain.Interfaces.Repositories
{
    public interface IRepository<T> : IDisposable where T : Entity<T>
    {
         void Add(T obj);
         void Update(T obj);
         void Remove(Guid id);
         T GetById(Guid id);
         IEnumerable<T> GetAll();
         IEnumerable<T> Search(Expression<Func<T, bool>> predicate);
         int SalveChanges();
    }
}