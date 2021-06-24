using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeliTR
{
    public class Urunler
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public decimal BirimFiyat { get; set; }
        public int StokAdet { get; set; }
        public byte[] Resim { get; set; }
        public int KategoriId { get; set; }
    }
}
