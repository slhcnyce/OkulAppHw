using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulApp.BLL;

namespace OkulAppSube1BIL
{
    public partial class frmOgrKayit : Form
    {
        private void txtboxcleaner()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtNumara.Clear();
        }
        public int Ogrenciid { get; set; }
        public frmOgrKayit()
        {
            InitializeComponent();
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
        }       
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                bool sonuc = obl.OgrenciEkle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı!" : "Ekleme Başarısız!!");
                if (sonuc)
                {
                    txtboxcleaner();
                }
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numaralı öğrenci daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı hatası");
                        break;
                }
            }
            catch (Exception)
            {                
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }

        
        private void btnBul_Click(object sender, EventArgs e)
        {
            var frm = new frmOgrBul(this);
            frm.Show();
        }

        private void frmOgrKayit_Load(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                // MessageBox.Show(obl.OgrenciSil(Ogrenciid)? "Silme Başarılı"  : "Başarısız !");
                if (obl.OgrenciSil(Ogrenciid))
                {
                    MessageBox.Show("Silme Başarılı");
                    txtboxcleaner();
                }
                else
                {
                    MessageBox.Show("Başarısız !");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata ile karşılaşıldı:" + ex);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                //MessageBox.Show(obl.OgrenciGuncelle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim(), Ogrenciid = Ogrenciid }) ? "Güncelleme Başarılı" : "Başarısız !");
                if (obl.OgrenciGuncelle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim(), Ogrenciid = Ogrenciid }))
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    txtboxcleaner();
                }
                else
                {
                    MessageBox.Show("Başarısız !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı:" + ex);
            }
        }
    }


    interface ITransfer
    {
        int Eft(string gondericiiban, string aliciiban, double tutar);
        int Havale(string gondericiiban, string aliciiban, double tutar);

    }

    class Transfer : ITransfer
    {
        public int Eft(string gondericiiban, string aliciiban, double tutar)
        {
            throw new NotImplementedException();
        }

        public int Havale(string gondericiiban, string aliciiban, double tutar)
        {
            throw new NotImplementedException();
        }

        //
    }
}

//Garbage Collector
//öğrenci bulunma durumuna göre sil ve güncelle butonları aktifliği
//textboxların textlerinin temizlenmesi gerekir
//ogrenci bulunduğunda bul formunun kapanması
//try catchler throwlansın
//Dispose pattern - IDisposeble Interface
//Singleton Design Pattern