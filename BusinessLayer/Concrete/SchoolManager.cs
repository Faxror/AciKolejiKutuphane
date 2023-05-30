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
    public class SchoolManager : ISchoolService
    {
        private readonly ISchoolDal _schoolDal;

        public SchoolManager(ISchoolDal schoolDal)
        {
            _schoolDal = schoolDal;
        }

        public void Delete(school t)
        {
            _schoolDal.Delete(t);
        }

        public school GetById(int id)
        {
           return _schoolDal.GetById(id);
        }

        public List<school> GetListAll()
        {
            return _schoolDal.GetListAll();
        }

        public void Insert(school t)
        {
            _schoolDal.Insert(t);
        }

        public void Update(school t)
        {
            _schoolDal.Update(t);
        }
    }
}
