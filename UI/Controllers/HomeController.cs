using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;
using UI.Models.Context;
using UI.Models.Entities;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (var ctx = new BaseContext())
            {
                Test test = new Test();
                test.Names = "blabla";



                ctx.tests.Add(test);
                ctx.SaveChanges();
                ctx.Dispose();
            }
            return View();
        }

        public IActionResult Privacy()
        {
            List<Test> test = new List<Test>();
            using (var ctx = new BaseContext())
            {
                test = ctx.tests.ToList();
                ctx.Dispose();
            }
            return View(test);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}