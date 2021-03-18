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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSeriNo.Text!=null && txtSeriNo.Text.Length==5 && lookUpId.EditValue!=null && cbxUrunDurumDetay.Text!=null)
            {
                UrunKabuller urunKabuller = new UrunKabuller();
                urunKabuller.Musteri = int.Parse(lookUpId.EditValue.ToString());
                urunKabuller.GelisTarihi = DateTime.Parse(txtTarih.Text);
                urunKabuller.UrunSeriNo = txtSeriNo.Text;
                urunKabuller.UrunDurum = true;
                urunKabuller.UrunDurumDetay = cbxUrunDurumDetay.Text;
                db.UrunKabuller.Add(urunKabuller);
                db.SaveChanges();
                MessageBox.Show("Arızalı ürün kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            lookUpId.Properties.DataSource = (from x in db.Cariler
                                                 select new
                                                 {
                                                     x.Id,
                                                     Ad= x.Ad + " " + x.Soyad
                                                 }).ToList();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
