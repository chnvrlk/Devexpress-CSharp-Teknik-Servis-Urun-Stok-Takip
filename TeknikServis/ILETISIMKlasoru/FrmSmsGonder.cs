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
using WhatsAppApi;

namespace TeknikServis.ILETISIMKlasoru
{
    public partial class FrmSmsGonder : Form
    {
        public FrmSmsGonder()
        {
            InitializeComponent();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSmsGonder_Load(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            WhatsApp wa = new WhatsApp(txtTelefon.Text, txtPassword.Text, txtIsım.Text, true);
            wa.OnConnectSuccess += () =>
            {
                txtDurum.Text = "Bağlandıı..";
                wa.OnLoginSuccess += (phone, data) =>
                {
                    txtDurum.Text += "\r\n Bağlantı başarılı!";
                    wa.SendMessage(txtKime.Text, txtMesaj.Text);
                    txtDurum.Text += "\r\n Mesaj gönderildi";
                };
                wa.OnLoginFailed += (data) =>
                {
                    txtDurum.Text += string.Format("\r\n Giriş başarısız {0}",data);
                };
                wa.Login();
            };
            wa.OnConnectFailed += (ex) =>
            {
                txtDurum.Text += string.Format("\r\n Bağlantı başarısız {0}", ex.StackTrace);
            };
            wa.Connect();
        }

        private void txtMesaj_Click(object sender, EventArgs e)
        {
            txtMesaj.Text = "";
            txtDurum.Text = "";
        }
    }
}
