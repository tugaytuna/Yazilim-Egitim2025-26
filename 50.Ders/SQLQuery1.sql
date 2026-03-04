



USE Market

CREATE TABLE Urunler (
	UrunId INT PRIMARY KEY IDENTITY(1000,1),
	UrunAdi NVARCHAR(50) NOT NULL,
	UrunAciklamasi NVARCHAR(100),
	Kategori NVARCHAR(50),
	Fiyat DECIMAL(10,2),
	Stok INT,
	Sube NVARCHAR(50),
	Kampanya BIT
)

DROP TABLE Urunler

SELECT * FROM Urunler


INSERT INTO Urunler (UrunAdi, UrunAciklamasi, Kategori, Fiyat, Stok, Sube, Kampanya) VALUES
('Domestos Çamaşır Suyu 1L', 'Güçlü temizlik ve hijyen', 'Temizlik', 35.50, 200, 'Merkez', 1),
('Finish Bulaşık Tableti 30lı', 'Etkili bulaşık temizliği', 'Temizlik', 120.00, 80, 'Şube 1', 0),
('Pringles Tuzlu', 'Klasik tuzlu cips', 'Aburcubur', 25.00, 150, 'Merkez', 1),
('Coca Cola 1L', 'Klasik gazlı içecek', 'İçecek', 22.50, 180, 'Şube 2', 0),
('Eti Burçak Bisküvi', 'Lezzetli tam buğday bisküvi', 'Aburcubur', 12.00, 300, 'Merkez', 1),
('Torku Süt 1L', 'Taze günlük süt', 'Kahvaltılık', 18.00, 250, 'Şube 1', 0),
('Domestos Dezenfektan 500ml', 'Hijyen için güçlü dezenfektan', 'Temizlik', 40.00, 120, 'Merkez', 1),
('Ülker Çikolatalı Gofret', 'Lezzetli çikolatalı atıştırmalık', 'Aburcubur', 5.50, 500, 'Şube 2', 0),
('Pepsi 1L', 'Klasik gazlı içecek', 'İçecek', 21.00, 160, 'Merkez', 1),
('Eti Kakaolu Bisküvi', 'Kakaolu nefis bisküvi', 'Aburcubur', 11.00, 300, 'Şube 1', 0),
('Lipton Ice Tea 1L', 'Soğuk çay içeceği', 'İçecek', 19.50, 140, 'Merkez', 1),
('Sütaş Yoğurt 1kg', 'Taze günlük yoğurt', 'Kahvaltılık', 28.00, 200, 'Şube 2', 0),
('Pringles Acılı', 'Acılı cips sevenler için', 'Aburcubur', 26.00, 130, 'Merkez', 1),
('Fairy Sıvı Bulaşık Deterjan 650ml', 'Etkili yağ çözücü', 'Temizlik', 38.50, 90, 'Şube 1', 0),
('Eti Popkek Kakaolu', 'Çocuklar için kakaolu kek', 'Aburcubur', 4.50, 400, 'Merkez', 1),
('Doğadan Bitki Çayı 20li', 'Rahatlatıcı bitki çayı', 'İçecek', 22.00, 100, 'Şube 2', 0),
('Torku Tereyağı 250g', 'Lezzetli ve taze tereyağı', 'Kahvaltılık', 36.00, 150, 'Merkez', 1),
('Cif Krem Temizlik 750ml', 'Mutfak ve banyo temizliği', 'Temizlik', 30.00, 80, 'Şube 1', 0),
('Ülker Çikolata 80g', 'Klasik sütlü çikolata', 'Aburcubur', 9.00, 300, 'Merkez', 1),
('Lipton Bardak Poşet Çay 100lü', 'Pratik poşet çay', 'Kahvaltılık', 45.00, 70, 'Şube 2', 0),
('Fanta 1L', 'Portakallı gazlı içecek', 'İçecek', 20.50, 160, 'Merkez', 1),
('Pringles Peynirli', 'Peynir aromalı cips', 'Aburcubur', 25.50, 140, 'Şube 1', 0),
('Domestos Jel 750ml', 'Güçlü temizlik ve hijyen', 'Temizlik', 42.00, 110, 'Merkez', 1),
('Eti Karam 50g', 'Karam aromalı çikolata', 'Aburcubur', 5.00, 400, 'Şube 2', 0),
('Torku Bal 350g', 'Doğal ve lezzetli bal', 'Kahvaltılık', 60.00, 60, 'Merkez', 1),
('Finish Parlatıcı 250ml', 'Bulaşık makinesi parlatıcı', 'Temizlik', 28.00, 90, 'Şube 1', 0),
('Cappy Portakal 1L', 'Taze sıkılmış meyve suyu', 'İçecek', 19.00, 120, 'Merkez', 1),
('Eti Puf 25g', 'Kakao dolgulu yumuşak atıştırmalık', 'Aburcubur', 3.50, 500, 'Şube 2', 0),
('Torku Kaşar Peyniri 500g', 'Lezzetli kaşar peyniri', 'Kahvaltılık', 75.00, 80, 'Merkez', 1),
('Coca Cola Zero 1L', 'Şekersiz gazlı içecek', 'İçecek', 22.50, 140, 'Şube 1', 0);


