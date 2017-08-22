using ContosoModel;
using ContosoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoMVC.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            CourseService service = new CourseService();
            var courselist = service.GetAllCourses();
            return View(courselist);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            CourseService service = new CourseService();
            service.Create(course);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            CourseService service = new CourseService();
            var course = service.GetById(Id);
            return View(course);
        }

        [HttpPost]
        public ActionResult Edit(Course course)
        {
            CourseService service = new CourseService();
            service.Update(course);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int Id)
        {
            CourseService service = new CourseService();
            var course = service.GetById(Id);
            return View(course);
        }
    }
}