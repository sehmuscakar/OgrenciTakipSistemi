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
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisOgrenciTakip; integrated security=true");

        StudentDal _studentDal = new StudentDal();
        HedefDal  _hedefDal=new HedefDal();
        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("select * from StudentTarget", sqlConnection);
            SqlDataReader oku=komut.ExecuteReader();
            while (oku.Read())
            {
               // cmbogrhedef.Items.Add(oku["ID"]);
                cmbogrhedef.Items.Add(oku["Target"]);
            }
            sqlConnection.Close();

            studentveriyukle();
        }

        void studentveriyukle()
        {
            dataGridViewOgrenci.DataSource = _studentDal.GetAll();
            cmbogrhedef.Items.Add(dataGridViewOgrenci);
        }

        private void btnogrenciekle_Click(object sender, EventArgs e)
        {
            //int deneme = Convert.ToInt32(cmbogrhedef.SelectedIndex);
            int deneme = Convert.ToInt32(cmbogrhedef.SelectedValue);

            Student student = new Student
            {
                Name = txtogrenciad.Text,
                Surname = txtogrenncisoyad.Text,
                Exam1 = Convert.ToInt32(txtsinav1.Text),
                Exam2 = Convert.ToInt32(txtsinav2.Text),
     
              TargetName=cmbogrhedef.Text,

            };
            _studentDal.AddStudent(student);
            studentveriyukle();
            MessageBox.Show("Öğrenci Başarıyla Eklendi","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     

        private void btnogrenciguncelle_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {

                Id = Convert.ToInt32(txtogrid.Text),
                Name = txtogrenciad.Text,
                Surname = txtogrenncisoyad.Text,
                Exam1 = Convert.ToInt32(txtsinav1.Text),
                Exam2 = Convert.ToInt32(txtsinav2.Text),
                TargetID = Convert.ToInt32(cmbogrhedef.Text)

            };
            _studentDal.UpdateStudent(student);
            studentveriyukle();
            MessageBox.Show("Öğrenci Başarıyla Güncellendi", " Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnogrencisil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewOgrenci.CurrentRow.Cells[0].Value);
            _studentDal.RemoveStudent(id);
            studentveriyukle();
            MessageBox.Show("Kayıt Başarıyla Silinidi"," Uyarı" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewOgrenci.SelectedCells[0].RowIndex;

            txtogrid.Text = dataGridViewOgrenci.Rows[secilen].Cells[0].Value.ToString();
            txtogrenciad.Text = dataGridViewOgrenci.Rows[secilen].Cells[1].Value.ToString();
            txtogrenncisoyad.Text = dataGridViewOgrenci.Rows[secilen].Cells[2].Value.ToString();
            txtsinav1.Text = dataGridViewOgrenci.Rows[secilen].Cells[3].Value.ToString();
            txtsinav2.Text = dataGridViewOgrenci.Rows[secilen].Cells[4].Value.ToString();
            cmbogrhedef.Text = dataGridViewOgrenci.Rows[secilen].Cells[5].Value.ToString();
        }

      
    }
}
