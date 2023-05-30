using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Records
    {
        [Key]
        public int RecordID { get; set; }
   

        public string Page { get; set; }
        public string Status { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StudenID { get; set; }
        public Student Student { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }


       
    }
}
