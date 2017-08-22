using ContosoModel;
using ContosoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoMVC.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            PersonService service = new PersonService();
            var peoplelist = service.GetAllPeople();
            return View(peoplelist);
        }

        public ActionResult Create ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            PersonService service = new PersonService();
            service.Create(person);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            PersonService service = new PersonService();
            var person = service.GetById(Id);
            return View(person);
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            PersonService service = new PersonService();
            service.Update(person);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int Id)
        {
            PersonService service = new PersonService();
            var person = service.GetById(Id);
            return View(person);
        }
    }
}