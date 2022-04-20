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

        public IEnumerable<T> Get()
        {
            return _context.Set<T>();
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).First();
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        //private bool disposed = false;

        //public virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            _context.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}
