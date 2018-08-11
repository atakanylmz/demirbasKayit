using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yazilimSinamaProje
{
    public class fakulteBilgi:veriler
    {
        public int fakulteID { get; set; }
        public string fakulteAdi { get; set; }
        SqlDataReader dr;
        public string fakulteAdiBul(int _fakulteID)
        {
            this.fakulteID = _fakulteID;
            baglan();
            komut.CommandText = "SELECT fakulteAdi FROM tbl_Fakulteler WHERE fakulteID=@fkID";
            komut.Parameters.AddWithValue("@fkID", _fakulteID);
            dr = komut.ExecuteReader();
            dr.Read();
            fakulteAdi = dr.GetString(1);
            baglanti.Close();
            return fakulteAdi;
        }
        public int fakulteIDBul(string _fakulteAdi)
        {
            baglan();
            komut.CommandText = "SELECT fakulteID FROM tbl_Fakulteler WHERE fakulteAdi=@fkAd";
            komut.Parameters.AddWithValue("@fkAd", _fakulteAdi);
            dr = komut.ExecuteReader();
            dr.Read();
            fakulteID = dr.GetInt32(0);
            baglanti.Close();
            return fakulteID;
        }
    }
}
