using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServis;



namespace TeknikServis.Formlar
{
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            UrunListele();            
        }

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.Ad = txtUrunAdi.Text;
            urunler.Marka = txtMarka.Text;
            urunler.Satis = decimal.Parse(txtSatisFiyat.Text);
            urunler.Alis = decimal.Parse(txtAlisFiyat.Text);
            urunler.Stok = short.Parse(txtStok.Text);
            urunler.Durum = false;
            urunler.KategoriId = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.Urunler.Add(urunler);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UrunListele()
        {
            var degerler = from u in db.Urunler
                           select new
                           {
                               u.Id,
                               u.Ad,
                               u.Marka,
                               Kategori = u.Kategoriler.Ad,
                               u.Alis,
                               u.Satis,
                               u.Stok
                           };
            gridControl1.DataSource = degerler.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.Kategoriler
                                                 select new
                                                 {
                                                     x.Id,
                                                     x.Ad
                                                 }).ToList();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
                txtUrunAdi.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
                txtMarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
                txtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("Alis").ToString();
                txtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("Satis").ToString();
                txtStok.Text = gridView1.GetFocusedRowCellValue("Stok").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Kategori").ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Eksik girilen ürünler var, lütfen bütün verileri eksiksiz giriniz.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.Urunler.Find(id);
            db.Urunler.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            UrunListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.Urunler.Find(id);
            deger.Ad = txtUrunAdi.Text;
            deger.Marka = txtMarka.Text;
            deger.Satis = decimal.Parse(txtSatisFiyat.Text);
            deger.Alis = decimal.Parse(txtAlisFiyat.Text);
            deger.Stok = short.Parse(txtStok.Text);
            deger.KategoriId = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAlisFiyat.Text = "";
            txtMarka.Text = "";
            txtId.Text = "";
            txtStok.Text = "";
            txtSatisFiyat.Text = "";
            txtUrunAdi.Text = "";
            lookUpEdit1.Text = "";

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
           
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
