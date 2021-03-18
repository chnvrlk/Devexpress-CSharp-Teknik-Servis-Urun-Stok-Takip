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

namespace TeknikServis.ILETISIMKlasoru
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void FrmMail_Load(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mailMessage = new MailMessage();
            string kullaniciAd = "cihanvarlik98@gmail.com";
            string sifre = "Cihn06+-";
            string alici = txtAlici.Text;
            string konu = txtKonu.Text;
            string icerik = textBox1.Text;
            mailMessage.From = new MailAddress(kullaniciAd);
            mailMessage.To.Add(alici);
            mailMessage.Subject = konu;
            mailMessage.Body = icerik;
            mailMessage.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
            smtp.Credentials = new NetworkCredential(kullaniciAd, sifre);
            smtp.EnableSsl = true;
            smtp.Send(mailMessage);
            MessageBox.Show("Mail gönderildi.", "Bilgi", MessageBoxButtons.OK);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit8_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
