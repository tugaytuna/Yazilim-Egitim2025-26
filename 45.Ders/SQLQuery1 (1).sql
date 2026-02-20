CREATE DATABASE OgrenciDB;

USE ilkDatabase

CREATE TABLE Dersler(
DersAdi NVARCHAR(50),
DersSuresi INT
);

SELECT * 
FROM 
Dersler

SELECT * FROM Personel


INSERT INTO Personel (PersonelId, PersonelIsim, Departman) VALUES ('3', 'İsmail', 'Teknik');


INSERT INTO Personel (PersonelId, PersonelIsim, Departman) VALUES ('4', 'Ahmet', 'Personel');


SELECT PersonelIsim, Departman FROM Personel WHERE Departman = 'Yazılım'


SELECT PersonelIsim, Departman FROM Personel WHERE PersonelIsim = 'İsmail';


SELECT PersonelId, PersonelIsim, Departman FROM Personel WHERE PersonelId > 3;

SELECT PersonelIsim , Departman FROM Personel WHERE PersonelIsim = 'Samet';
