using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        
        private void ArizaliUrunListele()
        {
            var degerler = from x in db.UrunKabuller
                           select new
                           {
                               x.IslemId,
                               CariAdı = x.Cariler.Ad + " " + x.Cariler.Soyad,
                               x.GelisTarihi,
                               x.CikisTarihi,
                               x.UrunSeriNo,
                               x.UrunDurumDetay
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            ArizaliUrunListele();
            lblArizaliUrunSayisi.Text = db.UrunKabuller.Count().ToString();
            lblTadilatiBitmisUrun.Text = db.UrunKabuller.Where(x => x.UrunDurum == false).Count().ToString();
            lblArizaliUrunSayisi.Text= db.UrunKabuller.Where(x => x.UrunDurum == true).Count().ToString();
            lblToplamUrunSayisi.Text= db.Urunler.Count().ToString();
            lblParcaBekleyenUrun.Text = db.UrunKabuller.Where(x => x.UrunDurumDetay =="Parça Bekliyor").Count().ToString();
            lblParcasiGelenUrun.Text = db.UrunKabuller.Where(x => x.UrunDurumDetay =="Parçası Geldi").Count().ToString();
            lblIptalIslemler.Text = db.UrunKabuller.Where(x => x.UrunDurumDetay =="Iptal Edildi").Count().ToString();


            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD6SMLP;Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT UrunDurumDetay,COUNT(*) FROM UrunKabuller GROUP BY UrunDurumDetay", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Formlar.FrmArizaDetaylar fr = new FrmArizaDetaylar();
            fr.id = gridView1.GetFocusedRowCellValue("IslemId").ToString();
            fr.seriNo = gridView1.GetFocusedRowCellValue("UrunSeriNo").ToString();
            fr.Show();
        }
    }
}
