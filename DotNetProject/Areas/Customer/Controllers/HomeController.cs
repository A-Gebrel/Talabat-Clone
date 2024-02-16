using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Diagnostics;

namespace DotNetProject.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInMAnager;
        public HomeController(ILogger<HomeController> logger,
            UserManager<IdentityUser> _UserManager,
            SignInManager<IdentityUser> _SignInMAnager)
        {
            _logger = logger;
            userManager = _UserManager;
            signInMAnager = _SignInMAnager;
        }

        public IActionResult Index()
        {
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
