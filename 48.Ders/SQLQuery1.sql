CREATE TABLE KisiselBilgiler(
OgrenciIsim NVARCHAR(50),
OkulNo INT,
Bolum NVARCHAR( 100 ),
Sinif NVARCHAR(10),
);

USE Ogrenci




UPDATE KisiselBilgiler 
SET Notlar = 56 
WHERE OkulNo = '4158'

SELECT * FROM KisiselBilgiler


SELECT OgrenciIsim, Sinif, Bolum AS 'Bölüm', Notlar
FROM KisiselBilgiler
WHERE Notlar > 50
ORDER BY Notlar DESC


SELECT COUNT(*) AS 'Geçen Öğrenci Sayısı' 
FROM KisiselBilgiler
WHERE Notlar > 50

SELECT AVG(Notlar) AS 'Not Ortalaması'
FROM KisiselBilgiler
WHERE Sinif = '9-A'


-- 12-a Sınıfının ortalamasından yüksek ortalamaya sahip 12-a sınıfı öğrencilerin bilgileri
SELECT * 
FROM KisiselBilgiler
WHERE Notlar > (SELECT AVG(Notlar) FROM KisiselBilgiler WHERE Sinif = '12-A') AND Sinif = '12-A'

(SELECT AVG(Notlar) FROM KisiselBilgiler WHERE Sinif = '12-A')


SELECT COUNT(*) FROM KisiselBilgiler
WHERE Sinif = '9-A'



SELECT MIN(Notlar) AS 'En Düşük Not' FROM KisiselBilgiler

SELECT * 
FROM KisiselBilgiler
WHERE Notlar = (SELECT MIN(Notlar) FROM KisiselBilgiler)

--  Bölüm/Derslere göre not ortalaması ve öğrenci sayısı
SELECT Bolum, AVG(Notlar) AS 'Not Ortalaması' , COUNT(*) AS 'Öğrenci Sayısı'
FROM KisiselBilgiler
GROUP BY Bolum

SELECT *
FROM KisiselBilgiler

-- Sınıfa göre öğrenci sayısı ve en yüksek not
SELECT Sinif, Count(*) AS 'Öğrenci Sayısı', MAX(Notlar) AS 'En Yüksek Not'
FROM KisiselBilgiler
GROUP BY Sinif

SELECT * FROM KisiselBilgiler

UPDATE KisiselBilgiler
SET Sinif = '12-A'
WHERE Sinif LIKE '12%'







