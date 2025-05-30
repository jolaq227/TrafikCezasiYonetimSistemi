using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

    }
}
