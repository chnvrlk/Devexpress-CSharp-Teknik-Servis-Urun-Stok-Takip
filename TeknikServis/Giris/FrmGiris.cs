using NLog;
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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        Logger logger = LogManager.GetCurrentClassLogger();
        private void FrmGiris_Load(object sender, EventArgs e)
        {
            
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adınızı giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
             using (var db = new DbTeknikServisEntities1())
             {
                var rec = db.Calisanlar.Where(u => u.KullaniciAdı == txtUsername.Text && u.Sifre == txtPassword.Text).FirstOrDefault();
                if (rec != null)
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {                    
                    logger.Error("Kullanıcı hatalı giriş yaptı.");
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }                 
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = Convert.ToChar("*");
        }
       
        private void labelControl3_Click(object sender, EventArgs e)
        {
          

        }

        private void lnkSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FrmSifremiUnuttum frmSifre = new FrmSifremiUnuttum();
            frmSifre.Show();
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void btnKayit_Click_1(object sender, EventArgs e)
        {
            FrmYeniAdminKayıt frmYeniKayit = new FrmYeniAdminKayıt();
            frmYeniKayit.Show();
        }
    }
}
