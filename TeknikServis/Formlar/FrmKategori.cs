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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        private void KategoriListele()
        {
            var degerler = from k in db.Kategoriler
                           select new
                           {
                               k.Id,
                               k.Ad
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text!="" && txtAd.Text.Length<=30)
            {
                Kategoriler kategori = new Kategoriler();
                kategori.Ad = txtAd.Text;
                db.Kategoriler.Add(kategori);
                db.SaveChanges();
                MessageBox.Show("Kategori başarıyla kaydedildi.");
                KategoriListele();
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez ve Kategori Adı 30 Karakterden Fazla Olamaz");
            }
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text!="" && txtAd.Text.Length>=5)
            {
                int id = int.Parse(txtId.Text);
                var deger = db.Kategoriler.Find(id);
                deger.Ad = txtAd.Text;
                db.SaveChanges();
                MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KategoriListele();
            }
            else
            {
                MessageBox.Show("Kategori İsimsiz Güncellenemez!");
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Gerçekten silmek istiyor musunuz?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                var deger = db.Kategoriler.Find(id);
                db.Kategoriler.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KategoriListele();
            }      
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtId.Text = "";
        }
    }
}
