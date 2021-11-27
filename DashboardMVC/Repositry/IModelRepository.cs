using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry
{
    public interface IModelRepository<T>
    {
        void Add(T entity);
        void Remove(T ID);
        T Get(int ID);
        IQueryable<T> Get();
        void Edit(T entity);
    }
}
