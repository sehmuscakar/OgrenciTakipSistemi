using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi
{
    public class BranşDal
    {
        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisOgrenciTakip; integrated security=true");
        public List<Branş> BranşGetAll()
        {
            List<Branş> branşs = new List<Branş>();
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("select * from branch", sqlConnection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Branş branş=new Branş
                {
                    ID = Convert.ToInt32(oku["ID"]),
                    Name = oku["Name"].ToString(),
                };
                branşs.Add(branş);
            }
            sqlConnection.Close();
            return branşs;
        }
        public void AddBranş(Branş branş)
        {
            sqlConnection.Open();
            sqlConnection.Close();
            SqlCommand komut = new SqlCommand("Insert Into branch values(@p1)", sqlConnection);
            komut.Parameters.AddWithValue("@p1", branş.Name);
            komut.ExecuteNonQuery();
        }
        public void UpdateBranş(Branş branş)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("Update branch set Name=@p1 where ID=@ıd", sqlConnection);
            komut.Parameters.AddWithValue("@p1", branş.Name);
            komut.Parameters.AddWithValue("@ıd", branş.ID);
            komut.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void DeleteBranş(int id)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("delete from branch where ıd=@ıd", sqlConnection);
            komut.Parameters.AddWithValue("@ıd", id);
            komut.ExecuteNonQuery();
            sqlConnection.Close();

        }

    }
}
