using Business.Abstract;
using Business.Concrete;
using Entities.TableModels;
using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Models;
using System.Diagnostics;

namespace RestaurantProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IAboutService _aboutService = new AboutManager();
        IFoodService _foodService = new FoodManager();
        IPositionService _positionService = new PositionManager();
        ITeamService _teamService = new TeamManager();
        ITestimonialService _testimonialService = new TestimonialManager();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var aboutData = _aboutService.GetAll();
            var foodData = _foodService.GetAll();
            var positionData = _positionService.GetAll();
            var teamData = _teamService.GetAll();
            var testimonialData = _testimonialService.GetAll();

            HomeViewModel viewModel = new()
            {
                Abouts = aboutData,
                Foods = foodData,
                Positions = positionData,
                Teams = teamData,
                Testimonials = testimonialData
            };

            return View(viewModel);
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
