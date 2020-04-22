using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoffeeShop.Models;
using CoffeeShop.Repository.Food;
using MySql.Data.MySqlClient;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IFoodRepository _foodRepository { get; }
        
   
        public HomeController(ILogger<HomeController> logger, IFoodRepository foodRepository)
        {
            _logger = logger;
            _foodRepository = foodRepository;
        }

        public async Task<IActionResult> Index()
        {
            var foodList = await _foodRepository.GetAllEntity();
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
