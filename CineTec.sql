-- 1. Veritabanýný Oluþtur
CREATE DATABASE CineTechDB;
GO

-- 2. Veritabanýný Seç
USE CineTechDB;
GO

-- 3. Kullanýcýlar Tablosu
CREATE TABLE Kullanicilar (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50),
    Soyad NVARCHAR(50),
    KullaniciAdi NVARCHAR(50),
    Sifre NVARCHAR(50),
    Rol NVARCHAR(20), -- 'Yonetici', 'Personel', 'Musteri'
    Telefon NVARCHAR(20),
    Eposta NVARCHAR(100),
    SicilNo NVARCHAR(20),
    Maas DECIMAL(18,2)
);

-- 4. Filmler Tablosu
CREATE TABLE Filmler (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(100),
    Yonetmen NVARCHAR(100),
    Tur NVARCHAR(50),
    Sure INT,
    AfisYolu NVARCHAR(MAX),
    KayitTarihi DATETIME DEFAULT GETDATE()
);

-- 5. Seanslar Tablosu
CREATE TABLE Seanslar (
    ID INT PRIMARY KEY IDENTITY(1,1),
    FilmID INT,
    SalonAdi NVARCHAR(50),
    Tarih DATE,
    Saat NVARCHAR(10),
    FOREIGN KEY (FilmID) REFERENCES Filmler(ID) ON DELETE CASCADE
);

-- 6. Biletler Tablosu
CREATE TABLE Biletler (
    ID INT PRIMARY KEY IDENTITY(1,1),
    SeansID INT,
    KoltukNo NVARCHAR(10),
    Fiyat DECIMAL(18,2),
    SatisTarihi DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (SeansID) REFERENCES Seanslar(ID) ON DELETE CASCADE
);
GO

-- 7. HAZIR VERÝLERÝ EKLE (Admin ve Personel)
INSERT INTO Kullanicilar (Ad, Soyad, KullaniciAdi, Sifre, Rol) 
VALUES ('Admin', 'Baba', 'admin', '1234', 'Yonetici');

INSERT INTO Kullanicilar (Ad, Soyad, KullaniciAdi, Sifre, Rol, SicilNo, Maas) 
VALUES ('Ahmet', 'Yýlmaz', 'personel', '1234', 'Personel', 'SICIL001', 25000);

-- Kontrol Mesajý
SELECT * FROM Kullanicilar;