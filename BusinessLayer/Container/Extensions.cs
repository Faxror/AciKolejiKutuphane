using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {

            services.AddScoped<IBookService, BookManager>();
            services.AddScoped<IBookDal, EFBookDal>();

            services.AddScoped<IStudentService, StudentManager>();
            services.AddScoped<IStudentDal, EFStudentDal>();

            services.AddScoped<IRecordsService, RecordsManager>();
            services.AddScoped<IRecordDal, EFRecordDal>();

            services.AddScoped<ISchoolService, SchoolManager>();
            services.AddScoped<ISchoolDal, EFSchoolDal>();
        }
    }
}
