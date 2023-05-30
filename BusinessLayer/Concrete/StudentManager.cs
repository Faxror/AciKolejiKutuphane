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
    public  class StudentManager : IStudentService
    {
        private readonly IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Delete(Student t)
        {
            _studentDal.Delete(t);
        }

        public Student GetById(int id)
        {
            return _studentDal.GetById(id);
        }

        public List<Student> GetListAll()
        {
            return _studentDal.GetListAll();
        }

        public List<Student> GetSchooList()
        {
            return _studentDal.GetSchoolList();
        }

        public List<Student> GetSchoolListWhiteStudent()
        {
            return _studentDal.GetSchoolListWhiteStudent();
        }

        public void Insert(Student t)
        {
            _studentDal.Insert(t);
        }

        public void Update(Student t)
        {
            _studentDal.Update(t);
        }
    }
}
