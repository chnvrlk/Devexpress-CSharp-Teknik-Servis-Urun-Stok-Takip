using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using TeknikServis.ILETISIMKlasoru;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServis.Giris;

namespace TeknikServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Formlar.FrmUrunListesi frmUrunListesi;
        private void btnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunListesi == null || frmUrunListesi.IsDisposed)
            {
                frmUrunListesi = new Formlar.FrmUrunListesi();
                frmUrunListesi.MdiParent = this;
                frmUrunListesi.Show();
            } 
        }
        Formlar.FrmCariListesi frmCariListesi;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCariListesi == null || frmCariListesi.IsDisposed)
            {
                frmCariListesi = new Formlar.FrmCariListesi();
                frmCariListesi.MdiParent = this;
                frmCariListesi.Show();
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        Formlar.FrmYeniUrun frmYeniUrun;
        private void btnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniUrun == null || frmYeniUrun.IsDisposed)
            {
                frmYeniUrun= new Formlar.FrmYeniUrun();
                frmYeniUrun.Show();
            }
        }

        Formlar.FrmKategori frmKategori;
        private void btnKategoriListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKategori ==null || frmKategori.IsDisposed)
            {
                frmKategori = new Formlar.FrmKategori();
                frmKategori.MdiParent = this;
                frmKategori.Show();
            }
            
        }
        Formlar.FrmYeniKategori frmYeniKategori;
        private void btnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniKategori==null || frmYeniKategori.IsDisposed)
            {
                frmYeniKategori = new Formlar.FrmYeniKategori();
                frmYeniKategori.Show();
            }
            
        }

        Formlar.FrmIstatistik frmIstatistik;
        private void btnIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmIstatistik == null || frmIstatistik.IsDisposed)
            {
                frmIstatistik = new Formlar.FrmIstatistik();
                frmIstatistik.MdiParent = this;
                frmIstatistik.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            
        }
        Formlar.FrmMarkalar frmMarkalar;
        private void btnMarkaIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMarkalar == null || frmMarkalar.IsDisposed)
            {
                frmMarkalar= new Formlar.FrmMarkalar();
                frmMarkalar.MdiParent = this;
                frmMarkalar.Show();
            }
        }
        Formlar.FrmCariistatistikleri frmCariistatistikleri;
        private void btnCariistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCariistatistikleri==null || frmCariistatistikleri.IsDisposed)
            {
                frmCariistatistikleri = new Formlar.FrmCariistatistikleri();
                frmCariistatistikleri.MdiParent = this;
                frmCariistatistikleri.Show();
            }
            
        }

        private void btnFrmYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniCariEkle frmYeniCariEkle = new Formlar.FrmYeniCariEkle();
            frmYeniCariEkle.Show();
        }

        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
        Formlar.FrmKurlar frmKurlar;
        private void btnDovizKurlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKurlar == null || frmKurlar.IsDisposed)
            {
                frmKurlar = new Formlar.FrmKurlar();
                frmKurlar.MdiParent = this;
                frmKurlar.Show();
            }
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void btnHaberler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYoutube frmYoutube = new Formlar.FrmYoutube();
            frmYoutube.MdiParent = this;
            frmYoutube.Show();
        }
        Formlar.FrmNotlar frmNotlar;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmNotlar==null || frmNotlar.IsDisposed)
            {
                frmNotlar = new Formlar.FrmNotlar();
                frmNotlar.MdiParent = this;
                frmNotlar.Show();
            }
             
        }
        Formlar.FrmYeniNot frmYeniNot;
        private void btnYeniNot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniNot == null || frmYeniNot.IsDisposed)
            {
                frmYeniNot = new Formlar.FrmYeniNot();
                frmYeniNot.Show();
            }
        }
        Formlar.FrmArizaListesi frmArizaListesi;
        private void btnArizaliUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmArizaListesi==null || frmArizaListesi.IsDisposed)
            {
                frmArizaListesi = new Formlar.FrmArizaListesi();
                frmArizaListesi.MdiParent = this;
                frmArizaListesi.Show();
            }           
        }

        private void btnYeniPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        Formlar.FrmCalisanlar frmCalisanlar;
        private void btnCalisanList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCalisanlar == null || frmCalisanlar.IsDisposed)
            {
                frmCalisanlar = new Formlar.FrmCalisanlar();
                frmCalisanlar.MdiParent = this;
                frmCalisanlar.Show();
            }
        }
        Formlar.FrmYeniCalisan frmYeniCalisan;
        private void btnYeniCalisan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniCalisan == null || frmYeniCalisan.IsDisposed)
            {
                frmYeniCalisan = new Formlar.FrmYeniCalisan();
                frmYeniCalisan.Show();
            }
        }
        Formlar.FrmBölüm frmBolum;
        private void btnBolumList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmBolum == null || frmBolum.IsDisposed)
            {
                frmBolum = new Formlar.FrmBölüm();
                frmBolum.MdiParent = this;
                frmBolum.Show();
            }
        }
        Formlar.FrmÜrünSatış frmÜrünSatış;
        private void btnYeniUrunSatıs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmÜrünSatış==null || frmÜrünSatış.IsDisposed )
            {
                frmÜrünSatış = new Formlar.FrmÜrünSatış();
                frmÜrünSatış.Show();
            }
            
        }
        Formlar.FrmSatislar frmSatislar;
        private void btnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (frmSatislar == null || frmSatislar.IsDisposed)
            {
                frmSatislar=new Formlar.FrmSatislar();
                frmSatislar.MdiParent = this;
                frmSatislar.Show();
            }
        }
        Formlar.FrmArizaliUrunKaydi frArizaUrunKaydi;
        private void btnYeniArizali_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frArizaUrunKaydi == null || frArizaUrunKaydi.IsDisposed)
            {
                frArizaUrunKaydi = new Formlar.FrmArizaliUrunKaydi();
                frArizaUrunKaydi.Show();
            }
        }
        Formlar.FrmArizaDetaylar frArizaDetaylar;
        private void btnArizaliAciklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frArizaDetaylar == null || frArizaDetaylar.IsDisposed)
            {
                frArizaDetaylar = new Formlar.FrmArizaDetaylar();
                frArizaDetaylar.Show();
            }
        }
        Formlar.FrmArizaliUrunDetayListesi frmArizaliUrunDetay;
        private void btnArizaliUrunDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmArizaliUrunDetay == null || frmArizaliUrunDetay.IsDisposed)
            {
                frmArizaliUrunDetay = new Formlar.FrmArizaliUrunDetayListesi();
                frmArizaliUrunDetay.MdiParent = this;
                frmArizaliUrunDetay.Show();
            }
        }
        Formlar.FrmQRCode frmQRCode;
        private void btnQRCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmQRCode == null || frmQRCode.IsDisposed)
            {
                frmQRCode = new Formlar.FrmQRCode();
                frmQRCode.Show();
            }
        }
        Formlar.FrmFaturaListesi frmFaturaListesi;
        private void btnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFaturaListesi == null || frmFaturaListesi.IsDisposed)
            {
                frmFaturaListesi = new Formlar.FrmFaturaListesi();
                frmFaturaListesi.MdiParent = this;
                frmFaturaListesi.Show();
            }
        }
        Formlar.FrmFaturaKalem frmFaturaKalem;
        private void btnFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFaturaKalem == null || frmFaturaKalem.IsDisposed)
            {
                frmFaturaKalem = new Formlar.FrmFaturaKalem();
                frmFaturaKalem.MdiParent = this;
                frmFaturaKalem.Show();
            }
        }

        private void btnFaturaKalemListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
        Formlar.FrmGauge frmGauge;
        private void btnGauge_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGauge == null || frmGauge.IsDisposed)
            {
                frmGauge = new Formlar.FrmGauge();
                frmGauge.Show();
            }
        }
        Formlar.FrmHaritalar frmHaritalar;
        private void btnHaritalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmHaritalar == null || frmHaritalar.IsDisposed)
            {
                frmHaritalar= new Formlar.FrmHaritalar();
                frmHaritalar.MdiParent = this;
                frmHaritalar.Show();
            }
        }

        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        Formlar.FrmAnasayfa frmAnasayfa;
        private void btnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (frmAnasayfa ==null || frmAnasayfa.IsDisposed)
            {
                frmAnasayfa = new Formlar.FrmAnasayfa();
                frmAnasayfa.MdiParent = this;
                frmAnasayfa.Show();
            }
        }
        ILETISIMKlasoru.FrmCariBilgileri frmCariBilgileri;
        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCariBilgileri == null || frmCariBilgileri.IsDisposed)
            {
                frmCariBilgileri = new ILETISIMKlasoru.FrmCariBilgileri();
                frmCariBilgileri.MdiParent = this;
                frmCariBilgileri.Show();
            }
        }
        ILETISIMKlasoru.FrmGelenMesajlar gelenMesajlar;
        private void btnGelenMesajlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gelenMesajlar == null || gelenMesajlar.IsDisposed)
            {
                gelenMesajlar = new ILETISIMKlasoru.FrmGelenMesajlar();
                gelenMesajlar.MdiParent = this;
                gelenMesajlar.Show();
            }
        }
        ILETISIMKlasoru.FrmMail frmMail;
        private void btnYeniMail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMail == null || frmMail.IsDisposed)
            {
                frmMail = new ILETISIMKlasoru.FrmMail();               
                frmMail.Show();
            }
        }

        private void btnUrunAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCariPersonelHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        Formlar.FrmBarcode frmBarkod;
        private void btnBarkodOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmBarkod == null || frmBarkod.IsDisposed)
            {
                frmBarkod = new Formlar.FrmBarcode();
                frmBarkod.Show();
            }
        }

        private void btnYardim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
