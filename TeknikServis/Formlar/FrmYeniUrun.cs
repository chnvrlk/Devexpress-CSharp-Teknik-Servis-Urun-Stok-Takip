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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.Kategoriler
                                                 select new
                                                 {
                                                     x.Id,
                                                     x.Ad
                                                 }).ToList();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

              
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            urun.Ad = txtUrunAdi.Text;
            urun.Marka = txtMarka.Text;
            urun.Stok = short.Parse(txtStok.Text);
            urun.Alis = decimal.Parse(txtAlisFiyati.Text);
            urun.Satis = decimal.Parse(txtSatisFiyati.Text);
            urun.KategoriId = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.Urunler.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtUrunAdi_Click(object sender, EventArgs e)
        {
            txtUrunAdi.Text = "";
            txtUrunAdi.Focus();
        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
