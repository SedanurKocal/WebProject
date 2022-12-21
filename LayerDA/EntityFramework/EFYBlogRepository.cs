using LayerDA.Abstract;
using LayerDA.Concrate;
using LayerDA.Repositories;
using LayerE.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LayerDA.EntityFramework
{
	public class EFYBlogRepository : GenericRepository<YBlog>, IYBlogDal
	{
		public List<YBlog> GetListWithCategory()
		{
			using (var c = new Context())
			{
				return c.YBlogs.Include(X => X.YCategory).ToList();
			}
		}
	}
}
