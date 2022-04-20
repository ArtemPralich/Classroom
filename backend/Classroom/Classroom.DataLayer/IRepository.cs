using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Classroom.Entities;

namespace Classroom.DataLayer
{
    public interface IRepository<T> //: IDisposable
        where T : class
    {
        IEnumerable<T> Get();
        T Get(Expression<Func<T, bool>> expression); 
        void Create(T item);
        void Update(T item); 
        void Delete(T item); 
        void Save(); 
    }
}
