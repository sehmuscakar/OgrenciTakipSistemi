using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakipSistemi
{
    public partial class EgitimKocuForm : Form
    {
        public EgitimKocuForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisOgrenciTakip; integrated security=true");
        EgitmenKocuDal _egitmenKocuDal = new EgitmenKocuDal();
        BranşDal _branşDal=new BranşDal();
       


        void EgitmenVeriyukle()
        {
            dataGridViewegitimkoc.DataSource = _egitmenKocuDal.GetAll();

        }

        private void btnegitmenekle_Click(object sender, EventArgs e)
        {
            EgitimKocu egitimKocu = new EgitimKocu
            {
                Name=txtegitmenad.Text,
                Surname=txtegitmensoyad.Text,
            };
            _egitmenKocuDal.AddEgitmenKoc(egitimKocu);
            EgitmenVeriyukle();
            MessageBox.Show("Kayıt başarıyla Eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEgitmenguncelle_Click(object sender, EventArgs e)
        {
            EgitimKocu egitimKocu = new EgitimKocu
            {
                Id = Convert.ToInt32(txtEGİTMENid.Text),
                Name=txtegitmenad.Text,
                Surname=txtegitmensoyad.Text,
            };
            _egitmenKocuDal.UpdateEgitmen(egitimKocu);
            EgitmenVeriyukle();
            MessageBox.Show("Kayıt başarıyla Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridViewegitimkoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             int secilen = dataGridViewegitimkoc.SelectedCells[0].RowIndex;

            txtEGİTMENid.Text = dataGridViewegitimkoc.Rows[secilen].Cells[0].Value.ToString();
            txtegitmenad.Text = dataGridViewegitimkoc.Rows[secilen].Cells[1].Value.ToString();
            txtegitmensoyad.Text = dataGridViewegitimkoc.Rows[secilen].Cells[2].Value.ToString();
        }

        private void btnegitmensil_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(dataGridViewegitimkoc.CurrentRow.Cells[0].Value);
            _egitmenKocuDal.RemoveEgitimkocu(deger);
            EgitmenVeriyukle();
            MessageBox.Show("Kayıt başarıyla Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
