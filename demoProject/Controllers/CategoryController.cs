using demoProject.Data;
using demoProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace demoProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DemoDbContext _context;

        public CategoryController(DemoDbContext context)
        {
            _context = context;
           
        }

        public IActionResult Index()
        {
            //var listCategory = _context.Categories.ToList();
            
            return View();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();

        }
        //public JsonResult get
    }
}
