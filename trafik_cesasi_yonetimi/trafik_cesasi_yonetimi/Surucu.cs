using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trafik_cesasi_yonetimi
{
    public class Surucu
    {
        public string Adi;
        public string Soyadi;
        public string TCNo;
        public string Telefon;

        public Surucu(string adi, string soyadi, string tCNo, string telefon)
        {
            Adi = adi;
            Soyadi = soyadi;
            TCNo = tCNo;
            Telefon = telefon;
        }
    }
}
