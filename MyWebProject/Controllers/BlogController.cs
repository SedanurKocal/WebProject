﻿using Microsoft.AspNetCore.Mvc;

namespace MyWebProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}