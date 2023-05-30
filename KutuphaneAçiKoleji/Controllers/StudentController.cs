using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneAçiKoleji.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentDal _studentDal;

        public StudentController(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public IActionResult Index()
        {
            var values = _studentDal.GetSchoolList();
            //var values = _studentDal.GetListAll();
            //return View(values);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddStudents()
        {
            SchoolManager schoolManager = new SchoolManager(new EFSchoolDal());
            List<SelectListItem> values = (from x in schoolManager.GetListAll()
                                           select new SelectListItem
                                           {

                                               Text = x.SchoolName,
                                               Value = x.SchoolID.ToString()
                                           }).ToList();
            ViewBag.v = values;

            return View();
        }
        [HttpPost]
        public IActionResult AddStudents(Student s)
        {
            _studentDal.Insert(s);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateStudents(int id)
        {
            SchoolManager schoolManager = new SchoolManager(new EFSchoolDal());
            List<SelectListItem> values = (from x in schoolManager.GetListAll()
                                           select new SelectListItem
                                           {

                                               Text = x.SchoolName,
                                               Value = x.SchoolID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = _studentDal.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateStudents(Student t)
        {
            _studentDal.Update(t);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteStudents(int id)
        {
            var value = _studentDal.GetById(id);
            _studentDal.Delete(value);
            return RedirectToAction("Index");
        }
    }
}
