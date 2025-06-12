using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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

        private void ana_sayfa_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("cezalar.txt"))
            {
                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null) break;
                    string[] s = line.Split('\t');
                    Surucu surucu = new Surucu(s[6], s[7], s[8], s[9]);
                    Ceza ceza = (Ceza)Activator.CreateInstance(Type.GetType("trafik_cesasi_yonetimi." + s[5]));
                    ceza.CezaId = Convert.ToInt32(s[0]);
                    ceza.CezaTarihi = DateTime.Parse(s[1]);
                    ceza.setCezaTutari(Convert.ToDouble(s[2]));
                    ceza.Durumu = (CezaDurumu)Enum.Parse(typeof(CezaDurumu), s[3]);
                    ceza.Plaka = s[4];
                    ceza.SurucuId = surucu;
                    cezaList.Add(ceza);
                }
            }
        }

        private void ana_sayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("cezalar.txt", false);

            foreach (Ceza c in cezaList)
            {
                sw.WriteLine(
                    c.CezaId + "\t" +
                    c.CezaTarihi + "\t" +
                    c.GetirBorc() + "\t" +
                    c.Durumu + "\t" +
                    c.Plaka + "\t" +
                    c.Turu + "\t" +
                    c.SurucuId.Adi + "\t" +
                    c.SurucuId.Soyadi + "\t" +
                    c.SurucuId.TCNo + "\t" +
                    c.SurucuId.Telefon
                );
            }

            sw.Close();
        }
    }
}
