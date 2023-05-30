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
    public class RecordController : Controller
    {
        private readonly IRecordDal _recordDal;

        public RecordController(IRecordDal recordDal)
        {
            _recordDal = recordDal;
        }

        public IActionResult Index()
        {
            var value = _recordDal.GetFlimListWhiteRecord();
            return View("~/Views/Record/Index.cshtml", value);

        }
        [HttpGet]
        public IActionResult AddRecords()
        {
            BookManager bookManager = new BookManager(new EFBookDal());
            List<SelectListItem> values = (from x in bookManager.GetListAll()
                                           select new SelectListItem
                                           {
                                               
                                               Text = x.BookName,
                                               Value = x.BookID.ToString()
                                           }).ToList();
            ViewBag.v = values;

            StudentManager bookManagers = new StudentManager(new EFStudentDal());
            List<SelectListItem> valuess = (from x in bookManagers.GetListAll()
                                           select new SelectListItem
                                           {

                                               Text = x.StudentName,
                                               Value = x.SchoolID.ToString()
                                           }).ToList();
            ViewBag.b = valuess;
            return View();
        }
        [HttpPost]
        public IActionResult AddRecords(Records r)
        {
            _recordDal.Insert(r);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateRecords(int id)
        {
            BookManager bookManager = new BookManager(new EFBookDal());
            List<SelectListItem> values = (from x in bookManager.GetListAll()
                                           select new SelectListItem
                                           {
                                               Text = x.BookName,
                                               Value = x.BookID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = _recordDal.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateRecords(Records s)
        {
            _recordDal.Update(s);
            return RedirectToAction("Index");
        }
    }
}
