using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yazilimSinamaProje
{
    public abstract class veriler
    {
        protected SqlConnection baglanti;
        protected SqlCommand komut;
        protected void baglan()
        {
            baglanti = new SqlConnection("Data Source=SERAPPC;Initial Catalog=YazilimTestiProjesi;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }
    }
}
