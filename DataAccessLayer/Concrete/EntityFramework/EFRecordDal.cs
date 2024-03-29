﻿using DataAccessLayer.Abstract;
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
    public class EFRecordDal : GenericRepository<Records>, IRecordDal
    {
        public List<Records> GetFlimListWhiteRecord()
        {
            using (var c = new KContext())
            {
                return c.Records.Include(x => x.Book).ToList();

            }
           
        }

        public List<Records> GetSchoolList()
        {
            using (var c = new KContext())
            {
                return c.Records.Include(x => x.Student).ToList();
            }
        }

    }
}
