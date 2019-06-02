using System.Diagnostics;
using KNK.aspnetcore_middleware_sample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace KNK.aspnetcore_middleware_sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationUser applicationUser;
        ILogger<HomeController> logger;

        public HomeController(ApplicationUser applicationUser, ILogger<HomeController> logger
            )
        {
            this.applicationUser = applicationUser;
            this.logger = logger;
        }

        public IActionResult Index()
        {
            logger.LogInformation("User Information : {applicationUser}", JsonConvert.SerializeObject(applicationUser));
            return View();
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
