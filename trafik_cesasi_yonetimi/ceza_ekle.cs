using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafik_cesasi_yonetimi
{
    public partial class ceza_ekle : Form
    {
        List<Ceza> cezaList;
        string plaka;
        public ceza_ekle(string plaka, List<Ceza> l)
        {
            InitializeComponent();
            cezaList = l;
            this.plaka = plaka;
        }

        private void CezaEkle (Ceza c)
        {
            c.CezaId = cezaList.Count;
            cezaList.Add(c);
        }

        private void cezaEklebtn_Click(object sender, EventArgs e)
        {
            string cezaTuru = this.cezaTuru.Text;

            Ceza ceza;
            switch (cezaTuru)
            {
                case "Hız Cezası":
                    ceza = new Hiz();
                    break;
                case "Park Cezası":
                    ceza = new Park();
                    break;
                case "Kırmısı Işık Cezası":
                    ceza = new KirmiziIsik();
                    break;
                default:
                    MessageBox.Show("Lütfen geçerli bir ceza türü seçiniz.");
                    return;
            }
            string plaka = plakaField.Text;
            string sAd = adiField.Text;
            string sSoyad = soyadiField.Text;
            string sTelefon = telefonField.Text;
            string sTC = TCNoField.Text;
            Surucu surucu = new Surucu(sAd, sSoyad, sTC, sTelefon);

            ceza.Plaka = plaka;
            ceza.CezaTarihi = DateTime.Now;
            ceza.SurucuId = surucu;
            CezaEkle(ceza);
            MessageBox.Show("ceza başarıyla eklendi");

            // alanlari sifirla
            this.cezaTuru.Text = "";
            adiField.Text = "";
            soyadiField.Text = "";
            telefonField.Text = "";
            TCNoField.Text = "";
        }

        private void ceza_ekle_Load(object sender, EventArgs e)
        {
            plakaField.Text = plaka;
        }
    }
}
