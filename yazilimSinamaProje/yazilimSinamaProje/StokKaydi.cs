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
    public partial class StokKaydi : Form
    {
        string yetkiDurum;
        public StokKaydi(string yetki)
        {
            this.yetkiDurum = yetki;
            InitializeComponent();
        }

        private void anaMenuyeDonBtn_Click(object sender, EventArgs e)
        {
            AnaMenu m = new AnaMenu(yetkiDurum);
            m.Show();
            this.Hide();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                fakulteBilgi fakulte = new fakulteBilgi();
                departmanBilgi departman = new departmanBilgi();
                demirbasTuru dtur = new demirbasTuru();
                DemirbasStok demirbas = new DemirbasStok();
                demirbas.demirbasAdedi = Convert.ToInt32(demirbasAdetTxt.Text);
                string fytvirgulluTxt = (demirbasFiyatTxt.Text).Replace('.', ',');
                demirbas.fiyat = Convert.ToDecimal(fytvirgulluTxt);
                if (demirbas.demirbasAdedi <= 0 || demirbas.fiyat <= 0)
                {
                    MessageBox.Show("adet ve fiyat pozitif değer olmalıdır!");
                }
                else
                {
                    demirbas.demirbasAdi = demirbasAdTxt.Text;
                    DateTime dt = dateTimePicker1.Value;
                    demirbas.alimTarihi = dt.ToString("yyyy-MM-dd");
                    demirbas.demirbasTuruID = dtur.demirbasTuruIDBul((string)demirbasTurCmb.SelectedItem);
                    demirbas.departmanID = departman.departmanIDBul(departmanAdCmb.SelectedItem.ToString());
                    demirbas.fakulteID = fakulte.fakulteIDBul(fakulteAdCmb.SelectedItem.ToString());
                    demirbas.demirbasStokla();
                    MessageBox.Show("Demirbaş kaydedildi");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı alan girişi!");
            }
            
        }

        private void fakulteAdCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            if((string)fakulteAdCmb.SelectedItem== "Teknoloji")
            {
                departmanAdCmb.Items.Clear();
                departmanAdCmb.Items.Add("Yazılım");
                departmanAdCmb.Items.Add("Mekatronik");
                departmanAdCmb.SelectedItem = "Yazılım";
            }
            if ((string)fakulteAdCmb.SelectedItem == "Mühendislik")
            {
                departmanAdCmb.Items.Clear();
                departmanAdCmb.Items.Add("Elektronik");
                departmanAdCmb.Items.Add("Makine");
                departmanAdCmb.SelectedItem = "Elektronik";

            }
        }
    }
}
