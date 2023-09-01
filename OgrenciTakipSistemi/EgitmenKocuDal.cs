using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi
{
    public  class EgitmenKocuDal
    {

        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisOgrenciTakip; integrated security=true");
        public List<EgitimKocu> GetAll()
        {
            List<EgitimKocu> egitimKocus=new List<EgitimKocu>();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from EgitimKocu", baglanti);
            SqlDataReader oku=komut.ExecuteReader();
            while (oku.Read())
            {
                EgitimKocu egitimKocu = new EgitimKocu
                {
                    Id = Convert.ToInt32(oku["ID"]),
                    Name = oku["Name"].ToString(),
                    Surname = oku["Surname"].ToString(),
                };
                egitimKocus.Add(egitimKocu);
            }
            baglanti.Close();

            return egitimKocus;
        }


        public void AddEgitmenKoc(EgitimKocu egitimKocu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into EgitimKocu values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", egitimKocu.Name);
            komut.Parameters.AddWithValue("@p2", egitimKocu.Surname);
            komut.ExecuteNonQuery();
            baglanti.Close();      
        }

        public void UpdateEgitmen(EgitimKocu egitimKocu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update EgitimKocu set Name=@p1,Surname=@p2 where ID=@ıd ", baglanti);
            komut.Parameters.AddWithValue("@p1", egitimKocu.Name);
            komut.Parameters.AddWithValue("@p2", egitimKocu.Surname);
            komut.Parameters.AddWithValue("@ıd", egitimKocu.Id);
            komut.ExecuteNonQuery();
            baglanti.Close();   
        }
        public void RemoveEgitimkocu(int id)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from EgitimKocu where ID=@P1", baglanti);
            komut.Parameters.AddWithValue("@p1", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
