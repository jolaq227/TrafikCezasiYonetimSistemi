using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trafik_cesasi_yonetimi
{
    public class Hiz : Ceza
    {
        public Hiz ()
        {
            CezaTutari = 10000;
            Turu = CezaTuru.Hiz;
        }
    }
}
