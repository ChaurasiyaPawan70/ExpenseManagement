using ExpenseManagament.DAL.Models;
using Microsoft.EntityFrameworkCore;
using ExpenseManagament.Common.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManagament.DAL.Data;
using System.Linq.Expressions;

namespace ExpenseManagament.Common.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> entities;

        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }

        public void Add(T entity)
        {
            _applicationDbContext.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _applicationDbContext.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _applicationDbContext.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return _applicationDbContext.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return _applicationDbContext.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            _applicationDbContext.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _applicationDbContext.Set<T>().RemoveRange(entities);
        }
    }
}