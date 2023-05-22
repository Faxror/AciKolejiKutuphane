using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string KitapName { get; set; }
        public string  KitapYazarName { get; set; }
        public string KitapSayfa { get; set; }
        public string KitapYayınEvi { get; set; }
        public DateTime KitapBasımTarih { get; set; }
    }
}
