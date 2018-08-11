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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace yazilimSinamaProje
{
    public partial class OdaDemirbasListesi : Form
    {
        string yetkiDurum;
        public OdaDemirbasListesi(string yetki)
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
        private SqlConnection baglanti;
        private SqlCommand komut;
        private void baglan()
        {
            baglanti = new SqlConnection("Data Source=SERAPPC;Initial Catalog=YazilimTestiProjesi;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }
        private void araBtn_Click(object sender, EventArgs e)
        {
            try
            {
                yazi = "";
                odalarBilgi oda = new odalarBilgi();
                string aranacakOdaAd = aranacakOdaTxt.Text;
                int odaId = oda.odaIdBul(aranacakOdaAd);
                if (odaId == -1)
                {
                    MessageBox.Show("Oda bulunamadı!");
                    durumLbl.Text = "bulunamadı";
                }
                else
                {
                    durumLbl.Text = "oda bulundu";
                    ciktiAlBtn.Visible = true;
                    int perId = oda.odaPersonelIdBul(aranacakOdaAd);
                    personeller per = new personeller();
                    string perAd=per.personelAdiBul(perId);
                    baglan();
                    string sqlKomutText = "SELECT da.demirbasID,d.demirbasAdi,da.atanmaAdedi,dt.demirbasTuruID,d.fakulteID,d.departmanID FROM " +
                "tbl_DemirbasAtamalar da INNER JOIN tbl_Demirbaslar d " +
                "ON da.demirbasID=d.demirbasID INNER JOIN tbl_DemirbasTuru dt ON dt.demirbasTuruID=d.demirbasTuruID "+
                "WHERE da.odaID=@odaId";
                    komut.CommandText = sqlKomutText;
                    komut.Parameters.AddWithValue("@odaId", odaId);
                    yazi = "Oda sorumlusu: "+perAd+Environment.NewLine+Environment.NewLine;
                    SqlDataReader dr = komut.ExecuteReader();
                    int i= 0;
                    while (dr.Read())
                    {
                        i++;
                        yazi += " sira: " + i.ToString() + " demirbas kodu: " +dr.GetInt32(4)+"."+dr.GetInt32(5)+"."+dr.GetInt32(3)+ "." + dr.GetInt32(0) +
                            " demirbas adi: " + dr.GetString(1) + " demirbas adedi: " + dr.GetInt32(2)+Environment.NewLine+Environment.NewLine;
                    }
                    baglanti.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş!");
            }
        }
        string yazi;
        private void ciktiAlBtn_Click(object sender, EventArgs e)
        {
            try
            {
                iTextSharp.text.Document raporum = new iTextSharp.text.Document();
                // PDF oluşturması ve konumun belirlenmesi
                PdfWriter.GetInstance(raporum, new FileStream("C:\\Users\\Serap\\Desktop\\yazilimSinamaProje\\Raporum.pdf", FileMode.Create));
                if (raporum.IsOpen() == false)
                {
                    raporum.Open();
                    raporum.Add(new Paragraph(yazi));
                    raporum.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("raporum pdf dosyası kapatılmadan kayıt yapılamaz!");
            }
        }
    }
}
