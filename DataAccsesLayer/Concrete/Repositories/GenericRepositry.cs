using DataAccsesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsesLayer.Concrete.Repositories
{
    public class GenericRepositry<T> : IRepository<T> where T : class
    {
        Context c=new Context();
        DbSet<T> _object;

        public GenericRepositry()
        {
            _object=c.Set<T>();
        }

         
        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> Liste()
        {
            return _object.ToList();
        }

        public List<T> Liste(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
