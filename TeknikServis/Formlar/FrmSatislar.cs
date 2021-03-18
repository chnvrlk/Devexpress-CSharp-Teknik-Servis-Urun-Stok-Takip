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
    public partial class FrmSatislar : Form
    {
        public FrmSatislar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmSatislar_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.UrunHareketler
                           select new
                           {
                               x.HareketId,
                               x.Urunler.Ad,
                               MUSTERI = x.Cariler.Ad + " " + x.Cariler.Soyad,
                               x.Tarih,
                               x.Adet,
                               x.Fiyat,
                               x.UrunSeriNo
                           };
            gridControl1.DataSource = degerler.ToList();

        }
    }
}
