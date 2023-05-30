using BusinessLayer.Abstrack;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRecordsService : IGenericService<Records>
    {
        List<Records> GetFlimListWhiteRecord();


    }
}
