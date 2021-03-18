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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void OkunmusNotListele()
        {
            gridControl1.DataSource = db.Notlar.Where(x => x.Durum == false).ToList();
        }
        private void OkunmamisNotListele()
        {
            gridControl2.DataSource = db.Notlar.Where(y => y.Durum == true).ToList();
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            OkunmusNotListele();
            OkunmamisNotListele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            OkunmusNotListele();
            OkunmamisNotListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked==true)
            {
                int id = int.Parse(txtId.Text);
                var deger = db.Notlar.Find(id);
                deger.Durum = true;               
                db.SaveChanges();
                MessageBox.Show("Not okundu olarak işaretlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtBaslik.Text = gridView1.GetFocusedRowCellValue("Baslik").ToString();
            txtIcerik.Text = gridView1.GetFocusedRowCellValue("Icerik").ToString();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
        }

        private void btnNotGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBaslik.Text!=null && txtIcerik.Text!=null)
            {
                int id = int.Parse(txtId.Text);
                var deger = db.Notlar.Find(id);
                deger.Icerik = txtIcerik.Text;
                deger.Baslik = txtBaslik.Text;
                deger.Tarih = DateTime.Parse(txtTarih.Text);
                deger.Durum = checkEdit1.Checked;
                db.SaveChanges();
                MessageBox.Show("Not başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Boş not girmeyiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
