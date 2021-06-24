using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeliTR
{
    public class Kategori
    {
        public int KategoriId { get; set; }

        public string KategoriAd { get; set; }

        public override string ToString()
        {
            return KategoriId + " " + KategoriAd;
        }
    }
}
