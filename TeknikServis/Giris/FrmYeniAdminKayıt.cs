using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Giris
{
    public partial class FrmYeniAdminKayıt : Form
    {
        public FrmYeniAdminKayıt()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmYeniAdminKayıt_Load(object sender, EventArgs e)
        {
            lookUpEdit2.Properties.DataSource = (from x in db.Roller
                                                 select new
                                                 {
                                                     Id =x.RoleId,
                                                     Ad =x.RoleName
                                                 }).ToList();
            lookUpEdit1.Properties.DataSource = (from y in db.Bolumler
                                                 select new
                                                 {
                                                    Id =y.Id,
                                                    Ad =y.Bölüm,
                                                 }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Length>=3 && txtSoyad!=null && txtSoyad.Text.Length>=4 && txtSifre.Text == txtSifreTekrar.Text
                && txtMail.Text!=null && txtKullaniciAdi.Text.Length>=5 && txtSifre.Text.Length>=5
                && txtTelefon.Text!=null && lookUpEdit1.EditValue!=null && lookUpEdit2.EditValue!=null)
            {

                Calisanlar calisan = new Calisanlar();
                calisan.Ad = txtAd.Text;
                calisan.Soyad = txtSoyad.Text;
                calisan.KullaniciAdı = txtKullaniciAdi.Text;
                calisan.Sifre = txtSifre.Text;
                calisan.Mail = txtMail.Text;
                calisan.RoleId = int.Parse(lookUpEdit2.EditValue.ToString());
                calisan.Bölüm = int.Parse(lookUpEdit2.EditValue.ToString());
                calisan.Telefon = txtTelefon.Text;
                db.Calisanlar.Add(calisan);
                db.SaveChanges();
                MessageBox.Show("Kayıt başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Lütfen bütün alanları eksiksiz bir şekilde doldurun, aksi taktirde kayıt yapılamayacaktır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
