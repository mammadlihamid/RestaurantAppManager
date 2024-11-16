using Business.Abstract;
using Business.Concrete;
using Entities.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController : Controller
    {
        ITestimonialService _testimonialService = new TestimonialManager();

        public IActionResult Index()
        {
            var data = _testimonialService.GetAll();

            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Testimonial testimonial)
        {
            if(ModelState.IsValid)
            {
                _testimonialService.Add(testimonial);

                return RedirectToAction("Index");
            }

            return View(testimonial);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _testimonialService.GetById(id);

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Testimonial testimonial)
        {
            if(ModelState.IsValid)
            {
                _testimonialService.Update(testimonial);

                return RedirectToAction("Index");
            }

            return View(testimonial);
        }

        public IActionResult Delete(int id)
        {
            var data = _testimonialService.GetById(id);

            data.Deleted = id;

            _testimonialService.Delete(data);

            return RedirectToAction("Index");
        }
    }
}


