﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trafik_cesasi_yonetimi
{
    public enum CezaDurumu { Odendi, Odenmedi }
    public enum CezaTuru { Hiz, Park, KirmiziIsik }
    public abstract class Ceza : IOdenecek
    {
        public int CezaId;
        public DateTime CezaTarihi;
        public Surucu SurucuId;
        protected double CezaTutari;
        public CezaDurumu Durumu;
        public string Plaka;
        public CezaTuru Turu;

        public Ceza ()
        {
            Durumu = CezaDurumu.Odenmedi;
        }

        public double GetirBorc()
        {
            return CezaTutari;
        }

        public void Ode()
        {
            Durumu = CezaDurumu.Odendi;
        }

        public void setCezaTutari(double tutar)
        {
            CezaTutari = tutar;
        }
    }
}
