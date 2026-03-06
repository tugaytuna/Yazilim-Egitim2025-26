


Use Kutuphane


CREATE TABLE Kitaplar (
	KitapId INT PRIMARY KEY IDENTITY(1000,1),
	KitapAdi NVARCHAR(50) NOT NULL,
	Yazar NVARCHAR(50),
	KitapTuru NVARCHAR(50),
	Sube NVARCHAR(50),
	Raf NVARCHAR(50),
	Barkod INT,
	Musait BIT
)

Select * from Kitaplar


INSERT INTO Kitaplar (KitapAdi, Yazar, KitapTuru, Sube, Raf, Barkod, Musait) VALUES
('Sessiz Gece','Ahmet Yılmaz','Roman','Kadıköy Şubesi','Raf1',834562193,1),
('Kayıp Zaman','Ayşe Demir','Roman','Beşiktaş Şubesi','Raf4',562193847,1),
('Gölgelerin Dansı','Mehmet Kaya','Fantastik','Üsküdar Şubesi','Raf2',918273645,1),
('Son Yolculuk','Fatma Çelik','Tarih','Şişli Şubesi','Raf7',736451928,1),
('Kırık Kanatlar','Ali Arslan','Roman','Bakırköy Şubesi','Raf5',845192736,1),
('Gece Yolcusu','Zeynep Şahin','Polisiye','Fatih Şubesi','Raf8',562918374,1),
('Unutulan Şehir','Kemal Öz','Roman','Kartal Şubesi','Raf3',918374562,1),
('Bilinmeyen Ada','Elif Aydın','Macera','Maltepe Şubesi','Raf6',374829156,1),
('Sonsuzluk','Mustafa Koç','Bilim Kurgu','Kadıköy Şubesi','Raf9',562748193,1),
('Eski Defter','Selin Kurt','Roman','Beşiktaş Şubesi','Raf10',918273564,1),
('Kayıp Günlük','Ahmet Yılmaz','Roman','Üsküdar Şubesi','Raf11',726354918,1),
('Gece Hikayeleri','Ayşe Demir','Fantastik','Şişli Şubesi','Raf2',918273111,1),
('Kırmızı Yol','Mehmet Kaya','Macera','Bakırköy Şubesi','Raf4',826354918,1),
('Yitik Hatıra','Fatma Çelik','Roman','Fatih Şubesi','Raf1',726354999,1),
('Gölgeler','Ali Arslan','Polisiye','Kartal Şubesi','Raf7',562918123,1),
('Kayıp Dünya','Zeynep Şahin','Bilim Kurgu','Maltepe Şubesi','Raf6',918273222,1),
('Eski Sokak','Kemal Öz','Roman','Kadıköy Şubesi','Raf3',826354333,1),
('Karanlık Gece','Elif Aydın','Polisiye','Beşiktaş Şubesi','Raf8',918273444,1),
('Sisli Dağlar','Mustafa Koç','Macera','Üsküdar Şubesi','Raf5',726354555,1),
('Uzak Ufuk','Selin Kurt','Roman','Şişli Şubesi','Raf9',918273666,1),
('Mavi Deniz','Ahmet Yılmaz','Macera','Bakırköy Şubesi','Raf10',726354777,1),
('Altın Şehir','Ayşe Demir','Fantastik','Fatih Şubesi','Raf4',918273888,1),
('Gizemli Ada','Mehmet Kaya','Macera','Kartal Şubesi','Raf2',726354111,1),
('Son Kale','Fatma Çelik','Tarih','Maltepe Şubesi','Raf6',918273999,1),
('Kayıp Harita','Ali Arslan','Macera','Kadıköy Şubesi','Raf7',726354222,1),
('Büyük Kaçış','Zeynep Şahin','Macera','Beşiktaş Şubesi','Raf5',918273333,1),
('Sisli Yol','Kemal Öz','Roman','Üsküdar Şubesi','Raf8',726354444,1),
('Karanlık Sır','Elif Aydın','Polisiye','Şişli Şubesi','Raf3',918273555,1),
('Kayıp Hatıra','Mustafa Koç','Roman','Bakırköy Şubesi','Raf9',726354666,1),
('Uzun Gece','Selin Kurt','Roman','Fatih Şubesi','Raf1',918273777,1),
('Gölgeli Sokak','Ahmet Yılmaz','Polisiye','Kartal Şubesi','Raf2',726354888,1),
('Kırık Saat','Ayşe Demir','Roman','Maltepe Şubesi','Raf4',918273101,1),
('Son Bahar','Mehmet Kaya','Roman','Kadıköy Şubesi','Raf6',726354102,1),
('Eski Fotoğraf','Fatma Çelik','Roman','Beşiktaş Şubesi','Raf7',918273103,1),
('Uzak Hatıra','Ali Arslan','Roman','Üsküdar Şubesi','Raf8',726354104,1),
('Yitik Yol','Zeynep Şahin','Macera','Şişli Şubesi','Raf10',918273105,1),
('Sisli Liman','Kemal Öz','Roman','Bakırköy Şubesi','Raf11',726354106,1),
('Kayıp Gün','Elif Aydın','Roman','Fatih Şubesi','Raf12',918273107,1),
('Eski Köprü','Mustafa Koç','Tarih','Kartal Şubesi','Raf13',726354108,1),
('Son Umut','Selin Kurt','Roman','Maltepe Şubesi','Raf14',918273109,1),
('Karanlık Sokak','Ahmet Yılmaz','Polisiye','Kadıköy Şubesi','Raf15',726354110,0),
('Kayıp Işık','Ayşe Demir','Roman','Beşiktaş Şubesi','Raf16',918273111,0),
('Son Gemi','Mehmet Kaya','Macera','Üsküdar Şubesi','Raf17',726354112,0),
('Sisli Yolculuk','Fatma Çelik','Roman','Şişli Şubesi','Raf18',918273113,0),
('Kayıp Günler','Ali Arslan','Roman','Bakırköy Şubesi','Raf19',726354114,0),
('Gece Rüzgarı','Zeynep Şahin','Roman','Fatih Şubesi','Raf20',918273115,1),
('Son Hatıra','Kemal Öz','Roman','Kartal Şubesi','Raf6',726354116,1),
('Kayıp İz','Elif Aydın','Polisiye','Maltepe Şubesi','Raf7',918273117,1),
('Gizemli Yol','Mustafa Koç','Macera','Kadıköy Şubesi','Raf8',726354118,1),
('Kırık Aynalar','Selin Kurt','Roman','Beşiktaş Şubesi','Raf9',918273119,1);


