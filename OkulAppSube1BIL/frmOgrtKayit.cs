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
using OkulApp.MODEL;

namespace OkulAppSube1BIL
{
    public partial class frmOgrtKayit : Form
    {
        public frmOgrtKayit()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                bool sonuc = obl.OgretmenEkle(new Ogretmen { Ad = txtOgrtAd.Text.Trim(), Soyad = txtOgrtSoyad.Text.Trim(), Tc = txtOgrtTc.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı!" : "Ekleme Başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numaralı öğretmen daha önce kayıtlı");
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
    }
    }
