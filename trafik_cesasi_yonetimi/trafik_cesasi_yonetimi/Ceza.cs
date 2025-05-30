using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trafik_cesasi_yonetimi
{
    public enum CezaDurumu { Odendi, Odenmedi }
    public abstract class Ceza : IOdenecek
    {
        public int CezaId;
        public DateTime CezaTarihi;
        public Surucu SurucuId;
        protected int CezaTutari;
        public CezaDurumu Durumu;
        public string Plaka;

        public Ceza ()
        {
            Durumu = CezaDurumu.Odenmedi;
        }

        public int GetirBorc()
        {
            return CezaTutari;
        }

        public void Ode()
        {
            Durumu = CezaDurumu.Odendi;
        }
    }
}
