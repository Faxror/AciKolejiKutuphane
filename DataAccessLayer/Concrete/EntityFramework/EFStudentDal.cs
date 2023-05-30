using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFStudentDal : GenericRepository<Student>, IStudentDal
    {
        public List<Student> GetSchoolList()
        {
           using (var c = new KContext())
            {
                return c.Students.Include(x => x.school).ToList();
            }
        }

        public List<Student> GetSchoolListWhiteStudent()
        {
            using (var c = new KContext())
            {
                return c.Students.Include(x => x.school).ToList();
            }
        }
    }
}
