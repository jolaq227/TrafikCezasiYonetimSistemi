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
    public partial class tum_ceza_goruntule : Form
    {
        List<Ceza> cezaList;
        List<Ceza> mainList;
        public tum_ceza_goruntule(List<Ceza> l, List<Ceza> mainList)
        {
            InitializeComponent();
            cezaList = l;
            this.mainList = mainList;
        }

        private void tum_ceza_goruntule_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Türü";
            dataGridView1.Columns[2].Name = "Plaka";
            dataGridView1.Columns[3].Name = "Tutar";
            dataGridView1.Columns[4].Name = "S.TC";
            dataGridView1.Columns[5].Name = "S.Adı";
            dataGridView1.Columns[6].Name = "S.Soyadı";
            dataGridView1.Columns[7].Name = "S.Telefonu";
            dataGridView1.Columns[8].Name = "C.Tarihi";
            //dataGridView1.Columns[9].Name = "Durumu";

            DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
            comboColumn.HeaderText = "Durumu";
            comboColumn.DataPropertyName = "Durumu";
            comboColumn.DataSource = Enum.GetValues(typeof(CezaDurumu));
            comboColumn.ValueType = typeof(CezaDurumu);

            dataGridView1.Columns.Add(comboColumn);


            for (int i = 0; i < cezaList.Count; i++)
            {
                dataGridView1.Rows.Add(
                    cezaList[i].CezaId,
                    cezaList[i].Turu.ToString(),
                    cezaList[i].Plaka,
                    cezaList[i].GetirBorc(),
                    cezaList[i].SurucuId.TCNo,
                    cezaList[i].SurucuId.Adi,
                    cezaList[i].SurucuId.Soyadi,
                    cezaList[i].SurucuId.Telefon,
                    cezaList[i].CezaTarihi,
                    cezaList[i].Durumu
                    );
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var column = dataGridView1.Columns[e.ColumnIndex];

                // تأكد أن هذا هو عمود "Durumu"
                if (column.HeaderText == "Durumu")
                {
                    int selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    //MessageBox.Show(selectedCeza + "");

                    Ceza hedefCeza = cezaList.FirstOrDefault(c => c.CezaId == selectedId);

                    var yeniDeger = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    if (hedefCeza != null)
                    {
                        hedefCeza.Durumu = (CezaDurumu)yeniDeger;
                    }


                }
            }
        }
    }
}
