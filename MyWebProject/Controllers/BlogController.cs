using LayerDA.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebProject.Controllers
{
    public class BlogController : Controller
    {
        YManager ym = new YManager(new EFYBlogRepository());

        public IActionResult Index()
        {
            var values = ym.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult YBlogReadAll(int id)
        {
			//var values = ym.GetBlogyID(id);
			return View();
        }
		//public IActionResult YBlogReadAll(int id)
		//{
		//	var values = ym.GetBlogyID(id);
		//	return View(values);
		//}
	}
}
