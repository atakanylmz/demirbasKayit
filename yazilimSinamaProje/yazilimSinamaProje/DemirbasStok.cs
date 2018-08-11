using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yazilimSinamaProje
{
    public class DemirbasStok:veriler
    {
        private int demirbasID { get; set; }
        public string demirbasAdi { get; set; }
        public decimal fiyat { get; set; }
        public string alimTarihi { get; set; }
        public int demirbasTuruID { get; set; }
        public int fakulteID { get; set; }
        public int departmanID { get; set; }
        public int demirbasAdedi { get; set; }
        
        public void demirbasStokla()
        {
            this.baglan();
            string sqlKomutText= "INSERT INTO tbl_Demirbaslar" +
                "(demirbasAdi,fiyat,alimTarihi,demirbasTuruID,fakulteID,departmanID,demirbasAdedi)" +
                "VALUES(@dbasAdi,@fiyat,@tarih,@dbasTurID,@fakulteID,@departmanID,@dbasAdet)";
            komut.CommandText = sqlKomutText;
            komut.Parameters.AddWithValue("@dbasAdi", demirbasAdi);
            komut.Parameters.AddWithValue("@fiyat", fiyat);
            komut.Parameters.AddWithValue("@tarih", alimTarihi);
            komut.Parameters.AddWithValue("@dbasTurID", demirbasTuruID);
            komut.Parameters.AddWithValue("@fakulteID", fakulteID);
            komut.Parameters.AddWithValue("@departmanID", departmanID);
            komut.Parameters.AddWithValue("@dbasAdet", demirbasAdedi);
            komut.ExecuteNonQuery();
            this.baglanti.Close();
        }
        public void demirbasStokGuncelle(int _demirbasId,int miktar)
        {
            baglan();
            komut.CommandText = "UPDATE tbl_Demirbaslar SET demirbasAdedi=demirbasAdedi+@adet WHERE demirbasID=@dbasId";
            komut.Parameters.AddWithValue("@adet", miktar);
            komut.Parameters.AddWithValue("@dbasId", _demirbasId);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        public int demirbasAdediBul(int _dbasId)
        {
            this.baglan();
            string sqlKomutText = "SELECT * FROM tbl_Demirbaslar WHERE demirbasID=@dbasId";
            komut.CommandText = sqlKomutText;
            komut.Parameters.AddWithValue("@dbasId", _dbasId);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            int adet = Convert.ToInt32(dr["demirbasAdedi"]);
            this.baglanti.Close();
            return adet;
        }
        
        
        
    }
    
}
