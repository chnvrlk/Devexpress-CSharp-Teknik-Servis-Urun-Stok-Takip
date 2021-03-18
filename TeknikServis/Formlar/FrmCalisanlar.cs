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
    public partial class FrmCalisanlar : Form
    {
        public FrmCalisanlar()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        
        void CalisanListele()
        {
            var degerler = from c in db.Calisanlar
                           select new
                           {
                               c.Id,
                               c.Ad,
                               c.Soyad,
                               c.Bölüm,
                               c.Telefon,
                               c.Mail
                           };
            gridControl1.DataSource = degerler.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.Bolumler
                                                 select new
                                                 {
                                                     x.Id,
                                                     x.Bölüm
                                                 }).ToList();
        }

        private void FrmCalisanlar_Load(object sender, EventArgs e)
        {
            CalisanListele();
            lblToplamDepartman.Text = db.Bolumler.Count().ToString();
            lblToplamPersonel.Text = db.Calisanlar.Count().ToString();
            lblEnFazlaCalisanDep.Text = (from x in db.Bolumler
                                         orderby x.Id descending
                                         select x.Bölüm).FirstOrDefault().ToString();
            lblEnAzCalisanDep.Text = (from x in db.Bolumler
                                         orderby x.Id ascending
                                         select x.Bölüm).FirstOrDefault().ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Length>=3 && txtAd.Text!=null && txtSoyad.Text.Length>=5 && txtSoyad.Text!=null && txtTelefon.Text!=null && txtTelefon.Text!= null && txtMail.Text!=null)
            {
                Calisanlar calisanlar = new Calisanlar();
                calisanlar.Ad = txtAd.Text;
                calisanlar.Soyad = txtSoyad.Text;
                calisanlar.Bölüm = int.Parse(lookUpEdit1.EditValue.ToString());
                calisanlar.Telefon = txtTelefon.Text;
                calisanlar.Mail = txtMail.Text;
                db.Calisanlar.Add(calisanlar);
                db.SaveChanges();
                MessageBox.Show("Calisan başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Lütfen bütün alanları eksiksiz giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            CalisanListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Bölüm").ToString();
            txtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text!=null)
            {
                int id = int.Parse(txtId.Text);
                var deger = db.Calisanlar.Find(id);
                db.Calisanlar.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Calisan başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CalisanListele();
            }
            else
                MessageBox.Show("Bir çalışan seçmelisiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Length >= 3 && txtAd.Text != null && txtSoyad.Text.Length >= 5 && txtSoyad.Text != null && txtTelefon.Text != null && txtTelefon.Text != null && txtMail.Text != null)
            {
                int id = int.Parse(txtId.Text);
                var deger = db.Calisanlar.Find(id);
                deger.Ad = txtAd.Text;
                deger.Soyad = txtSoyad.Text;
                deger.Bölüm = int.Parse(lookUpEdit1.EditValue.ToString());
                deger.Telefon = txtTelefon.Text;
                deger.Mail = txtMail.Text;
                db.SaveChanges();
                MessageBox.Show("Calisan başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CalisanListele();
            }
            else
                MessageBox.Show("Calisan güncelleme başarısız, lütfen alanları boş bırakmayın", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
