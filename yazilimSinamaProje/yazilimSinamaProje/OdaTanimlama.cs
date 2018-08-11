using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilimSinamaProje
{
    public partial class OdaTanimlama : Form
    {
        string yetkiDurum;
        public OdaTanimlama(string yetki)
        {
            this.yetkiDurum = yetki;
            InitializeComponent();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                personeller p = new personeller();
                departmanBilgi d = new departmanBilgi();
                odalarBilgi oda = new odalarBilgi();
                oda.departmanID = d.departmanIDBul((string)departmanCmb.SelectedItem);
                oda.odaAdi = odaAdiTxt.Text;
                oda.personelID = p.personelIdBul((string)odaSorumlusuCmb.SelectedItem);
                if (oda.odaIdBul(odaAdiTxt.Text) == -1)
                {
                    oda.odaOlustur();
                    MessageBox.Show("Oda oluşturuldu.");
                }
                else
                {
                    MessageBox.Show("Aynı isimde bir oda mevcut. Bilgileri kontrol edip tekrar giriniz!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı alan girişi!");
            }
           

        }

        private void anaMenuyeDonBtn_Click(object sender, EventArgs e)
        {
            AnaMenu m = new AnaMenu(yetkiDurum);
            m.Show();
            this.Hide();
        }
    }
}
