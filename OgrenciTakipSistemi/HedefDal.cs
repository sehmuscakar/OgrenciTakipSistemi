using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi
{
    public class HedefDal
    {
        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisOgrenciTakip; integrated security=true");
        public List<Hedef> GetAll()
        {
            List<Hedef> hedefs= new List<Hedef>();
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("select * from StudentTarget", sqlConnection);
            SqlDataReader oku= komut.ExecuteReader();
            while (oku.Read())
            {
                Hedef hedef = new Hedef()
                {
                    ID = Convert.ToInt32(oku["ID"]),
                    Name = oku["Target"].ToString(),
                };
                hedefs.Add(hedef);
            }
            sqlConnection.Close();
            return hedefs;
        }
        public void AddTarget(Hedef hedef)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("Insert Into StudentTarget values(@p1)",sqlConnection);
            komut.Parameters.AddWithValue("@p1",hedef.Name);
            komut.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdateTarget(Hedef hedef)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("Update StudentTarget set Target=@p1 where ID=@ıd",sqlConnection);
            komut.Parameters.AddWithValue("@p1", hedef.Name);
            komut.Parameters.AddWithValue("@ıd", hedef.ID);
            komut.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void DeleteTarget(int id)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("delete from StudentTarget where ıd=@ıd",sqlConnection);
            komut.Parameters.AddWithValue("@ıd", id);
            komut.ExecuteNonQuery();
            sqlConnection.Close();
                
        }
    }
}
