using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi
{
    public class StudentDal
    {
        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisOgrenciTakip; integrated security=true");
        public List<Student> GetAll()//öğrenci verilerini çekecez
        {
                List<Student> students=new List<Student>();
           
            
            sqlConnection.Open();
            SqlCommand komutkodu = new SqlCommand("select sd.ID, st.Target,sd.Name,sd.Surname,sd.Exam1,sd.Exam2 from StudentTarget st inner join StudentDB sd on st.ID=sd.Targetıd", sqlConnection);
            
            SqlDataReader oku=komutkodu.ExecuteReader();
            while(oku.Read())
            {
                Student student = new Student
                {
                    Id = Convert.ToInt32(oku["ID"]),
                    Name = oku["NAME"].ToString(),
                    Surname = oku["Surname"].ToString(),
                    Exam1 = Convert.ToInt32(oku["Exam1"]),
                    Exam2 = Convert.ToInt32(oku["Exam2"]),
                    TargetName = oku["Target"].ToString(),
                };
                students.Add(student);
            }
            sqlConnection.Close();
            return students;
        }

        public void AddStudent(Student student)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert Into StudentDB values(@p1,@p2,@p3,@p4,@p5)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1",student.Name);
            sqlCommand.Parameters.AddWithValue("@p2", student.Surname);
            sqlCommand.Parameters.AddWithValue("@p3", student.Exam1);
            sqlCommand.Parameters.AddWithValue("@p4", student.Exam2);
            sqlCommand.Parameters.AddWithValue("@p5", student.TargetName);
            sqlCommand.ExecuteNonQuery();
           sqlConnection.Close();
        }

        public void UpdateStudent(Student student)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("update Student set Name=@p1,Surname=@p2,Exam1=@p3,Exam2=@p4,Target=@p5 where ID=@ıd", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", student.Name);
            sqlCommand.Parameters.AddWithValue("@p2", student.Surname);
            sqlCommand.Parameters.AddWithValue("@p3", student.Exam1);
            sqlCommand.Parameters.AddWithValue("@p4", student.Exam2);
            sqlCommand.Parameters.AddWithValue("@p5", student.TargetID);
            sqlCommand.Parameters.AddWithValue("@ıd", student.Id);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();  
        }

        public void RemoveStudent(int id)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("delete from student where ID=@P1", sqlConnection);
            komut.Parameters.AddWithValue("@p1", id);
            komut.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
