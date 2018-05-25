using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapıları
{
    public class Urun
    {
        public string Ad { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Miktar { get; set; }
        public int Maliyet { get; set; }
        public double SatisFiyati{ get; set; }
        public string UrunAciklamasi { get; set; }
        public string BulunduguKategori { get; set; }
        public int UrunNo { get; set; }
    }
}
