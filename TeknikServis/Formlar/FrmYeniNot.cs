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
    public partial class FrmYeniNot : Form
    {
        public FrmYeniNot()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Notlar notlar = new Notlar();
            notlar.Baslik = txtBaslik.Text;
            notlar.Icerik = txtIcerik.Text;
            notlar.Tarih = DateTime.Parse(txtTarih.Text);
            notlar.Durum = false;
            db.Notlar.Add(notlar);
            db.SaveChanges();
            MessageBox.Show("Not başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortTimeString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYeniNot_Load(object sender, EventArgs e)
        {

        }

        private void txtBaslik_Click(object sender, EventArgs e)
        {
            txtBaslik.Text = "";
        }

        private void txtIcerik_Click(object sender, EventArgs e)
        {
            txtIcerik.Text = "";
        }

        private void pictureEdit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
