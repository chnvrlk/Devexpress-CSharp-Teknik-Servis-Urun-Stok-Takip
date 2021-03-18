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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        int secilen;

        private void CariListele()
        {
            var degerler = from c in db.Cariler
                           select new
                           {
                               c.Id,
                               c.Ad,
                               c.Soyad,
                               c.Telefon,
                               c.Mail,
                               c.Il,
                               c.Ilce,
                               c.Banka,
                               c.VergiDairesi,
                               c.VergiNo,
                               c.Statu,
                               c.Adres
                           };
            gridControl1.DataSource = degerler.ToList();
            lookUpEdit2.Properties.DataSource = (from x in db.Iller
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir
                                                 }).ToList();
           
        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            CariListele();
           
            lblToplamCariSayisi.Text = db.Cariler.Count().ToString();
            lblToplamIl.Text = db.Cariler.Select(x => x.Il).Distinct().Count().ToString();
            lblToplamIlce.Text = db.Cariler.Select(x => x.Ilce).Distinct().Count().ToString();
            //lblEnFazlaCariIL.Text = db.enYuksekCariliIl().FirstOrDefault(); procedure yazılmadığı için yoruma alındı
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtCariAdi.Text.Length >= 3 && txtCariAdi.Text != null && txtCariSoyadi.Text.Length >= 5 && txtCariSoyadi.Text != null && txtTelefon.Text != null && txtTelefon.Text != null && txtMail.Text != null
                && txtVergiDairesi.Text != null && txtBanka.Text != null && txtAdres.Text != null && txtVergiNumarasi.Text != null)
            {
                Cariler cariler = new Cariler();
                cariler.Ad = txtCariAdi.Text;
                cariler.Soyad = txtCariSoyadi.Text;
                cariler.Telefon = txtTelefon.Text;
                cariler.Mail = txtMail.Text;
                cariler.Il = lookUpEdit2.Text;
                cariler.Ilce = lookUpEdit3.Text;
                cariler.VergiDairesi = txtVergiDairesi.Text;
                cariler.VergiNo = txtVergiNumarasi.Text;
                cariler.Statu = txtStatu.Text;
                cariler.Banka = txtBanka.Text;
                cariler.Adres = txtAdres.Text;
                db.Cariler.Add(cariler);
                db.SaveChanges();
                MessageBox.Show("Cari başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.","Hata");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            CariListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text != null)
            {
                int id = int.Parse(txtId.Text);
                var deger = db.Cariler.Find(id);
                db.Cariler.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CariListele();
            }
            else
                MessageBox.Show("Bir Cari seçmelisiniz.","Hata");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtCariAdi.Text.Length >= 3 && txtCariAdi.Text != null && txtCariSoyadi.Text.Length >= 5 && txtCariSoyadi.Text != null && txtTelefon.Text != null && txtTelefon.Text != null && txtMail.Text != null
                && txtVergiDairesi.Text != null && txtBanka.Text != null && txtAdres.Text != null && txtVergiNumarasi.Text != null)
            {
                int id = int.Parse(txtId.Text);
                var deger = db.Cariler.Find(id);
                deger.Ad = txtCariAdi.Text;
                deger.Soyad = txtCariSoyadi.Text;
                deger.Mail = txtMail.Text;
                deger.Il = lookUpEdit2.Text;
                deger.Ilce = lookUpEdit3.Text;
                deger.Statu = txtStatu.Text;
                deger.VergiDairesi = txtVergiDairesi.Text;
                deger.VergiNo = txtVergiNumarasi.Text;
                deger.Telefon = txtTelefon.Text;
                deger.Adres = txtAdres.Text;
                db.SaveChanges();
                MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CariListele();
            }
            else
                MessageBox.Show("Lütfen tüm alanları doldurunuz.","Hata");
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit2.EditValue.ToString());
            lookUpEdit3.Properties.DataSource = (from z in db.Ilceler
                                                 select new
                                                 {
                                                     z.Iller.id,
                                                     z.ilce                                                     
                                                 }).Where(f => f.id == secilen).ToList();
        }
    }
}
