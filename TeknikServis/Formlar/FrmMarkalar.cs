using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD6SMLP;Initial Catalog=DbTeknikServis;Integrated Security=True");

        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.Urunler.OrderBy(x => x.Marka).GroupBy(y => y.Marka)
                .Select(z => new
                {
                   Marka = z.Key,
                   Toplam = z.Count()
                });
            gridControl1.DataSource = degerler.ToList();
            lblToplamUrun.Text = db.Urunler.Count().ToString();
            lblToplamMarka.Text = (from x in db.Urunler
                                   select x.Marka).Distinct().Count().ToString();
            lblEnYüksekFiyatliMarka.Text = (from x in db.Urunler
                                            orderby x.Satis descending
                                            select x.Marka).FirstOrDefault();
            //lblEnFazlaUrunluMarka.Text = db.maxmarkaurunu().FirstOrDefault();

            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT Marka,COUNT(*) FROM Urunler GROUP BY Marka", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT Kategoriler.Ad,COUNT(*) FROM Urunl INNER JOIN Kategoriler ON Kategoriler.Id = Urunler.KategoriId GROUP BY Kategoriler.Ad",baglanti);
            SqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            baglanti.Close();

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }
    }
}
