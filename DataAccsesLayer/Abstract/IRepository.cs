using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsesLayer.Abstract
{
    public interface IRepository<T>
    {
        //CRUD

        List<T> Liste();

        void Insert(T p);

        void Update(T p);

        void Delete(T p);

        List<T> Liste(Expression<Func<T, bool>> filter);
    }
}
