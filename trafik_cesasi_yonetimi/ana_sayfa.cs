using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace trafik_cesasi_yonetimi
{
    public partial class ana_sayfa : Form
    {
        List<Ceza> cezaList;
        public ana_sayfa()
        {
            InitializeComponent();
            cezaList = new List<Ceza>();
        }

        private void CezaEkle(Ceza c)
        {
            cezaList.Add(c);
        }

        private void cezaEkle_Click(object sender, EventArgs e)
        {
            string plaka = plakaText.Text;
            if (plaka == "")
            {
                MessageBox.Show("Lütfen Plaka Giriniz");
            } else
            {
                ceza_ekle f2 = new ceza_ekle(plaka, cezaList);
                f2.Show();
            }
        }

        private void tmCzaGrntle_Click(object sender, EventArgs e)
        {
            tum_ceza_goruntule f2 = new tum_ceza_goruntule(cezaList, cezaList);
            f2.Show();
        }

        private void borcTopla_Click(object sender, EventArgs e)
        {
            string plaka = plakaText.Text;
            if (plaka == "")
            {
                MessageBox.Show("Lütfen Plaka Giriniz");
            }
            else
            {
                double toplamTutar = cezaList
                    .Where(c => c.Plaka != null && c.Plaka.Contains(plaka))
                    .Sum(c => c.GetirBorc());

                MessageBox.Show(plaka + " Plakalı Aracının Toplam Borcu : " + toplamTutar);
            }
        }

        private void raporla_Click(object sender, EventArgs e)
        {
            string plaka = plakaText.Text;
            if (plaka == "")
            {
                MessageBox.Show("Lütfen Plaka Giriniz");
            }
            else
            {
                var filtrelenmisListe = cezaList
                    .Where(c => c.Plaka != null && c.Plaka.Equals(plaka))
                    .ToList();
                tum_ceza_goruntule f2 = new tum_ceza_goruntule(filtrelenmisListe, cezaList);
                f2.Show();
            }
        }
    }
}
