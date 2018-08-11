using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yazilimSinamaProje
{
    public class DemirbasAtamalar:veriler
    {
        private int odaDemirbasAtamaID { get; set; }
        public int odaID { get; set; }
        public int demirbasID { get; set; }
        public int atanmaAdedi { get; set; }
        public int personelID { get; set; }
        public void demirbasAta()
        {
            this.baglan();
            string sqlKomutText = "INSERT INTO tbl_DemirbasAtamalar " +
                "(odaID,demirbasID,atanmaAdedi,personelID)" +
                " VALUES(@odaId,@demirbasId,@atanmaAdedi,@personelID)";
            komut.CommandText = sqlKomutText;
            komut.Parameters.AddWithValue("@odaId", odaID);
            komut.Parameters.AddWithValue("@demirbasId", demirbasID);
            komut.Parameters.AddWithValue("@atanmaAdedi", atanmaAdedi);
            komut.Parameters.AddWithValue("@personelID", personelID);
            komut.ExecuteNonQuery();
            this.baglanti.Close();
        }
        
    }
}
