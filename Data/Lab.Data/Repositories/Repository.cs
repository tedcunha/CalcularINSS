using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Lab.Data.Context;
using Lab.Domain.Core.Models;
using Lab.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Lab.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity<T>
    {
        protected LabContext _context;
        protected DbSet<T> _dbSet;
        public Repository(LabContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T obj)
        {
            _dbSet.Add(obj);
            SalveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
        public IEnumerable<T> GetAll()
        {
           return _dbSet.ToList();
        }
        public T GetById(Guid id)
        {
            return _dbSet.Find(id);
        }
        public void Remove(Guid id)
        {
            _dbSet.Remove(_dbSet.Find(id));
            SalveChanges();
        }
        public int SalveChanges()
        {
           return _context.SaveChanges();
        }
        public IEnumerable<T> Search(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
        public void Update(T obj)
        {
            _dbSet.Update(obj);
            SalveChanges();
        }
    }
}