using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneAçiKoleji.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookDal _bookDal;

        public BooksController(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public IActionResult Index()
        {
            var values = _bookDal.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddBooks()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBooks(Book t)
        {
            _bookDal.Insert(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateBooks(int id)
        {
            var value = _bookDal.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateBooks(Book t)
        {
            _bookDal.Update(t);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBooks(int id)
        {
            var value = _bookDal.GetById(id);
            _bookDal.Delete(value);
            return RedirectToAction("Index");
        }
    }
}
