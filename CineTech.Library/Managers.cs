using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTech.Library
{
    // ==========================================
    //            VERİTABANI BAĞLANTISI
    // ==========================================
    public static class Baglanti
    {
        public static string Adres = "Server=.;Database=CineTechDB;Integrated Security=True;TrustServerCertificate=True;";
    }

    // ==========================================
    //           KULLANICI YÖNETİMİ
    // ==========================================
    public class KullaniciManager
    {
        public void Ekle(Kullanici k)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi=@p1", baglanti);
                kontrol.Parameters.AddWithValue("@p1", k.KullaniciAdi);

                int varMi = (int)kontrol.ExecuteScalar();
                if (varMi > 0) throw new Exception("Bu kullanıcı adı zaten alınmış.");

                string sorgu = "INSERT INTO Kullanicilar (Ad, Soyad, KullaniciAdi, Sifre, Rol, Telefon, Eposta, SicilNo, Maas) VALUES (@Ad, @Soyad, @Kadi, @Sifre, @Rol, @Tel, @Mail, @Sicil, @Maas)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@Ad", k.Ad);
                komut.Parameters.AddWithValue("@Soyad", k.Soyad);
                komut.Parameters.AddWithValue("@Kadi", k.KullaniciAdi);
                komut.Parameters.AddWithValue("@Sifre", k.Sifre);
                komut.Parameters.AddWithValue("@Rol", k.RolGetir());

                if (k is Musteri)
                {
                    komut.Parameters.AddWithValue("@Tel", ((Musteri)k).Telefon ?? (object)DBNull.Value);
                    komut.Parameters.AddWithValue("@Mail", ((Musteri)k).Eposta ?? (object)DBNull.Value);
                    komut.Parameters.AddWithValue("@Sicil", DBNull.Value);
                    komut.Parameters.AddWithValue("@Maas", DBNull.Value);
                }
                else if (k is Personel)
                {
                    komut.Parameters.AddWithValue("@Tel", DBNull.Value);
                    komut.Parameters.AddWithValue("@Mail", DBNull.Value);
                    komut.Parameters.AddWithValue("@Sicil", ((Personel)k).SicilNo ?? (object)DBNull.Value);
                    komut.Parameters.AddWithValue("@Maas", ((Personel)k).Maas);
                }
                else
                {
                    komut.Parameters.AddWithValue("@Tel", DBNull.Value);
                    komut.Parameters.AddWithValue("@Mail", DBNull.Value);
                    komut.Parameters.AddWithValue("@Sicil", DBNull.Value);
                    komut.Parameters.AddWithValue("@Maas", DBNull.Value);
                }
                komut.ExecuteNonQuery();
            }
        }

        public void Sil(string kAdi)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                if (kAdi == "admin") return;
                SqlCommand komut = new SqlCommand("DELETE FROM Kullanicilar WHERE KullaniciAdi=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", kAdi);
                komut.ExecuteNonQuery();
            }
        }

        public Kullanici GirisYap(string kAdi, string sifre)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@p1 AND Sifre=@p2";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", kAdi);
                komut.Parameters.AddWithValue("@p2", sifre);

                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    string rol = dr["Rol"].ToString();
                    if (rol == "Yonetici") return new Yonetici { Ad = dr["Ad"].ToString(), Soyad = dr["Soyad"].ToString(), ID = Convert.ToInt32(dr["ID"]), Rol = "Yonetici", KullaniciAdi = dr["KullaniciAdi"].ToString() };
                    else if (rol == "Personel") return new Personel { Ad = dr["Ad"].ToString(), Soyad = dr["Soyad"].ToString(), ID = Convert.ToInt32(dr["ID"]), Rol = "Personel", KullaniciAdi = dr["KullaniciAdi"].ToString() };
                    else return new Musteri { Ad = dr["Ad"].ToString(), Soyad = dr["Soyad"].ToString(), ID = Convert.ToInt32(dr["ID"]), Rol = "Musteri", KullaniciAdi = dr["KullaniciAdi"].ToString() };
                }
                return null;
            }
        }

        public List<Kullanici> TumKullanicilar()
        {
            List<Kullanici> liste = new List<Kullanici>();
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Kullanicilar", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    string rol = dr["Rol"].ToString();
                    Kullanici k = null;
                    if (rol == "Personel") { k = new Personel(); ((Personel)k).SicilNo = dr["SicilNo"].ToString(); }
                    else if (rol == "Musteri") { k = new Musteri(); ((Musteri)k).Telefon = dr["Telefon"].ToString(); }
                    else if (rol == "Yonetici") { k = new Yonetici(); }

                    if (k != null)
                    {
                        k.ID = Convert.ToInt32(dr["ID"]);
                        k.Ad = dr["Ad"].ToString();
                        k.Soyad = dr["Soyad"].ToString();
                        k.KullaniciAdi = dr["KullaniciAdi"].ToString();
                        k.Rol = rol;
                        liste.Add(k);
                    }
                }
            }
            return liste;
        }
    }

    // ==========================================
    //              FİLM İŞLEMLERİ
    // ==========================================
    public class FilmManager
    {
        public void FilmEkle(Film f)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                string sorgu = "INSERT INTO Filmler (Ad, Yonetmen, Tur, Sure, AfisYolu) VALUES (@Ad, @Yon, @Tur, @Sure, @Afis)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Ad", f.Ad);
                komut.Parameters.AddWithValue("@Yon", f.Yonetmen);
                komut.Parameters.AddWithValue("@Tur", f.Tur);
                komut.Parameters.AddWithValue("@Sure", f.Sure);
                komut.Parameters.AddWithValue("@Afis", f.AfisYolu);
                komut.ExecuteNonQuery();
            }
        }

        public List<Film> FilmleriGetir()
        {
            List<Film> liste = new List<Film>();
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Filmler", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    liste.Add(new Film { ID = Convert.ToInt32(dr["ID"]), Ad = dr["Ad"].ToString(), Yonetmen = dr["Yonetmen"].ToString(), Tur = dr["Tur"].ToString(), Sure = Convert.ToInt32(dr["Sure"]), AfisYolu = dr["AfisYolu"].ToString() });
                }
            }
            return liste;
        }

        public void FilmSil(string filmAdi)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Filmler WHERE Ad=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", filmAdi);
                komut.ExecuteNonQuery();
            }
        }
    }

    // ==========================================
    //             SEANS İŞLEMLERİ
    // ==========================================
    public class SeansManager
    {
        public void SeansEkle(Seans s)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                string sorgu = "INSERT INTO Seanslar (FilmID, SalonAdi, Tarih, Saat) VALUES (@Fid, @Salon, @Tarih, @Saat)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Fid", s.FilmBilgisi.ID);
                komut.Parameters.AddWithValue("@Salon", s.SalonAdi);
                komut.Parameters.AddWithValue("@Tarih", s.Tarih);
                komut.Parameters.AddWithValue("@Saat", s.Saat);
                komut.ExecuteNonQuery();
            }
        }

        public List<Seans> SeanslariGetir()
        {
            List<Seans> liste = new List<Seans>();
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                string sorgu = "SELECT S.ID as SeansID, S.SalonAdi, S.Tarih, S.Saat, F.ID as FilmID, F.Ad, F.Tur, F.Sure, F.AfisYolu FROM Seanslar S INNER JOIN Filmler F ON S.FilmID = F.ID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Seans yeniSeans = new Seans { ID = Convert.ToInt32(dr["SeansID"]), SalonAdi = dr["SalonAdi"].ToString(), Tarih = Convert.ToDateTime(dr["Tarih"]), Saat = dr["Saat"].ToString() };
                    yeniSeans.FilmBilgisi = new Film { ID = Convert.ToInt32(dr["FilmID"]), Ad = dr["Ad"].ToString(), Tur = dr["Tur"].ToString(), Sure = Convert.ToInt32(dr["Sure"]), AfisYolu = dr["AfisYolu"].ToString() };
                    liste.Add(yeniSeans);
                }
            }
            return liste;
        }
    }

    // ==========================================
    //             SATIŞ İŞLEMLERİ (GÜNCELLENDİ)
    // ==========================================
    public class SatisManager
    {
        // 1. Bilet Kesme
        public void BiletKes(Bilet b, int kullaniciID)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                string sorgu = "INSERT INTO Biletler (SeansID, KullaniciID, KoltukNo, Fiyat) VALUES (@Sid, @Kid, @Koltuk, @Fiyat)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Sid", b.SeansBilgisi.ID);
                komut.Parameters.AddWithValue("@Kid", kullaniciID);
                komut.Parameters.AddWithValue("@Koltuk", b.KoltukNo);
                komut.Parameters.AddWithValue("@Fiyat", b.Fiyat);
                komut.ExecuteNonQuery();
            }
        }

        // 2. YENİ: Bilet İptal (Bakımdan çıkarmak veya bilet iadesi için)
        public void BiletIptal(int seansID, string koltukNo)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                string sorgu = "DELETE FROM Biletler WHERE SeansID=@Sid AND KoltukNo=@Koltuk";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Sid", seansID);
                komut.Parameters.AddWithValue("@Koltuk", koltukNo);
                komut.ExecuteNonQuery();
            }
        }

        // 3. Dolu Koltukları Getirme (Satılan + Bakımdakiler)
        public List<string> DoluKoltuklariGetir(Seans s)
        {
            List<string> doluKoltuklar = new List<string>();
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                string sorgu = "SELECT KoltukNo FROM Biletler WHERE SeansID = @Sid";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Sid", s.ID);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    doluKoltuklar.Add(dr["KoltukNo"].ToString());
                }
            }
            return doluKoltuklar;
        }

        // 4. YENİ: Sadece Bakımdaki Koltukları Getir (Fiyatı 0 Olanlar)
        public List<string> BakimdakiKoltuklariGetir(Seans s)
        {
            List<string> bakimdakiler = new List<string>();
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                // Fiyatı 0 olanlar "Bakım/Arızalı" kabul edilir
                string sorgu = "SELECT KoltukNo FROM Biletler WHERE SeansID = @Sid AND Fiyat = 0";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Sid", s.ID);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    bakimdakiler.Add(dr["KoltukNo"].ToString());
                }
            }
            return bakimdakiler;
        }

        // 5. Müşteri Biletleri
        public List<Bilet> MusteriBiletleriniGetir(int kullaniciID)
        {
            List<Bilet> liste = new List<Bilet>();
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                string sorgu = @"SELECT B.KoltukNo, B.Fiyat, S.Tarih, S.Saat, F.Ad 
                                 FROM Biletler B 
                                 INNER JOIN Seanslar S ON B.SeansID = S.ID 
                                 INNER JOIN Filmler F ON S.FilmID = F.ID
                                 WHERE B.KullaniciID = @Kid";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Kid", kullaniciID);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Bilet b = new Bilet();
                    b.KoltukNo = dr["KoltukNo"].ToString();
                    b.Fiyat = Convert.ToDecimal(dr["Fiyat"]);
                    b.SeansBilgisi = new Seans { Tarih = Convert.ToDateTime(dr["Tarih"]), Saat = dr["Saat"].ToString(), FilmBilgisi = new Film { Ad = dr["Ad"].ToString() } };
                    liste.Add(b);
                }
            }
            return liste;
        }

        // 6. Rapor (Tüm Satışlar)
        public List<Bilet> TumSatislariGetir()
        {
            List<Bilet> liste = new List<Bilet>();
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                string sorgu = @"SELECT B.KoltukNo, B.Fiyat, S.Tarih, S.Saat, F.Ad, K.Ad + ' ' + K.Soyad as MusteriAd 
                                 FROM Biletler B 
                                 INNER JOIN Seanslar S ON B.SeansID = S.ID 
                                 INNER JOIN Filmler F ON S.FilmID = F.ID
                                 INNER JOIN Kullanicilar K ON B.KullaniciID = K.ID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Bilet b = new Bilet();
                    b.KoltukNo = dr["KoltukNo"].ToString();
                    b.Fiyat = Convert.ToDecimal(dr["Fiyat"]);
                    b.SeansBilgisi = new Seans { Tarih = Convert.ToDateTime(dr["Tarih"]), Saat = dr["Saat"].ToString(), FilmBilgisi = new Film { Ad = dr["Ad"].ToString() } };
                    b.MusteriBilgisi = new Musteri { Ad = dr["MusteriAd"].ToString() };
                    liste.Add(b);
                }
            }
            return liste;
        }

        // 7. Toplam Hasılat
        public decimal ToplamHasilatGetir()
        {
            decimal toplam = 0;
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                baglanti.Open();
                string sorgu = "SELECT SUM(Fiyat) FROM Biletler";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                object sonuc = komut.ExecuteScalar();
                if (sonuc != DBNull.Value && sonuc != null) toplam = Convert.ToDecimal(sonuc);
            }
            return toplam;
        }
    }
}