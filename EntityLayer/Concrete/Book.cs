using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string  BookWritingName { get; set; }
        public string BookPage { get; set; }
        public string BookPublishingHouse { get; set; }
        public DateTime BookPublishingDate { get; set; }

        public List<Records> Records { get; set; }
    }
}
