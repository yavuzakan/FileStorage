using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileStorage
{
    class data
    {
        public static SQLiteConnection conn;
        public static SQLiteCommand cmd;
        public static SQLiteDataReader dr;


        public static string path = File.ReadAllText(@"data.txt", Encoding.UTF8);
        public static string cs = @"URI=file:" + path;

        //Login fonksiyonu.
        public static string giris(String mail, String sifre)
        {
            string cevap = "0";
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "select * FROM user where mail LIKE '" + mail + "' and sifre LIKE'" + sifre + "'";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Form1.userid = dr.GetValue(0).ToString();
                Form1.mail = dr.GetValue(1).ToString();
                Form1.sifre = dr.GetValue(2).ToString();
                Form1.kadro = dr.GetValue(5).ToString();
                Form1.ad = dr.GetValue(3).ToString();
                Form1.depart = dr.GetValue(7).ToString();
                cevap = "1";
            }
            con.Close();
            return cevap;
        }
        //Evrakları Yükleme fonksiyonu
        public static void evrakYukle(string klasor, string dosya, string tarih, string yukle,string durum2)
        {
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "INSERT INTO evrakYukle(klasor,dosya,tarih,yukle,durum2) VALUES(@klasor,@dosya,@tarih,@yukle,@durum2)";
                cmd.Parameters.AddWithValue("@klasor", klasor);
                cmd.Parameters.AddWithValue("@dosya", dosya);
                cmd.Parameters.AddWithValue("@tarih", tarih);
                cmd.Parameters.AddWithValue("@yukle", yukle);
                cmd.Parameters.AddWithValue("@durum2", durum2);
                cmd.ExecuteNonQuery();
                con.Close();
                dosyaYukle.sonuc = "OLUMLU";
            }
            catch (Exception e)
            {
                //   MessageBox.Show(e.Message.ToString());
            }
        }

        //Kullanıcı Ekle
        public static void useradd(string mail, string sifre, string ad, string kimlikno, string kadro, string statu, string depart)
        {
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "INSERT INTO user(mail,sifre,ad,kimlikno,kadro,statu,depart) VALUES(@mail,@sifre,@ad,@kimlikno,@kadro,@statu,@depart)";
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@kimlikno", kimlikno);
                cmd.Parameters.AddWithValue("@kadro", kadro);
                cmd.Parameters.AddWithValue("@statu", statu);
                cmd.Parameters.AddWithValue("@depart", depart);

                cmd.ExecuteNonQuery();
                con.Close();
                kulEkle.sonuc = "OLUMLU";
            }
            catch (Exception e)
            {
                //   MessageBox.Show(e.Message.ToString());
            }
        }

        //
        public static void userupdate(string mail, string sifre, string ad, string kimlikno, string kadro, string statu, string depart, string id)
        {
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                string sql = "UPDATE user set mail='" + mail + "' , sifre='" + sifre + "', ad='" + ad + "' , kimlikno='" + kimlikno + "', kadro='" + kadro + "', statu='" + statu + "', depart='" + depart + "'   where id = " + id;
                cmd.CommandText = sql;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                con.Close();
                kulDuzenle.sonuc = "OLUMLU";
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }
        //
        public static void evrakSayi(string durum, string id)
        {
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                string sql = "UPDATE evrakYukle set durum='" + durum + "' where id = " + id;
                cmd.CommandText = sql;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                con.Close();
                //Form7.sonuc = "OLUMLU";
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }

        }
        //
        public static void evrakBilgi(string evrakId, string evrakAd, string info1, string info2, string info3, string info4, string info5, string info6, string info7, string info8 , string info9,string info10)
        {
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "INSERT INTO evrakBilgi(evrakId,evrakAd,info1,info2,info3,info4,info5,info6,info7,info8,info9,info10) VALUES(@evrakId,@evrakAd,@info1,@info2,@info3,@info4,@info5,@info6,@info7,@info8,@info9,@info10)";
                cmd.Parameters.AddWithValue("@evrakId", evrakId);
                cmd.Parameters.AddWithValue("@evrakAd", evrakAd);
                cmd.Parameters.AddWithValue("@info1", info1);
                cmd.Parameters.AddWithValue("@info2", info2);
                cmd.Parameters.AddWithValue("@info3", info3);
                cmd.Parameters.AddWithValue("@info4", info4);
                cmd.Parameters.AddWithValue("@info5", info5);
                cmd.Parameters.AddWithValue("@info6", info6);
                cmd.Parameters.AddWithValue("@info7", info7);
                cmd.Parameters.AddWithValue("@info8", info8);
                cmd.Parameters.AddWithValue("@info9", info9);
                cmd.Parameters.AddWithValue("@info10", info10);
                cmd.ExecuteNonQuery();
                con.Close();
                kulEkle.sonuc = "OLUMLU";
            }
            catch (Exception e)
            {
                //   MessageBox.Show(e.Message.ToString());
            }
        }


    }
}
