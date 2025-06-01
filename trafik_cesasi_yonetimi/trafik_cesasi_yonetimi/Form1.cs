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
    public partial class Form1 : Form
    {
        List<Ceza> cezaList;
        public Form1()
        {
            InitializeComponent();
            cezaList = new List<Ceza>();
        }

        private void CezaEkle (Ceza c)
        {
            cezaList.Add(c);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cezaTuru = comboBox1.Text; //
            string plaka = textBox1.Text;  //
            string sAd = textBox2.Text;  //
            string sSoyad = textBox3.Text;  //
            string sTelefon = textBox5.Text; //
            string sTC = textBox6.Text; //

            Surucu surucu = new Surucu(sAd, sSoyad, sTC, sTelefon);

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
            ceza.Plaka = plaka;
            ceza.CezaTarihi = DateTime.Now;
            ceza.SurucuId = surucu;
            CezaEkle(ceza);
            MessageBox.Show("ceza başarıyla eklendi");
        }

        private void plaka_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tplmbrcgor_Click(object sender, EventArgs e)
        {

        }
    }
}
