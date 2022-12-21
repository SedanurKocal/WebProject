using LayerE.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerB.Abstract
{
	public interface IBYemekService
	{
		void YBlogAdd(YBlog yblog);
		void YBlogDelete(YBlog yblog);
		void YBlogUpdate(YBlog yblog);
		List<YBlog> GetList();
		YBlog GetById(int id);
		List<YBlog> GetBlogListWithCategory();

	}
}
