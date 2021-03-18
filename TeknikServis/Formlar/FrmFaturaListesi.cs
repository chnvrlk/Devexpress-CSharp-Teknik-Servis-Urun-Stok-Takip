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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }

        private void labelControl19_Click(object sender, EventArgs e)
        {

        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        void FaturaListele()
        {
            gridControl1.DataSource = (from x in db.Faturalar
                                       select new
                                       {
                                           x.Id,
                                           x.Seri,
                                           x.SiraNo,
                                           CARİ = x.Cariler.Ad + " " + x.Cariler.Soyad,
                                           x.Tarih,
                                           x.Saat,
                                           x.VergiDaire

                                       }).ToList();
        }

        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            FaturaListele();

            lookUpEdit1.Properties.DataSource = (from j in db.Cariler
                                                 select new
                                                 {
                                                     j.Id,
                                                     CARİ = j.Ad + " " + j.Soyad                                                    
                                                 }).ToList();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FaturaListele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Faturalar faturalar = new Faturalar();
            faturalar.Seri = txtSeri.Text;
            faturalar.SiraNo = txtSıraNo.Text;
            faturalar.Saat = txtSaat.Text;
            faturalar.Tarih = DateTime.Parse(txtTarih.Text);
            faturalar.VergiDaire = txtVergiDairesi.Text;
            faturalar.Cari = int.Parse(lookUpEdit1.EditValue.ToString());
            db.Faturalar.Add(faturalar);
            db.SaveChanges();
            MessageBox.Show("Fatura başarıyla eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFaturaId.Text);

            var degerler = (from x in db.FaturaDetaylar
                           select new
                           {
                               x.FaturaId,
                               x.FaturaDetayId,
                               x.Urun,
                               x.Adet,
                               x.Fiyat,
                               x.Tutar

                           }).Where(x=> x.FaturaId == id);
            gridControl2.DataSource = degerler.ToList();
        }

        

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaPopup fr = new FrmFaturaPopup();
            fr.id =int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            fr.Show();
        }
    }
}
