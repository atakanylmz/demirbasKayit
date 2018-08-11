using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yazilimSinamaProje
{
    public class kullanicilar:veriler
    {
        public int kullaniciID { get; set; }
        public int personelID { get; set; }
        public string kullaniciAdi { get; set; }
        public bool yetki { get; set; }
        public string sifre { get; set; }
        SqlDataReader dr;
        
        public string kisiDogrula(string kullaniciAdi,string sifre,int yetki)
        {
            this.baglan();
            komut.CommandText = "SELECT * FROM tbl_Kullanicilar WHERE kullaniciAdi=@kAdi AND sifre=@kSifre AND yetki=@kYetki";
            komut.Parameters.AddWithValue("@kAdi", kullaniciAdi);
            komut.Parameters.AddWithValue("@kSifre", sifre);
            komut.Parameters.AddWithValue("@kYetki", yetki);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                baglanti.Close();
                if (yetki==1)
                    return "yetkili";
                else
                    return "yetkisiz";
            }
            else
            {
                baglanti.Close();
                return "kayityok";
            }            
        }
    }
}
