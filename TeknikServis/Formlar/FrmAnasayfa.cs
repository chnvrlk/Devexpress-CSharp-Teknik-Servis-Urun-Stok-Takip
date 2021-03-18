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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        private void KritikListele()
        {
            gridKritik.DataSource = (from x in db.Urunler
                                     select new
                                     {
                                         x.Id,
                                         x.Ad,
                                         x.Stok
                                     }).Where(x => x.Stok < 49).ToList();
        }

        private void FihristListele()
        {
            gridFih.DataSource = (from y in db.Cariler
                                  select new
                                  {
                                      y.Ad,
                                      y.Soyad,
                                      y.Telefon,
                                      y.Il
                                  }).ToList();
        }
        private void KategoriUrunListele()
        {
            //gridUrunKate.DataSource = db.urunkategori().ToList(); procedure yazılmadığı için yoruma aldım!! prosedürler C# da method(fonksiyon) yerini tutuyorlar.
        }
        
        private void BugunYapilacaklar()
        {
            DateTime today = DateTime.Today;
            var degerler = (from x in db.Notlar.OrderBy(y => y.Tarih).Where(x => x.Tarih == today)
                            select new
                            {
                                x.Baslik,x.Icerik
                            });
            gridBugunYap.DataSource = degerler.ToList();                
        }

       

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            KritikListele();
            FihristListele();
            //KategoriUrunListele();
            BugunYapilacaklar();    
        }
    }
}
