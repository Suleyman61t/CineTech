using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTech.Library
{
    // ==========================================
    //              ARAYÜZLER (INTERFACES)
    // ==========================================

    // Kayıt doğrulama zorunluluğu olan sınıflar için arayüz
    public interface IKayitYonetimi
    {
        bool KayitDogrula();
    }


    // ==========================================
    //           TEMEL SINIFLAR (BASE)
    // ==========================================

    // Tüm tabloların ortak atası (ID ve Tarih tutar)
    public abstract class TemelVarlik
    {
        public int ID { get; set; }

        public DateTime KayitTarihi { get; set; }

        // Kurucu Metot: Nesne oluştuğu an tarihi atar
        public TemelVarlik()
        {
            this.KayitTarihi = DateTime.Now;
        }
    }

    // Kullanıcıların ortak özelliklerini tutan soyut sınıf
    public abstract class Kullanici : TemelVarlik
    {
        private string _ad;
        private string _soyad;
        private string _sifre;

        // Ad: İlk harfi büyük, kalanı küçük yapar
        public string Ad
        {
            get { return _ad; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
                else
                    _ad = value;
            }
        }

        // Soyad: Tamamını büyük harf yapar
        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value.ToUpper(); }
        }

        public string KullaniciAdi { get; set; }

        // Şifre: En az 4 karakter kontrolü yapar
        public string Sifre
        {
            get { return _sifre; }
            set
            {
                if (value.Length < 4)
                    throw new Exception("Şifre en az 4 karakter olmalıdır!");
                _sifre = value;
            }
        }

        // Veritabanından gelen rolü tutar
        public string Rol { get; set; }

        // Miras alan sınıflar kendi rolünü döndürmek zorundadır
        public abstract string RolGetir();
    }


    // ==========================================
    //           KULLANICI TİPLERİ
    // ==========================================

    // Müşteri Sınıfı
    public class Musteri : Kullanici, IKayitYonetimi
    {
        public string Telefon { get; set; }

        public string Eposta { get; set; }

        public override string RolGetir()
        {
            return "Musteri";
        }

        // Zorunlu alanların dolu olup olmadığını kontrol eder
        public bool KayitDogrula()
        {
            if (string.IsNullOrEmpty(Ad) || string.IsNullOrEmpty(Soyad) || string.IsNullOrEmpty(KullaniciAdi))
                return false;

            return true;
        }
    }

    // Personel Sınıfı
    public class Personel : Kullanici
    {
        public string SicilNo { get; set; }

        public decimal Maas { get; set; }

        public override string RolGetir()
        {
            return "Personel";
        }
    }

    // Yönetici Sınıfı (Personel'den türer)
    public class Yonetici : Personel
    {
        public override string RolGetir()
        {
            return "Yonetici";
        }
    }


    // ==========================================
    //           SİNEMA VARLIKLARI
    // ==========================================

    public class Film : TemelVarlik
    {
        public string Ad { get; set; }

        public string Yonetmen { get; set; }

        public string Tur { get; set; }

        public int Sure { get; set; }

        public string AfisYolu { get; set; }
    }

    public class Seans : TemelVarlik
    {
        public Film FilmBilgisi { get; set; }

        public string SalonAdi { get; set; }

        public DateTime Tarih { get; set; }

        public string Saat { get; set; }
    }

    public class Bilet : TemelVarlik
    {
        public Seans SeansBilgisi { get; set; }

        public Musteri MusteriBilgisi { get; set; }

        public string KoltukNo { get; set; }

        public decimal Fiyat { get; set; }
    }
}