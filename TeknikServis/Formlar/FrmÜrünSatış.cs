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
    public partial class FrmÜrünSatış : Form
    {
        public FrmÜrünSatış()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmÜrünSatış_Load(object sender, EventArgs e)
        {
            lookUpEdit2.Properties.DataSource = (from x in db.Urunler
                                                 select new
                                                 {
                                                     x.Id,
                                                     x.Ad
                                                 }).ToList();


            lookUpEdit1.Properties.DataSource = (from y in db.Calisanlar
                                                 select new
                                                 {
                                                     y.Id,
                                                     Ad =y.Ad+ " " +y.Soyad
                                                 }).ToList();
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UrunHareketler uHareketler = new UrunHareketler();
            uHareketler.Urun = int.Parse(lookUpEdit2.EditValue.ToString());
            uHareketler.Musteri = int.Parse(lookUpEdit1.EditValue.ToString());
            uHareketler.Tarih = DateTime.Parse(txtTarih.EditValue.ToString());
            uHareketler.Adet = byte.Parse(txtAdet.Text);
            uHareketler.Fiyat = decimal.Parse(txtSatisFiyati.Text);
            uHareketler.UrunSeriNo = txtSeriNo.Text;
            db.UrunHareketler.Add(uHareketler);
            db.SaveChanges();
            MessageBox.Show("Ürün satışı eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = "";
        }

        private void txtAdet_Click(object sender, EventArgs e)
        {
            txtAdet.Text = "";
        }

        private void txtSatisFiyati_Click(object sender, EventArgs e)
        {
            txtSatisFiyati.Text = "";
        }

        private void txtSeriNo_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
