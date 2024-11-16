using Business.Abstract;
using Business.Concrete;
using Entities.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        IAboutService _aboutService = new AboutManager();
        public IActionResult Index()
        {
            var data = _aboutService.GetAll();
            ViewBag.ShowButton = data.Count() == 0;

            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(About about)
        {
            if(ModelState.IsValid)
            {
                _aboutService.Add(about);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _aboutService.GetById(id);

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(About about)
        {
            if (ModelState.IsValid)
            {
                _aboutService.Update(about);
                return RedirectToAction(nameof(Index));
            }

            return View(about);
        }
    }
}
