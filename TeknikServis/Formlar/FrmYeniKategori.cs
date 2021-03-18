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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }

        private void FrmYeniKategori_Load(object sender, EventArgs e)
        {

        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdi.Text != "" && txtKategoriAdi.Text.Length <= 30)
            {
                Kategoriler kategori = new Kategoriler();
                kategori.Ad = txtKategoriAdi.Text;
                db.Kategoriler.Add(kategori);
                db.SaveChanges();
                MessageBox.Show("Kategori başarıyla kaydedildi.");
                
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez ve Kategori Adı 30 Karakterden Fazla Olamaz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
