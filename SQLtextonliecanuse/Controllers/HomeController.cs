using Microsoft.AspNetCore.Mvc;
using SQLtextonliecanuse.Models;
using System.Diagnostics;
using System.Text;

namespace SQLtextonliecanuse.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        AppDbContext db = new AppDbContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Addemploye(Emlpyee e)
        {
          
            db.Emlpyee.Add(e);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));

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