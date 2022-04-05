using LearnASP.NET.Data;
using LearnASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearnASP.NET.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category;
            return View(objList);
        }
    }
}
