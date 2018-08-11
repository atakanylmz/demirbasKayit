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
    public partial class DemirbasAramaListeleme : Form
    {
        string yetkiDurum;
        public DemirbasAramaListeleme(string yetki)
        {
            yetkiDurum = yetki;
            InitializeComponent();
        }

        private void anaMenuyeDonBtn_Click(object sender, EventArgs e)
        {
            AnaMenu m = new AnaMenu(yetkiDurum);
            m.Show();
            this.Hide();
        }

        private void adIleAraBtn_Click(object sender, EventArgs e)
        {
            string ad = adIleAraTxt.Text;
            demirbasAdıIleAra(ad);
        }
        private SqlConnection baglanti;
        private SqlCommand komut;
        SqlDataAdapter da;
        DataTable dt;
        private void demirbasAdıIleAra(string _demirbasAdi)
        {
            baglan();
            string sqlKomutText = "SELECT d.demirbasAdi,d.fiyat,d.alimTarihi,d.demirbasAdedi,dp.departmanAdi FROM " +
                "tbl_Demirbaslar d INNER JOIN tbl_Departmanlar dp ON "+
                "d.departmanID=dp.departmanID WHERE d.demirbasAdi=@demirbasAd";
              komut.CommandText = sqlKomutText;
            komut.Parameters.AddWithValue("@demirbasAd", _demirbasAdi);
            datagrideAktar();
        }
        private void demirbasTuruIleAra(string _demirbasTuru)
        {
            baglan();
            string sqlKomutText = "SELECT d.demirbasAdi,d.fiyat,d.alimTarihi,d.demirbasAdedi,dp.departmanAdi FROM " +
                "tbl_Demirbaslar d INNER JOIN tbl_Departmanlar dp ON d.departmanID=dp.departmanID "+
                "INNER JOIN tbl_DemirbasTuru dt ON d.demirbasTuruID=dt.demirbasTuruID " +
                "WHERE dt.demeribasTuruAdi=@demirbasTur";
            komut.CommandText = sqlKomutText;
            komut.Parameters.AddWithValue("@demirbasTur", _demirbasTuru);
            datagrideAktar();
        }
        private void demirbasFiyatiIleAra(decimal _fiyat)
        {
            baglan();
            string sqlKomutText = "SELECT d.demirbasAdi,d.fiyat,d.alimTarihi,d.demirbasAdedi,dp.departmanAdi FROM " +
                "tbl_Demirbaslar d INNER JOIN tbl_Departmanlar dp ON " +
                "d.departmanID=dp.departmanID WHERE d.fiyat=@demirfiyat";
            komut.CommandText = sqlKomutText;
            komut.Parameters.AddWithValue("@demirfiyat", _fiyat);
            datagrideAktar();
        }
        private void demirbasAlimTarihiIleAra(DateTime _tarih)
        {
            baglan();
            string t= _tarih.ToString("yyyy-MM-dd");
            string sqlKomutText = "SELECT d.demirbasAdi,d.fiyat,d.alimTarihi,d.demirbasAdedi,dp.departmanAdi FROM " +
                "tbl_Demirbaslar d INNER JOIN tbl_Departmanlar dp ON " +
                "d.departmanID=dp.departmanID WHERE d.alimTarihi=@tarih";
            komut.CommandText = sqlKomutText;
            komut.Parameters.AddWithValue("@tarih", t);
            datagrideAktar();
        }
        private void datagrideAktar()
        {
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void baglan()
        {
            baglanti = new SqlConnection("Data Source=SERAPPC;Initial Catalog=YazilimTestiProjesi;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }

        private void turIleAraBtn_Click(object sender, EventArgs e)
        {
            string tur = turIleAraTxt.Text;
            demirbasTuruIleAra(tur);
        }

        private void fiyatIleArBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fytTxt = (fiyatIleAraTxt.Text).Replace(".", ",");
                decimal fiyat = Convert.ToDecimal(fytTxt);
                if (fiyat > 0)
                    demirbasFiyatiIleAra(fiyat);
                else
                    MessageBox.Show("Fiyat pozitif değer almalıdır!");
            }
            catch (Exception)
            {
                MessageBox.Show("Uygun fiyat değeri giriniz!");
            }
           
        }

        private void tarihIleAraBtn_Click(object sender, EventArgs e)
        {
            DateTime tarih = dateTimePicker1.Value;
            demirbasAlimTarihiIleAra(tarih);
        }

        private void tumDemirbaslariListeleBtn_Click(object sender, EventArgs e)
        {
            demirbasHepsiniAra();
            int at = atananSayısıBul();
            int st = stoklananSayısıBul();
            atananDemirbasSayisiLbl.Text = at.ToString();
            stoklananDemirbasSayisiLbl.Text = st.ToString();
            toplamDemirbasSayisiLbl.Text = (at+st).ToString();
        }
        private void demirbasHepsiniAra()
        {
            baglan();
            string sqlKomutText = "SELECT d.demirbasAdi,d.fiyat,d.alimTarihi,d.demirbasAdedi,dp.departmanAdi FROM " +
                "tbl_Demirbaslar d INNER JOIN tbl_Departmanlar dp ON " +
                "d.departmanID=dp.departmanID";
            komut.CommandText = sqlKomutText;
            datagrideAktar();
        }
        private int atananSayısıBul()
        {
            baglan();
            string sqlKomutText = "SELECT SUM(atanmaAdedi) FROM tbl_DemirbasAtamalar";
            komut.CommandText = sqlKomutText;
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            int adet = dr.GetInt32(0);
            baglanti.Close();
            return adet;
        }
        private int stoklananSayısıBul()
        {
            baglan();
            string sqlKomutText = "SELECT SUM(demirbasAdedi) FROM tbl_Demirbaslar";
            komut.CommandText = sqlKomutText;
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            int adet = dr.GetInt32(0);
            baglanti.Close();
            return adet;
        }


    }
}
