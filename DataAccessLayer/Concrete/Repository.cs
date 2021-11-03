using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        DbSet<T> obj;
        public Repository()
        {
            obj = context.Set<T>();
        }
        public int Delete(T p)
        {
            obj.Remove(p);
            return context.SaveChanges();
        }

        public T GetById(int id)
        {
            return obj.Find(id);
        }

        public int Insert(T p)
        {
            obj.Add(p);
            return context.SaveChanges();
        }

        public List<T> List()
        {
            return obj.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return obj.Where(where).ToList();
        }

        public int Update(T p)
        {
            return context.SaveChanges();
        }
    }
}
