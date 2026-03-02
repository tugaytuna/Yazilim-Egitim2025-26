
USE Eticaret1


CREATE TABLE  Urunler(
UrunId INT PRIMARY KEY IDENTITY(1,1),
UrunAd NVARCHAR(50),
Kategori NVARCHAR(50),
Fiyat DECIMAL,
Stok INT,
);


INSERT INTO Urunler (UrunAd, Kategori, Fiyat) VALUES
('Klasik Beyaz Tişört', 'Giyim', 199.90)

INSERT INTO Urunler (UrunAd, Kategori, Fiyat, Stok) VALUES
('Klasik Beyaz Tişört', 'Giyim', 199.90, 120),
('Siyah Kapüşonlu Sweatshirt', 'Giyim', 399.90, 75),
('Mavi Kot Pantolon', 'Giyim', 549.90, 60),
('Spor Ayakkabı', 'Ayakkabı', 899.90, 45),
('Deri Cüzdan', 'Aksesuar', 249.90, 90),
('Güneş Gözlüğü', 'Aksesuar', 329.90, 50),
('Kablosuz Kulaklık', 'Elektronik', 1299.90, 35),
('Bluetooth Hoparlör', 'Elektronik', 999.90, 40),
('Akıllı Saat', 'Elektronik', 2499.90, 25),
('Laptop Çantası', 'Elektronik', 459.90, 55),
('Beyaz Spor Çorap', 'Giyim', 79.90, 200),
('Koşu Şortu', 'Giyim', 179.90, 110),
('Termos 500ml', 'Ev & Yaşam', 149.90, 85),
('Seramik Kahve Kupası', 'Ev & Yaşam', 89.90, 140),
('LED Masa Lambası', 'Ev & Yaşam', 299.90, 70),
('Defter A5', 'Kırtasiye', 49.90, 300),
('Tükenmez Kalem Seti', 'Kırtasiye', 59.90, 250),
('Sırt Çantası', 'Aksesuar', 499.90, 65),
('Telefon Kılıfı', 'Elektronik', 129.90, 150),
('Powerbank 10000mAh', 'Elektronik', 349.90, 80);



SELECT UrunAd,Kategori,Fiyat,Stok 
FROM Urunler
WHERE Kategori = 'Elektronik'
ORDER BY Fiyat DESC


SELECT * FROM Urunler
ORDER BY Stok

UPDATE Urunler
SET Stok = 0
WHERE UrunId = 21



SELECT Kategori, Count(*), CAST(AVG(Fiyat) AS INT)
FROM Urunler
GROUP BY Kategori

SELECT Kategori, Count(*), FLOOR(AVG(Fiyat))
FROM Urunler
GROUP BY Kategori

SELECT Kategori, Count(*), ROUND(AVG(Fiyat),0)
FROM Urunler
GROUP BY Kategori

SELECT Kategori, Count(*), CAST(AVG(Fiyat) AS DECIMAL)
FROM Urunler
GROUP BY Kategori

SELECT UPPER(Kategori), Count(*) AS 'Ürün Sayısı', LEFT(AVG(Fiyat),5) AS 'Ortalama Fiyat'
FROM Urunler
GROUP BY Kategori


SELECT * FROM Urunler


CREATE TABLE Siparisler(
	SiparisId INT PRIMARY KEY IDENTITY(1,1),
	UrunId INT NOT NULL,
	Adet INT NOT NULL,
	SiparisTarihi DATETIME DEFAULT GETDATE(),

	CONSTRAINT FK_Siparisler_Urunler
	FOREIGN KEY (UrunId)
	REFERENCES Urunler(UrunId)

)


INSERT INTO Siparisler (UrunId, Adet, SiparisTarihi) VALUES
(1, 2, '2026-03-01 10:15:00'),
(4, 1, '2026-03-01 14:30:00'),
(7, 3, '2026-02-28 09:45:00'),
(12, 5, '2026-02-27 16:20:00'),
(19, 2, '2026-02-26 11:05:00');


INSERT INTO Siparisler (UrunId, Adet, SiparisTarihi) VALUES
(81, 2, '2026-03-01 10:15:00'),
(84, 1, '2026-03-01 14:30:00'),
(87, 3, '2026-02-28 09:45:00'),
(92, 5, '2026-02-27 16:20:00'),
(99, 2, '2026-02-26 11:05:00');

SELECT S.SiparisId, U.UrunAd , Adet, U.Fiyat, SiparisTarihi 
FROM Siparisler S
INNER JOIN Urunler U
ON S.UrunId = U.UrunId

SELECT * FROM Urunler
ORDER BY UrunId