using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yazilimSinamaProje
{
    public class departmanBilgi:veriler
    {
        public int departmanID { get; set; }
        public string departmanAdi { get; set; }
        //public int fakulteID { get; set; }
        SqlDataReader dr;
        public string departmanAdiBul(int _departmanID)
        {
            this.departmanID = _departmanID;
            baglan();
            komut.CommandText = "SELECT * FROM tbl_Departmanlar WHERE departmanID=@dpID";
            komut.Parameters.AddWithValue("@dpID", _departmanID);
            dr = komut.ExecuteReader();
            dr.Read();
            departmanAdi = dr.GetString(1);
            baglanti.Close();
            return departmanAdi;
        }
        public int departmanIDBul(string _departmanAdi)
        {
            baglan();
            komut.CommandText = "SELECT * FROM tbl_Departmanlar WHERE departmanAdi=@dpAd";
            komut.Parameters.AddWithValue("@dpAd", _departmanAdi);
            dr = komut.ExecuteReader();
            dr.Read();
            departmanID = dr.GetInt32(0);
            baglanti.Close();
            return departmanID;
        }
    }
}
