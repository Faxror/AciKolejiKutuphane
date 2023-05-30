using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class school
    {
        public int SchoolID { get; set; }
        public string SchoolName { get; set; }
        public List<Student> students { get; set; }
    }
}