-- Kategorisi kahvaltılık olup stok'u en az olan 3 ürünün id'si, ismi, stok değeri ve şubesi listelenmesi
SELECT TOP(3) UrunId, UrunAdi, Stok, Sube
FROM Urunler
WHERE Kategori = 'Kahvaltılık'
ORDER BY Stok

-- Kategori bazında toplam stok sayısını büyükten küçüğe doğru sıralama
SELECT Kategori, SUM(Stok) AS 'Toplam Stok'
FROM Urunler
GROUP BY Kategori
ORDER BY 'Toplam Stok' DESC

-- Kategori özelinde en yüksek stoka sahip ürün
SELECT Stok, Kategori 
FROM Urunler
WHERE Stok = (SELECT MAX(Stok) FROM Urunler)
GROUP BY Stok

SELECT TOP(1) UrunAdi
FROM Urunler
WHERE Kategori = 'Aburcubur'
ORDER BY STOK DESC


SELECT Kampanya, COUNT(*) AS 'Kampanyalı Ürün Sayısı'
FROM Urunler
GROUP BY Kampanya

CREATE TABLE Musteriler(
MusteriId INT PRIMARY KEY IDENTITY(1,1),
MusteriAd NVARCHAR(50) NOT NULL,
MusteriSoyad NVARCHAR(50),
Adres NVARCHAR(100),
MailAdres NVARCHAR(50),
Telefon NVARCHAR(20),
Vip BIT,
)


INSERT INTO Musteriler (MusteriAd, MusteriSoyad, Adres, MailAdres, Telefon, Vip) VALUES
('Ahmet', 'Yılmaz', 'Kadıköy / İstanbul', 'ahmet.yilmaz@gmail.com', '05321234567', 1),
('Ayşe', 'Demir', 'Çankaya / Ankara', 'ayse.demir@gmail.com', '05431234567', 0),
('Mehmet', 'Kaya', 'Bornova / İzmir', 'mehmet.kaya@gmail.com', '05541234567', 0),
('Elif', 'Şahin', 'Nilüfer / Bursa', 'elif.sahin@gmail.com', '05351234567', 1),
('Burak', 'Çelik', 'Konak / İzmir', 'burak.celik@gmail.com', '05421234567', 0),
('Zeynep', 'Aydın', 'Beşiktaş / İstanbul', 'zeynep.aydin@gmail.com', '05551234567', 1),
('Emre', 'Arslan', 'Muratpaşa / Antalya', 'emre.arslan@gmail.com', '05381234567', 0),
('Fatma', 'Koç', 'Odunpazarı / Eskişehir', 'fatma.koc@gmail.com', '05461234567', 0),
('Can', 'Öztürk', 'Karşıyaka / İzmir', 'can.ozturk@gmail.com', '05561234567', 1),
('Merve', 'Doğan', 'Şehitkamil / Gaziantep', 'merve.dogan@gmail.com', '05391234567', 0);


