using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using LayerB.Abstract;
using LayerDA.Abstract;
using LayerE.Concrate;

public class YManager :IBYemekService 
{
	IYBlogDal yBlogDal;

	public YManager(IYBlogDal yBlogDal)
	{
		this.yBlogDal = yBlogDal;
	}

	public void YBlogAdd(YBlog yblog)
	{
		throw new NotImplementedException();
	}

	public void YBlogDelete(YBlog yblog)
	{
		throw new NotImplementedException();
	}

	public void YBlogUpdate(YBlog yblog)
	{
		throw new NotImplementedException();
	}

	public List<YBlog> GetList()
	{
		return yBlogDal.GetAllList();
	}

	public YBlog GetById(int id)
	{
		throw new NotImplementedException();
	}
	//public List<YBlog> GetBlogyID(int id)
	//{
	//	return yBlogDal.GetAllList(x => x.YBID == id);
	//}

	public List<YBlog> GetBlogListWithCategory()
	{
		return yBlogDal.GetListWithCategory();
	}
}
