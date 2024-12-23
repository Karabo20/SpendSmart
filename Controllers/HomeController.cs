using Microsoft.AspNetCore.Mvc;
using SpendSmart.Models;
using System.Diagnostics;

namespace SpendSmart.Controllers
{
    public class HomeController : Controller
    {
        // Dependency Injection
        private readonly ILogger<HomeController> _logger;
        
        private readonly SpendSmartDbContext _context;  

        public HomeController(ILogger<HomeController> logger, SpendSmartDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Products()
        {
            // Retrieve rows from table in Database

            var allRows = _context.Products.ToList();
            return View(allRows);
        }
        public IActionResult Update()
        {
            return View();
        }

        public IActionResult UpdateForm(Product entries)
        {

            _context.Products.Add(entries);
            _context.SaveChanges();
            return RedirectToAction("Products");

        }

            public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