DROP TABLE Kitaplar

SELECT KitapTuru, COUNT(*) AS 'Kitap Sayısı'
FROM Kitaplar
GROUP BY KitapTuru
ORDER BY 'Kitap Sayısı' DESC

SELECT Sube, Count(*) AS 'Kitap Sayısı' 
FROM Kitaplar
GROUP BY Sube



SELECT * FROM Kitaplar



CREATE TABLE Kayitlar(
	KayitId INT PRIMARY KEY IDENTITY(1,1),
	KitapId INT NOT NULL,
	OduncAlanKisi NVARCHAR(50),
	KayitTarihi DATETIME DEFAULT GETDATE(),

	CONSTRAINT FK_Kayitlar_Kitaplar
	FOREIGN KEY (KitapId)
	REFERENCES Kitaplar(KitapId),
);

INSERT INTO Kayitlar (KitapId, OduncAlanKisi, KayitTarihi) VALUES
(1000,'Ahmet Yılmaz','2026-02-01'),
(1001,'Ayşe Demir','2026-02-02'),
(1002,'Mehmet Kaya','2026-02-03'),
(1003,'Fatma Çelik','2026-02-04'),
(1004,'Ali Arslan','2026-02-05'),
(1005,'Zeynep Şahin','2026-02-06'),
(1006,'Kemal Öz','2026-02-07'),
(1007,'Elif Aydın','2026-02-08'),
(1008,'Mustafa Koç','2026-02-09'),
(1009,'Selin Kurt','2026-02-10'),
(1010,'Burak Yıldız','2026-02-11'),
(1011,'Merve Aksoy','2026-02-12'),
(1012,'Onur Demirtaş','2026-02-13'),
(1013,'Ceren Acar','2026-02-14'),
(1014,'Hakan Yıldırım','2026-02-15'),
(1015,'Buse Karaca','2026-02-16'),
(1016,'Serkan Aydın','2026-02-17'),
(1017,'Gizem Kaya','2026-02-18'),
(1018,'Emre Şen','2026-02-19'),
(1019,'Tuğçe Arslan','2026-02-20'),
(1020,'Kaan Özdemir','2026-02-21'),
(1021,'Melis Çetin','2026-02-22'),
(1022,'Furkan Koç','2026-02-23'),
(1023,'Deniz Kaplan','2026-02-24'),
(1024,'Ece Yılmaz','2026-02-25'),
(1025,'Tolga Demir','2026-02-26'),
(1026,'Seda Aydın','2026-02-27'),
(1027,'Barış Kaya','2026-02-28'),
(1028,'Esra Şahin','2026-03-01'),
(1029,'Okan Çelik','2026-03-02');


