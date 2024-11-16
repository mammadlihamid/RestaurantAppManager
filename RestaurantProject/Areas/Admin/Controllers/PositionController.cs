using Business.Abstract;
using Business.Concrete;
using Entities.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PositionController : Controller
    {
        IPositionService _positionService = new PositionManager();

        public IActionResult Index()
        {
            var data = _positionService.GetAll();

            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Position position)
        {
            if(ModelState.IsValid)
            {
                _positionService.Add(position);

                return RedirectToAction("Index");
            }

            return View(position);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _positionService.GetById(id);

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Position position)
        {
            if (ModelState.IsValid)
            {
                _positionService.Update(position);

                return RedirectToAction("Index");
            }
            return View(position);
        }

        public IActionResult Delete(int id)
        {
            var data = _positionService.GetById(id);

            data.Deleted = id;

            _positionService.Delete(data);

            return RedirectToAction("Index");
        }
    }
}
