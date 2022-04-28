using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Classroom.Entities;
using Classroom.Entities.Models;

namespace Classroom.DataLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ClassroomContext _context { get; set; }
 
        public Repository(ClassroomContext context)
        {
            this._context = context;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            Save();
        }
        public void CreateRange(List<T> entity)
        {
            _context.Set<T>().AddRange(entity);
            Save();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            Save();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
