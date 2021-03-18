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
    public partial class FrmYeniCalisan : Form
    {
        public FrmYeniCalisan()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Calisanlar calisanlar = new Calisanlar();
            calisanlar.Ad = txtAd.Text;
            calisanlar.Soyad = txtSoyad.Text;
            calisanlar.Telefon = txtTelefon.Text;
            calisanlar.Mail = txtMail.Text;
            calisanlar.Bölüm = int.Parse(txtBolum.Text);
            db.Calisanlar.Add(calisanlar);
            db.SaveChanges();
            MessageBox.Show("Yeni çalışan eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
