using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace TeknikServis.Formlar
{
    public partial class FrmBarcode : Form
    {
        public FrmBarcode()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtBarkodOlustur.Text != null)
            {
                BarcodeWriter barcodeWriter = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                pictureEdit1.Image = barcodeWriter.Write(txtBarkodOlustur.Text);
            }
            else
                MessageBox.Show("Barkod girip öyle tıklayınız.","Hata");
        }

        private void btnBarkodOku_Click(object sender, EventArgs e)
        {
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode((Bitmap)pictureEdit1.Image);
            if (result != null)
                txtBarkodOku.Text = result.Text;
        }

        private void FrmBarcode_Load(object sender, EventArgs e)
        {

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
