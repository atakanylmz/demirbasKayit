using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace yazilimSinamaProje
{
    public partial class PersonelDemirbas : Form
    {
        string yetkiDurum;
        public PersonelDemirbas(string yetki)
        {
            this.yetkiDurum = yetki;
            InitializeComponent();
        }
        private SqlConnection baglanti;
        private SqlCommand komut;
        private void PersonelDemirbas_Load(object sender, EventArgs e)
        {

        }

        private void anaMenuyeDonBtn_Click(object sender, EventArgs e)
        {
            AnaMenu m = new AnaMenu(yetkiDurum);
            m.Show();
            this.Hide();
        }
        public void personelUzerindekiDemirbasBul(int _personelId)
        {
            this.baglan();
            string sqlKomutText = "SELECT da.demirbasID,d.demirbasAdi,da.atanmaAdedi FROM " +
                "tbl_DemirbasAtamalar da INNER JOIN tbl_Demirbaslar d" +
                " ON da.demirbasID=d.demirbasID WHERE da.personelID=@pID";
            komut.CommandText = sqlKomutText;
            komut.Parameters.AddWithValue("@pID", _personelId);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.baglanti.Close();
        }
        private void baglan()
        {
            baglanti = new SqlConnection("Data Source=SERAPPC;Initial Catalog=YazilimTestiProjesi;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            string ad = personelAdTxt.Text;
            personeller p = new personeller();
            int id = p.personelIdBul(ad);
            personelUzerindekiDemirbasBul(id);
        }
    }
}
