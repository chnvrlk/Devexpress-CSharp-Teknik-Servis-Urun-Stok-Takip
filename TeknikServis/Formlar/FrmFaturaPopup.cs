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
    public partial class FrmFaturaPopup : Form
    {
        public FrmFaturaPopup()
        {
            InitializeComponent();
        }

        public int id;
        private void FrmFaturaPopup_Load(object sender, EventArgs e)
        {
            DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
            gridControl1.DataSource =(from x in db.FaturaDetaylar.Where(y=>y.FaturaId== id)
                                      select new
                                      {
                                          x.FaturaDetayId,
                                          x.Urun,
                                          x.Adet,
                                          x.Fiyat,
                                          x.Tutar,
                                          x.FaturaId
                                      }).ToList();
            gridControl2.DataSource = (from f in db.Faturalar.Where(z => z.Id == id)
                                       select new
                                       {
                                         f.Id,
                                         f.SiraNo,
                                         f.Cariler.Ad,
                                         f.Tarih,
                                         f.VergiDaire                                         
                                       }).ToList();

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string pdf = "Fatura.Pdf";
            gridControl1.ExportToPdf(pdf);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string excel = "Fatura.Xlsx";
            gridControl1.ExportToXlsx(excel);
        }
    }
}
