using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Delete(Book t)
        {
           _bookDal.Delete(t);
        }

        public Book GetById(int id)
        {
            return _bookDal.GetById(id);
        }

        public List<Book> GetListAll()
        {
            return _bookDal.GetListAll();
        }

        public void Insert(Book t)
        {
            _bookDal.Insert(t);
        }

        public void Update(Book t)
        {
            _bookDal.Update(t);
        }
    }
}
