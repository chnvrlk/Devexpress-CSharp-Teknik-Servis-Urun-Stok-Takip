using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.ILETISIMKlasoru
{
    public partial class FrmGelenMesajlar : Form
    {
        public FrmGelenMesajlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmGelenMesajlar_Load(object sender, EventArgs e)
        {
            lblToplamMesaj.Text = db.Iletisim.Count().ToString();
            lblTesekkurMesaj.Text = db.Iletisim.Where(x => x.Konu == "Teşekkür").Count().ToString();
            lblSikayetMesaj.Text = db.Iletisim.Where(x => x.Konu == "Şikayet").Count().ToString();
            lblRicaMesaj.Text = db.Iletisim.Where(x => x.Konu == "Rica").Count().ToString();
            lblToplamBolum.Text = db.Bolumler.Count().ToString();
            lblToplamKategori.Text = db.Kategoriler.Count().ToString();
            lblToplamCari.Text = db.Cariler.Count().ToString();
            lblToplamUrun.Text = db.Urunler.Count().ToString();
            lblToplamMarka.Text = (from x in db.Urunler select x.Marka).Distinct().Count().ToString();

            gridControl1.DataSource = db.Iletisim.ToList(); 
        }
    }
}
