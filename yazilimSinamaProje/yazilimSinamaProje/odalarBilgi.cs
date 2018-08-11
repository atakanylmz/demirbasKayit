using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yazilimSinamaProje
{
    public class odalarBilgi:veriler
    {
        private int odaID { get; set; }
        public string odaAdi { get; set; }
        public int departmanID { get; set; }
        public int personelID { get; set; }
        SqlDataReader dr;
        private int odaAdiIleBul(string _odaAdi,int tabloSira)
        {
            baglan();
            komut.CommandText = "SELECT * FROM tbl_Odalar WHERE odaAdi=@odaAdi";
            komut.Parameters.AddWithValue("@odaAdi", _odaAdi);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                int id= dr.GetInt32(tabloSira);
                baglanti.Close();
                return id;
            }
            else
            {
                baglanti.Close();
                return -1;
            }
        }
        public int odaPersonelIdBul(string _odaAdi)
        {
            personelID = odaAdiIleBul(_odaAdi, 3);
            return personelID;
        }
        public int odaIdBul(string _odaAdi)
        {
            odaID = odaAdiIleBul(_odaAdi, 0);
            return odaID;
        }
        public int odayaPersonelAta(int _personelID,int _odaID)
        {
            baglan();
            komut.CommandText = "UPDATE tbl_Odalar SET personelID=@personelId WHERE odaID=@odaId";
            komut.Parameters.AddWithValue("@personelId", _personelID);
            komut.Parameters.AddWithValue("@odaId", _odaID);
            int etkilenen=komut.ExecuteNonQuery();
            baglanti.Close();
            return etkilenen;
        }
        public void odaOlustur()
        {
            baglan();
            komut.CommandText = "INSERT INTO tbl_Odalar(odaAdi,departmanID,personelID) VALUES(@odaAd,@departmanId,@personelId)";
            komut.Parameters.AddWithValue("@personelId", personelID);
            komut.Parameters.AddWithValue("@odaAd", odaAdi);
            komut.Parameters.AddWithValue("@departmanId", departmanID);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public int odaDepartmanBul(string _odaAdi)
        {
            departmanID = odaAdiIleBul(_odaAdi, 2);
            return departmanID;
        }
    }
}
