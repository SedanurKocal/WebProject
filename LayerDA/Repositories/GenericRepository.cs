using LayerDA.Abstract;
using LayerDA.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDA.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
		protected Context c = new Context();

		public void Add(T entity)
		{
			c.Add(entity);
			c.SaveChanges();
		}

		public void Delete(T t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetAllList()
        {
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            c.Add(t);
            c.SaveChanges();
        }

		public List<T> GetAllList(Exception<Func<T, bool>> filter)
		{
			return c.Set<T>().Where(filter).ToList();
		}

		public void Update(T t)
        {
            c.Update(t);
            c.SaveChanges();
        }
	}
}
