using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoffeeShop.Models;
using CoffeeShop.Domain.Repository;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IExampleRepository _exampleRepository { get; }
        
   
        public HomeController(ILogger<HomeController> logger, IExampleRepository exampleRepository)
        {
            _logger = logger;
            _exampleRepository = exampleRepository;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _exampleRepository.GetAll();
            return View(model);
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
