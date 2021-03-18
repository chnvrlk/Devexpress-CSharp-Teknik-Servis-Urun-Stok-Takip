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
    public partial class FrmArizaDetaylar : Form
    {
        public FrmArizaDetaylar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {           
                UrunKabuller urunKabuller = new UrunKabuller();
                int urunid = int.Parse(id.ToString());
                var deger = db.UrunKabuller.Find(urunid);
                deger.UrunDurumDetay = cmbUrunDurumDetay.Text;
                MessageBox.Show("Arızalı ürün durumu güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.SaveChanges();     
        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSeriNo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSeriNo_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
            
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
        public string id,seriNo;
        private void FrmArizaDetaylar_Load(object sender, EventArgs e)
        {
            txtSeriNo.Text = seriNo;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
           
        }
    }
}
