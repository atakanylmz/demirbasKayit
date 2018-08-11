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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                kullanicilar kullanici = new kullanicilar();
                string dogrulama;
                string  adi, sifresi;
                int yetkiDurum;
                adi = kullaniciAdiTxt.Text;
                sifresi = sifreTxt.Text;
                yetkiDurum = (yetkiChck.Checked)?1:0;
                dogrulama = kullanici.kisiDogrula(adi, sifresi, yetkiDurum);
                if (dogrulama == "kayityok")
                {
                    MessageBox.Show("Kayıt bulunamadı!");
                }
                else
                {
                    AnaMenu m = new AnaMenu(dogrulama);
                    m.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı alan girişi!");
            }
            
        }
    }
}
