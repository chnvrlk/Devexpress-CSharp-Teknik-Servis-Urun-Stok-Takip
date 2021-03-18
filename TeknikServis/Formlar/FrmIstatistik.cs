using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            lblToplamUrun.Text = db.Urunler.Count().ToString();
            lblToplamKategori.Text = db.Kategoriler.Count().ToString();
            lblToplamStok.Text = db.Urunler.Sum(x => x.Stok).ToString();
            lblKritikSeviye.Text = "10";
            lblEnFazlaStokluUrun.Text = (from x in db.Urunler
                                         orderby x.Stok descending
                                         select x.Ad).FirstOrDefault();
            lblEnAzStokluUrun.Text = (from x in db.Urunler
                                      orderby x.Stok ascending
                                      select x.Ad).FirstOrDefault();
            lblEnYuksekFiyatUrun.Text = (from x in db.Urunler
                                         orderby x.Satis descending
                                         select x.Ad).FirstOrDefault();
            lblEnDusukFiyatUrun.Text = (from x in db.Urunler
                                        orderby x.Satis ascending
                                        select x.Ad).FirstOrDefault();
            lblBeyazEsyaStok.Text = db.Urunler.Count(x => x.KategoriId == 4).ToString();
            lblBilgisayarStokSayisi.Text = db.Urunler.Count(x => x.KategoriId == 1).ToString();
            lblTVStokSayisi.Text = db.Urunler.Count(x => x.KategoriId == 5).ToString();
            lblToplamMarkaSayisi.Text = (from x in db.Urunler
                                         select x.Marka).Distinct().Count().ToString();
            lblArizaliUrunSayisi.Text = db.UrunKabuller.Count().ToString();
            DateTime today = DateTime.Today;
            lblBugunGelenUrunSayisi.Text = db.UrunKabuller.Where(x => x.GelisTarihi == today).Count().ToString();
            //lblEnFazlaUrunKategorisi.Text = db.maxkategoriurunu().FirstOrDefault(); procedure yazılmadığı için yoruma alındı



        }
    }
}
