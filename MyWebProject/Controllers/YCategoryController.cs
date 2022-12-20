using LayerB.Concrate;
using LayerDA.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebProject.Controllers
{
    public class YCategoryController : Controller
    {
        YCategoryMannager cm = new YCategoryMannager(new EFYCategoryRepositroy());

        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
