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
    public class RecordsManager : IRecordsService
    {
        private readonly IRecordDal _recordDal;

        public RecordsManager(IRecordDal recordDal)
        {
            _recordDal = recordDal;
        }

        public void Delete(Records t)
        {
            _recordDal.Delete(t);
        }

        public Records GetById(int id)
        {
            return _recordDal.GetById(id);
        }

        public List<Records> GetFlimListWhiteRecord()
        {
            return _recordDal.GetFlimListWhiteRecord();
        }

        public List<Records> GetListAll()
        {
            return _recordDal.GetListAll();
        }

        public List<Records> GetSchoolList()
        {
            return _recordDal.GetSchoolList();
        }

        public void Insert(Records t)
        {
            _recordDal.Insert(t);
        }

        public void Update(Records t)
        {
            _recordDal.Update(t);
        }
    }
}
