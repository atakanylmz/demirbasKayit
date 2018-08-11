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
    public partial class OdaDemirbasIslem : Form
    {
        string yetkiDurum;
        public OdaDemirbasIslem(string yetki)
        {
            this.yetkiDurum = yetki;
            InitializeComponent();
        }
        private SqlConnection baglanti;
        private SqlCommand komut;
        string departmanAdi;
        private void odaAraBtn_Click(object sender, EventArgs e)
        {
            odalarBilgi oda = new odalarBilgi();
            int departmanId = oda.odaDepartmanBul(aranacakOdaTxt.Text);
            if (departmanId == -1)
            {
                MessageBox.Show("Oda ile ilgili departman bulunamadı!");
            }
            else
            {
                departmanBilgi departman = new departmanBilgi();
                departmanAdi = departman.departmanAdiBul(departmanId);
                MessageBox.Show(aranacakOdaTxt.Text+" odasının bulunduğu " +departmanAdi+ " departmanındaki stoklar gösteriliyor");
                atamaGbx.Visible = true;
                tabloOlustur(departmanId);
                sorguDepId = departmanId;
                sorguOdaId = oda.odaIdBul(aranacakOdaTxt.Text);          
            }

        }
        private void tabloOlustur(int depID)
        {
            baglan();
            komut.CommandText = "SELECT demirbasID,demirbasAdi,demirbasAdedi FROM tbl_Demirbaslar WHERE departmanID=@departmanId";
            komut.Parameters.AddWithValue("@departmanId", depID);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
        int sorguOdaId;
        int sorguDepId;
        private void atamaYapBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int atanacakDemirbasId = Convert.ToInt32(atanacakDemirbasIdTxt.Text);
                int atanacakDemirbasAdedi = Convert.ToInt32(atanacakDemirbasAdediTxt.Text);
                personeller p = new personeller();

                int zimmetPersonelId = p.personelIdBul((string)zimmetPersonelCmb.SelectedItem);
                this.baglan();
                komut.CommandText = "SELECT demirbasID FROM tbl_Demirbaslar WHERE departmanID=@departmanId AND demirbasID=@dbasId ";
                komut.Parameters.AddWithValue("@departmanId", sorguDepId);
                komut.Parameters.AddWithValue("@dbasId", atanacakDemirbasId);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    baglanti.Close();
                    DemirbasStok d = new DemirbasStok();
                    int adet = d.demirbasAdediBul(atanacakDemirbasId);
                    if (atanacakDemirbasAdedi <= 0)
                    {
                        MessageBox.Show("Atanacak miktar negatif değer olamaz!");
                    }
                    else if (atanacakDemirbasAdedi <= adet)
                    {
                        d.demirbasStokGuncelle(atanacakDemirbasId, -atanacakDemirbasAdedi);
                        //stoktan düştük
                        tabloOlustur(sorguDepId);
                        DemirbasAtamalar dAtama = new DemirbasAtamalar();
                        dAtama.atanmaAdedi = atanacakDemirbasAdedi;
                        dAtama.demirbasID = atanacakDemirbasId;
                        dAtama.odaID = sorguOdaId;
                        dAtama.personelID = zimmetPersonelId;
                        dAtama.demirbasAta();
                        MessageBox.Show("Atama işleminiz gerçekleşmiştir");
                    }
                    else
                    {
                        MessageBox.Show("Atanmak istenen demirbaş miktarı stoktan çok olamaz!");
                    }
                }
                else
                {
                    baglanti.Close();
                    string mesaj = "belirttiğiniz odanın bulunduğu departmana ilişkin demirbaşlar listededir." +
                        Environment.NewLine + "lütfen listede bulunan bir değeri giriniz!";
                    MessageBox.Show(mesaj);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı alan girişi!");
            }
            
        }
        private void baglan()
        {
            baglanti = new SqlConnection("Data Source=SERAPPC;Initial Catalog=YazilimTestiProjesi;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }

        private void anaMenuyeDonBtn_Click(object sender, EventArgs e)
        {
            AnaMenu m = new AnaMenu(yetkiDurum);
            m.Show();
            this.Hide();
        }

        
    }
}
