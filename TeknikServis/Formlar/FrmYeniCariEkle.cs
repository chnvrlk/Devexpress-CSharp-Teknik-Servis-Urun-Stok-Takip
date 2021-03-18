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
    public partial class FrmYeniCariEkle : Form
    {
        public FrmYeniCariEkle()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        int secilen;
        private void pictureEdit14_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureEdit14_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Cariler cariler = new Cariler();
            cariler.Ad = txtAd.Text;
            cariler.Soyad = txtSoyad.Text;
            cariler.Il = lookUpEdit2.Text;
            cariler.Ilce = lookUpEdit3.Text;
            cariler.Mail = txtMail.Text;
            cariler.Statu = txtStatu.Text;
            cariler.Telefon = txtTelefon.Text;
            cariler.VergiDairesi = txtVergiDairesi.Text;
            cariler.VergiNo = txtVergiNumarasi.Text;
            db.Cariler.Add(cariler);
            db.SaveChanges();
            MessageBox.Show("Yeni cari başarılı bir şekilde eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmYeniCariEkle_Load(object sender, EventArgs e)
        {
            lookUpEdit2.Properties.DataSource = (from x in db.Iller
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir
                                                 }).ToList();
            
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
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
