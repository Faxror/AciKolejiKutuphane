using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRecordDal : IGenericDal<Records>
    {
        List<Records> GetFlimListWhiteRecord();

        List<Records> GetSchoolList();



    }
}
