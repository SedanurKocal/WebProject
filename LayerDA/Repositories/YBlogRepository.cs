using LayerDA.Abstract;
using LayerDA.Concrate;
using LayerE.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LayerDA.Repositories
{
    public class YBlogRepository : IYBlogDal
    {
        public void BlogAdd(YBlog blog)
        {
            using var c = new Context();
            c.Add(blog);
            c.SaveChanges();
        }

        public void BlogDelete(YBlog blog)
        {
            using var c = new Context();
            c.Remove(blog);
            c.SaveChanges();
        }

        public List<YBlog> BlogListAll()
        {
            using var c = new Context();
            return c.YBlogs.ToList();
        }

        public void BlogUpdate(YBlog blog)
        {
            using var c = new Context();
            c.Update(blog);
            c.SaveChanges();
        }

        public YBlog GetById(int id)
        {
            using var c = new Context();
            return c.YBlogs.Find(id);
        }
    }
}
