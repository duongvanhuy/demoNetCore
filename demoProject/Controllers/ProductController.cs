using demoProject.Data;
using demoProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace demoProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly DemoDbContext _context;

        public ProductController(DemoDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public JsonResult GetAll()
        {
            var data = _context.Products.ToList();
            return new JsonResult(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var data = _context.Categories.ToList();
            // convert data to SelectListItems
            var selectListItems = data.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();
            ViewBag.ItemsCategoery = selectListItems;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product mo)
        {
            _context.Products.Add(mo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
