using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneAçiKoleji.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ISchoolDal _schoolDal;

        public SchoolController(ISchoolDal schoolDal)
        {
            _schoolDal = schoolDal;
        }

        public IActionResult Index()
        {
            var values = _schoolDal.GetListAll(); 
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSchool()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSchool(school s)
        {
            _schoolDal.Insert(s);
            return RedirectToAction("Index");
        }
    }
}
