using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.ILETISIMKlasoru
{
    public partial class FrmCariBilgileri : Form
    {
        public FrmCariBilgileri()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmCariBilgileri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Cariler
                                       select new
                                       {
                                           x.Id,
                                           x.Ad,
                                           x.Soyad,
                                           x.Telefon,
                                           x.Mail
                                       }).ToList();
        }
    }
}
