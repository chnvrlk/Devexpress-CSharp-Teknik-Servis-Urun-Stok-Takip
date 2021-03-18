using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TeknikServis.Giris
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void KullaniciSifreDogrula()
        {
            int id = int.Parse(txtId.Text);
            var deger = db.Calisanlar.Find(id);                        
            string mail = txtMail.Text;

            if (Convert.ToBoolean(db.Calisanlar.Find(id)) && Convert.ToBoolean(db.Calisanlar.Find(mail)))
            {
                MailMessage mailMessage = new MailMessage();
                string kullaniciAd = "cihanvarlik98@gmail.com";
                string sifre = "Cihn06+-";
                string alici = txtMail.Text;
                string konu = "Şifre Hatırlatma Maili";
                string icerik = "Merhaba, bizden şifre hatırlatma talebinde bulundunuz.\nŞifreniz: "+ deger.Sifre+ "\nİyi günler dileriz.";
                mailMessage.From = new MailAddress(kullaniciAd);
                mailMessage.To.Add(alici);
                mailMessage.Subject = konu;
                mailMessage.Body = icerik;
                mailMessage.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(kullaniciAd, sifre);
                smtp.EnableSsl = true;
                smtp.Send(mailMessage);
                MessageBox.Show("Mail gönderildi.", "Bilgi", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Üzgünüz kullanıcı adı veya e şifreyi yanlış giriyorsunuz.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
        }

        private void btnSifreTalep_Click(object sender, EventArgs e)
        {
            KullaniciSifreDogrula();
        }
    }
}
