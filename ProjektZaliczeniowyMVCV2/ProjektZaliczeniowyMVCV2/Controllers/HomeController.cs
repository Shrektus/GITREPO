using Microsoft.AspNetCore.Mvc;
using ProjektZaliczeniowyMVCV2.Logic;
using ProjektZaliczeniowyMVCV2.Models;
using System.Diagnostics;

namespace ProjektZaliczeniowyMVCV2.Controllers
{
    public class HomeController : Controller
    {
        QuestController questController = new QuestController();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Rozpocznij()
        {

            return RedirectToAction("Index","Quest");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}