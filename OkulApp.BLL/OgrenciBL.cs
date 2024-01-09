using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using DAL;
using System.Net;

namespace OkulApp.BLL
{
    public class OgrenciBL : IDisposable
    {
        Helper hlp = new Helper();
        public bool OgrenciEkle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = {
                             new SqlParameter("@Ad",ogr.Ad),
                             new SqlParameter("@Soyad",ogr.Soyad),
                             new SqlParameter("@Numara",ogr.Numara)
                         };
                return hlp.ExecuteNonQuery("Insert into tblOgrenciler values(@Ad,@Soyad,@Numara)", p) > 0;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool OgrenciSil(int id)
        {
            try
            {
                SqlParameter[] p = {
                            new SqlParameter("@Id",id)
                         };

                
                return hlp.ExecuteNonQuery("DELETE FROM tblOgrenciler WHERE tblOgrenciler.OgrenciId = @Id", p) > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Ogrenci OgrenciBul(string numara)
        {
            try
            {
                
                SqlParameter[] p = { new SqlParameter("@Numara", numara) };
                var dr = hlp.ExecuteReader("Select OgrenciId,Ad,Soyad,Numara from tblOgrenciler where Numara=@Numara", p);
                Ogrenci ogr = null;
                if (dr.Read())
                {
                    ogr = new Ogrenci();
                    ogr.Ad = dr["Ad"].ToString();
                    ogr.Soyad = dr["Soyad"].ToString();
                    ogr.Numara = dr["Numara"].ToString();
                    ogr.Ogrenciid = Convert.ToInt32(dr["OgrenciId"]);
                }
                dr.Close();
                return ogr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool OgrenciGuncelle(Ogrenci ogr)
        {

            try
            {
                SqlParameter[] p =
            {
                new SqlParameter("@Ad",ogr.Ad),
                new SqlParameter("@Soyad",ogr.Soyad),
                new SqlParameter("@Numara",ogr.Numara),
                new SqlParameter("@OgrenciId",ogr.Ogrenciid)
            };
                
                return hlp.ExecuteNonQuery("Update tblOgrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara where OgrenciId=@OgrenciId", p) > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public void Dispose()
        {

        }
    }
}
//n Katmanlı Mimari