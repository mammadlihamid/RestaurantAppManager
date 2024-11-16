using Business.Abstract;
using Business.Concrete;
using Entities.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        ITeamService _teamService = new TeamManager();
        IPositionService _positionService = new PositionManager();
        public IActionResult Index()
        {
            var data = _teamService.GetAll();

            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Positions"] = _positionService.GetAll();

            return View();
        }

        [HttpPost]  
        public IActionResult Create(Team team)
        {
            if(ModelState.IsValid)
            {
                _teamService.Add(team);

                return RedirectToAction("Index");
            }

            return View(team);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData["Positions"] = _positionService.GetAll();
            var data = _teamService.GetById(id);

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Team team)
        {
            if (ModelState.IsValid)
            {
                _teamService.Update(team);


                return RedirectToAction("Index");
            }

            return View(team);
        }

        public IActionResult Delete(int id)
        {
            var data = _teamService.GetById(id);

            data.Deleted = id;

            _teamService.Delete(data);

            return RedirectToAction("Index");
        }
    }
}