SELECT MusteriAd + ' ' + MusteriSoyad AS 'Müşteri' , Adres, Vip 
FROM Musteriler
WHERE Vip = 1

SELECT CONCAT(MusteriAd,' ',MusteriSoyad) AS 'Müşteri' , Adres, Vip 
FROM Musteriler
WHERE Vip = 1


SELECT Vip, COUNT(*) AS 'Müşteri Sayısı'
FROM Musteriler
GROUP BY Vip


CREATE TABLE Siparisler(
	SiparisId INT PRIMARY KEY IDENTITY(1,1),
	UrunId INT NOT NULL,
	MusteriId INT NOT NULL,
	Adet INT,
	SiparisTarihi DATETIME DEFAULT GETDATE(),

	CONSTRAINT FK_Siparisler_Urunler
	FOREIGN KEY (UrunId)
	REFERENCES Urunler(UrunId),

	CONSTRAINT FK_Siparisler_Musteriler
	FOREIGN KEY (MusteriId)
	REFERENCES Musteriler(MusteriId)
);

INSERT INTO Siparisler (UrunId, MusteriId, Adet, SiparisTarihi) VALUES
(1000, 1, 2, '2026-02-01'),
(1005, 3, 1, '2026-02-02'),
(1010, 2, 4, '2026-02-03'),
(1003, 5, 1, '2026-02-03'),
(1012, 4, 3, '2026-02-04'),
(1008, 6, 2, '2026-02-05'),
(1015, 7, 5, '2026-02-06'),
(1001, 8, 1, '2026-02-06'),
(1020, 9, 2, '2026-02-07'),
(1007, 10, 6, '2026-02-08'),
(1002, 1, 3, '2026-02-09'),
(1018, 2, 2, '2026-02-09'),
(1004, 3, 1, '2026-02-10'),
(1011, 4, 4, '2026-02-10'),
(1009, 5, 2, '2026-02-11'),
(1022, 6, 1, '2026-02-12'),
(1014, 7, 3, '2026-02-12'),
(1006, 8, 2, '2026-02-13'),
(1025, 9, 1, '2026-02-14'),
(1019, 10, 5, '2026-02-15'),
(1000, 2, 2, '2026-02-16'),
(1013, 3, 3, '2026-02-16'),
(1028, 4, 1, '2026-02-17'),
(1005, 5, 4, '2026-02-18'),
(1016, 6, 2, '2026-02-18'),
(1003, 7, 3, '2026-02-19'),
(1021, 8, 1, '2026-02-20'),
(1017, 9, 2, '2026-02-21'),
(1008, 10, 6, '2026-02-22'),
(1023, 1, 1, '2026-02-23'),
(1012, 2, 2, '2026-02-24'),
(1001, 3, 3, '2026-02-24'),
(1026, 4, 1, '2026-02-25'),
(1010, 5, 5, '2026-02-26'),
(1007, 6, 2, '2026-02-27'),
(1029, 7, 4, '2026-02-27'),
(1014, 8, 1, '2026-02-28'),
(1002, 9, 3, '2026-03-01'),
(1024, 10, 2, '2026-03-02'),
(1018, 1, 4, '2026-03-03');


SELECT U.UrunAdi, U.Fiyat, M.MusteriAd, Adet, SiparisTarihi, U.Fiyat * S.Adet AS 'Toplam Fiyat'
FROM Siparisler S
INNER JOIN Urunler U
ON U.UrunId = S.UrunId
INNER JOIN Musteriler M
ON M.MusteriId = S.MusteriId
WHERE M.Vip = 1
ORDER BY 'Toplam Fiyat' DESC


SELECT * 
FROM Siparisler S
INNER JOIN Urunler U
ON U.UrunId = S.UrunId

SELECT * FROM Urunler
WHERE UrunId = 1000