SELECT * 
FROM Kayitlar KY
INNER JOIN Kitaplar KI
ON KI.KitapId = KY.KitapId


SELECT * FROM Kitaplar

CREATE VIEW KadikoyKayitlar
AS
SELECT KayitId, KY.OduncAlanKisi, KI.Sube, KI.Barkod, KayitTarihi
FROM Kayitlar KY
INNER JOIN Kitaplar KI
ON KI.KitapId = KY.KitapId
WHERE KI.Sube = 'Kadıköy Şubesi'

DROP VIEW KadıkoyKayitlar

INSERT INTO Kayitlar (KitapId, OduncAlanKisi) VALUES
(1048,'Tugay Tuna');



SELECT OduncAlanKisi, Barkod FROM KadikoyKayitlar


-- Kayıtlar tablosundaki, kitapların ait oldukları şubeye göre, şube özelinde toplam kiralanan kitap sayısını getirir
CREATE VIEW SubeKayitSayisi
AS
SELECT Sube, COUNT(*) AS 'Kitap Sayısı'
FROM Kayitlar KY
INNER JOIN Kitaplar KI
ON KI.KitapId = KY.KitapId
GROUP BY KI.Sube


SELECT * FROM SubeKayitSayisi
ORDER BY 'Kitap Sayısı' DESC

SELECT * FROM SubeKayitSayisi
ORDER BY [Kitap Sayısı] DESC


CREATE FUNCTION Toplama
(
	@Birinci INT,
	@Ikinci INT
)
RETURNS INT
AS
BEGIN
	DECLARE @Toplam INT
	SET @Toplam = @Birinci + @Ikinci
	RETURN @Toplam
END


CREATE FUNCTION DuzenlenmisBarkod2
(
	@Raf NVARCHAR(50),
	@Barkod NVARCHAR(50)
)
RETURNS NVARCHAR(100)
AS
BEGIN
	DECLARE @NBarkod NVARCHAR(100)
	SET @NBarkod = @Raf + LEFT(@Barkod,4)
	RETURN @NBarkod
END


SELECT KayitId, KY.OduncAlanKisi, KI.Sube, dbo.DuzenlenmisBarkod2(KI.Raf,KI.Barkod), KayitTarihi
FROM Kayitlar KY
INNER JOIN Kitaplar KI
ON KI.KitapId = KY.KitapId



SELECT dbo.Toplama(2,5)

SELECT * FROM Kitaplar
SELECT * FROM Kayitlar








