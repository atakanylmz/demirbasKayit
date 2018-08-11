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
    public partial class AnaMenu : Form
    {
        string yetkiDurum;
        
        public AnaMenu(string yetki)
        {
            yetkiDurum = yetki;
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            yetkiKontrolEt();
        }
        private void yetkiKontrolEt()
        {
            if (yetkiDurum == "yetkisiz")
            {
                StokKaydiBtn.Visible = false;
            }
        }

        private void personelDemirbasBtn_Click(object sender, EventArgs e)
        {
            PersonelDemirbas pd = new PersonelDemirbas(yetkiDurum);
            pd.Show();
            this.Hide();
        }

        private void StokKaydiBtn_Click(object sender, EventArgs e)
        {
            StokKaydi sk = new StokKaydi(yetkiDurum);
            sk.Show();
            this.Hide();
        }

        private void odaTanimlamaBtn_Click(object sender, EventArgs e)
        {
            OdaTanimlama t = new OdaTanimlama(yetkiDurum);
            t.Show();
            this.Hide();
        }

        private void odaDemirbasIslemBtn_Click(object sender, EventArgs e)
        {
            OdaDemirbasIslem odi = new OdaDemirbasIslem(yetkiDurum);
            odi.Show();
            this.Hide();
        }

        private void demirbasAramaListelemeBtn_Click(object sender, EventArgs e)
        {
            DemirbasAramaListeleme dAraLis = new DemirbasAramaListeleme(yetkiDurum);
            dAraLis.Show();
            this.Hide();
        }

        private void odaDemirbasListeBtn_Click(object sender, EventArgs e)
        {
            OdaDemirbasListesi odaDemList = new OdaDemirbasListesi(yetkiDurum);
            odaDemList.Show();
            this.Hide();
        }
    }
}
