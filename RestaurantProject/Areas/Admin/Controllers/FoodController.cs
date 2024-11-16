using Business.Abstract;
using Business.Concrete;
using Entities.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FoodController : Controller
    {
        IFoodService _foodService = new FoodManager();

        public IActionResult Index()
        {
            var data = _foodService.GetAll();

            return View(data);
        }

        [HttpGet]   
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Food food)
        {
            if(ModelState.IsValid)
            {
                _foodService.Add(food);

                return RedirectToAction("Index");
            }
            return View(food);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _foodService.GetById(id);

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Food food)
        {
            if (ModelState.IsValid)
            {
                _foodService.Update(food);
                return RedirectToAction(nameof(Index));
            }

            return View(food);
        }

        public IActionResult Delete(int id)
        {
            var data = _foodService.GetById(id);
            data.Deleted = id;

            _foodService.Delete(data);
             return RedirectToAction("Index");
        }
    }
}