using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Student
    {

        public int StudentID { get; set; }


        public string StudentName { get; set; }
        public string StudentNo { get; set; }
        public string StudentClass { get; set; }
        public string StudentSchoolName { get; set; }

        public int SchoolID { get; set; }
        public school school { get; set; }
        public List<Records> Records { get; set; }

    }
}
