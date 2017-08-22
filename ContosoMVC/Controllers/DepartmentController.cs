using ContosoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoModel;

namespace ContosoMVC.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            DepartmentService service = new DepartmentService();
            var departmentlist = service.GetAllDepartment();
            return View(departmentlist);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            DepartmentService service = new DepartmentService();
            service.Create(department);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            DepartmentService service = new DepartmentService();
            var department = service.GetById(Id);
            return View(department);

        }

        [HttpPost]
        public ActionResult Edit(Department department)
        {
            DepartmentService service = new DepartmentService();
            service.Update(department);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            DepartmentService service = new DepartmentService();
            var dept = service.GetById(id);
            return View(dept);
        }

    }
}