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
    public partial class Target : Form
    {
        public Target()
        {
            InitializeComponent();
        }
        HedefDal _hedefDal = new HedefDal();
      
        private void frmTargetandBranch_Load(object sender, EventArgs e)
        {
            Targetveriyukle();
           
        }

        void Targetveriyukle()
        {
            dataGridViewtarget.DataSource = _hedefDal.GetAll();
        }

       
        private void btnhedefeklee_Click(object sender, EventArgs e)
        {
            Hedef hedef = new Hedef
            {
                Name = txthedef.Text,
            };
            _hedefDal.AddTarget(hedef);
            MessageBox.Show("Hedef Başarıyla Eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        private void btnhedefguncelle_Click(object sender, EventArgs e)
        {
            Hedef hedef = new Hedef
            {
                ID = Convert.ToInt32(txthedefid.Text),
                Name=txthedef.Text
            };
            _hedefDal.UpdateTarget(hedef);
            Targetveriyukle();
            MessageBox.Show("Hedef Başarıyla Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     

      
       

        private void btnhedefsil_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(dataGridViewtarget.CurrentRow.Cells[0].Value);
            _hedefDal.DeleteTarget(deger);
            MessageBox.Show("Hedef Başarıyla Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Targetveriyukle();
        }

        private void dataGridViewtarget_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewtarget.SelectedCells[0].RowIndex;
            txthedefid.Text = dataGridViewtarget.Rows[secilen].Cells[0].Value.ToString();
            txthedef.Text = dataGridViewtarget.Rows[secilen].Cells[1].Value.ToString();
        }

      

      
    }
}
