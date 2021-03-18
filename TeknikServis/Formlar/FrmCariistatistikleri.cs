using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServis.Formlar
{
    public partial class FrmCariistatistikleri : Form
    {
        public FrmCariistatistikleri()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HD6SMLP;Initial Catalog=DbTeknikServis;Integrated Security=True");
        private void FrmCariistatistikleri_Load(object sender, EventArgs e)
        {

            gridControl1.DataSource = db.Cariler.OrderBy(x => x.Il).
                GroupBy(y => y.Il).
                Select(z => new { İL = z.Key, TOPLAM = z.Count() }).ToList();


            baglanti.Open();
            SqlCommand command = new SqlCommand("select IL,COUNT(*) FROM Cariler group by IL", baglanti);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
               chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));               
            }
            baglanti.Close();
        }
    }
}
