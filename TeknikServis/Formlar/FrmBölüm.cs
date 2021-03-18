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
    public partial class FrmBölüm : Form
    {
        public FrmBölüm()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        void BolumListele()
        {
            var degerler = from b in db.Bolumler
                           select new
                           {
                               b.Id,
                               b.Bölüm
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmBölüm_Load(object sender, EventArgs e)
        {
            BolumListele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            BolumListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtBolum.Text = gridView1.GetFocusedRowCellValue("Bölüm").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text!=null)
            {

                int id = int.Parse(txtId.Text);
                var deger = db.Bolumler.Find(id);
                db.Bolumler.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Bölüm başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BolumListele();
            }
            else
                MessageBox.Show("Bir bölümü seçmelisiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBolum.Text!=null && txtBolum.Text.Length>=4)
            {
                Bolumler bolum = new Bolumler();
                bolum.Bölüm = txtBolum.Text;
                db.Bolumler.Add(bolum);
                db.SaveChanges();
                MessageBox.Show("Bölüm başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BolumListele();
            }
            else
            {
                MessageBox.Show("Bölüm adı boş geçilemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBolum.Text!=null && txtBolum.Text.Length>=4)
            {
                int id = int.Parse(txtId.Text);
                var deger = db.Bolumler.Find(id);
                deger.Bölüm = txtBolum.Text;
                db.SaveChanges();
                MessageBox.Show("Bölüm başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BolumListele();
            }
            else
            {
                MessageBox.Show("Boş bölüm adı geçilemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
