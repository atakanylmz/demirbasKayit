using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yazilimSinamaProje
{
    public class demirbasTuru:veriler
    {
        public int demirbasTuruID { get; set; }
        public string demeribasTuruAdi { get; set; }
        SqlDataReader dr;
        public string demirbasTuruBul(int dbasTurID)
        {
            this.demirbasTuruID = dbasTurID;
            baglan();
            komut.CommandText = "SELECT demeribasTuruAdi FROM tbl_DemirbasTuru WHERE demirbasTuruID=@dbasTurID";
            komut.Parameters.AddWithValue("@dbasTurID", dbasTurID);
            dr = komut.ExecuteReader();
            dr.Read();
            demeribasTuruAdi = dr.GetString(1);
            baglanti.Close();
            return demeribasTuruAdi;
        }
        public int demirbasTuruIDBul(string dbasTurAd)
        {
            baglan();
            komut.CommandText = "SELECT demirbasTuruID FROM tbl_DemirbasTuru WHERE demeribasTuruAdi=@dbasTurAd";
            komut.Parameters.AddWithValue("@dbasTurAd", dbasTurAd);
            dr = komut.ExecuteReader();
            dr.Read();
            demirbasTuruID = dr.GetInt32(0);
            baglanti.Close();
            return demirbasTuruID;
        }
    }
}
