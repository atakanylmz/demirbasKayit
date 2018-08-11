using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yazilimSinamaProje
{
    public class personeller:veriler
    {
        public int personelID { get; set; }
        public string personelAdi { get; set; }
        SqlDataReader dr;

        public int personelIdBul(string _personelAd)
        {
            baglan();
            komut.CommandText = "SELECT * FROM tbl_Personeller WHERE personelAdi=@personelAdi";
            komut.Parameters.AddWithValue("@personelAdi", _personelAd);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                personelID = dr.GetInt32(0);
            }
            else
            {
                personelID = -1;
            }
            baglanti.Close();
            return personelID;
        }
        public string personelAdiBul(int _personelId)
        {
            baglan();
            komut.CommandText = "SELECT * FROM tbl_Personeller WHERE personelID=@personelId";
            komut.Parameters.AddWithValue("@personelId", _personelId);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                personelAdi = dr.GetString(1);
            }
            baglanti.Close();
            return personelAdi;
        }
    }
}
