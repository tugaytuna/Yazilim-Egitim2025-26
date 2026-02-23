CREATE TABLE KisiselBilgiler(
OgrenciIsim NVARCHAR(50),
OkulNo INT,
Bolum NVARCHAR( 100 ),
Sinif NVARCHAR(10),
);




USE Ogrenci





INSERT INTO KisiselBilgiler (OgrenciIsim, OkulNo, Bolum, Sinif) VALUES ('Tugay', '1242', 'Yazılım', '12-A');
INSERT INTO KisiselBilgiler (OgrenciIsim, OkulNo, Bolum, Sinif) VALUES ('İsmail', '4156', 'Resim', '11-A');
INSERT INTO KisiselBilgiler (OgrenciIsim, OkulNo, Bolum, Sinif) VALUES ('Ahmet', '4157', 'Resim', '11-A');
INSERT INTO KisiselBilgiler (OgrenciIsim, OkulNo, Bolum, Sinif) VALUES ('Zeynep', '4158', 'Müzik', '10-B');
INSERT INTO KisiselBilgiler (OgrenciIsim, OkulNo, Bolum, Sinif) VALUES ('Mehmet', '4159', 'Bilişim', '12-C');
INSERT INTO KisiselBilgiler (OgrenciIsim, OkulNo, Bolum, Sinif) VALUES ('Elif', '4160', 'Resim', '9-A');
INSERT INTO KisiselBilgiler (OgrenciIsim, OkulNo, Bolum, Sinif) VALUES ('Can', '4161', 'Müzik', '11-B');
INSERT INTO KisiselBilgiler (OgrenciIsim, OkulNo, Bolum, Sinif) VALUES ('Ayşe', '4162', 'Bilişim', '10-C');
INSERT INTO KisiselBilgiler (OgrenciIsim, OkulNo, Bolum, Sinif) VALUES ('Burak', '4163', 'Resim', '12-A');
INSERT INTO KisiselBilgiler (OgrenciIsim, OkulNo, Bolum, Sinif) VALUES ('Ceren', '4164', 'Müzik', '9-B');
INSERT INTO KisiselBilgiler (OgrenciIsim, OkulNo, Bolum, Sinif) VALUES ('Emre', '4165', 'Bilişim', '11-C');
INSERT INTO KisiselBilgiler (OgrenciIsim, OkulNo, Bolum, Sinif) VALUES ('Derya', '4166', 'Resim', '10-A');


SELECT * FROM KisiselBilgiler

--SELECT OgrenciIsim, Bolum FROM KisiselBilgiler

SELECT OkulNo, OgrenciIsim, Sinif, Bolum 
FROM KisiselBilgiler


SELECT OgrenciIsim AS 'İsim' , Bolum AS 'Bölüm', OkulNo AS 'Okul Numarası'
FROM KisiselBilgiler 
WHERE Bolum = 'Bilişim'


UPDATE KisiselBilgiler 
SET Bolum = 'Bilişim'
WHERE OgrenciIsim = 'Tugay'


DELETE FROM KisiselBilgiler
WHERE OgrenciIsim = 'İsmail'


USE master
DROP TABLE KisiselBilgiler

USE Ogrenci

--OgrenciIsim değeri c ile başlayanlar
SELECT * FROM KisiselBilgiler
WHERE OgrenciIsim LIKE 'C%'