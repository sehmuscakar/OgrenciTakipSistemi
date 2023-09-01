using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakipSistemi
{
    public partial class EgitmenBranş : Form
    {
        public EgitmenBranş()
        {
            InitializeComponent();
        }
        BranşDal _branşDal = new BranşDal();
        private void EgitmenBranş_Load(object sender, EventArgs e)
        {
            BranşVeriYukle();


        }


        void BranşVeriYukle()
        {
            dataGridViewbranch.DataSource = _branşDal.BranşGetAll();
        }

        private void btnbranşekle_Click(object sender, EventArgs e)
        {
            Branş branş = new Branş
            {
                Name = txtbrans.Text,

            };
            _branşDal.AddBranş(branş);
            BranşVeriYukle();
            MessageBox.Show("Branş Başarıyla Eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnbranşguncelle_Click(object sender, EventArgs e)
        {
            Branş branş = new Branş
            {
                ID = Convert.ToInt32(txtbranşid.Text),
                Name = txtbrans.Text
            };
            _branşDal.UpdateBranş(branş);
            BranşVeriYukle();
            MessageBox.Show("Branş Başarıyla Eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewbranch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewbranch.SelectedCells[0].RowIndex;
            txtbranşid.Text = dataGridViewbranch.Rows[secilen].Cells[0].Value.ToString();
            txtbrans.Text = dataGridViewbranch.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnbranşsil_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(dataGridViewbranch.CurrentRow.Cells[0].Value);
            _branşDal.DeleteBranş(deger);
            BranşVeriYukle();
            MessageBox.Show("Hedef Başarıyla Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
