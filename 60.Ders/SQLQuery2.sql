SELECT TOP (1000) [KitapId]
      ,[Isim]
      ,[Yazar]
      ,[Tur]
      ,[YayınEvi]
      ,[SayfaSayisi]
      ,[Okundu]
  FROM [KitapDB].[dbo].[Kitap]


  INSERT INTO Kitap ( Isim, Yazar, Tur, YayınEvi, SayfaSayisi, Okundu)
VALUES
(N'Suç ve Ceza', N'Fyodor Dostoyevski', N'Roman', N'İş Bankası Kültür Yayınları', 704, 1),
(N'1984', N'George Orwell', N'Distopya', N'Can Yayınları', 352, 1),
(N'Hayvan Çiftliği', N'George Orwell', N'Politik Roman', N'Can Yayınları', 152, 1),
(N'Sefiller', N'Victor Hugo', N'Roman', N'İş Bankası Kültür Yayınları', 1232, 0),
(N'Savaş ve Barış', N'Lev Tolstoy', N'Tarihsel Roman', N'İş Bankası Kültür Yayınları', 1225, 0),
(N'Küçük Prens', N'Antoine de Saint-Exupéry', N'Çocuk / Felsefi', N'Can Yayınları', 96, 1),
(N'Dönüşüm', N'Franz Kafka', N'Novella', N'Can Yayınları', 112, 1),
(N'Yüzüklerin Efendisi', N'J.R.R. Tolkien', N'Fantastik', N'Metis Yayınları', 1178, 0),
(N'Hobbit', N'J.R.R. Tolkien', N'Fantastik', N'Metis Yayınları', 310, 1),
( N'Da Vinci Şifresi', N'Dan Brown', N'Gerilim', N'Altın Kitaplar', 592, 1),
( N'Melekler ve Şeytanlar', N'Dan Brown', N'Gerilim', N'Altın Kitaplar', 616, 0),
( N'Simyaçı', N'Paulo Coelho', N'Roman', N'Can Yayınları', 208, 1),
( N'Bilinmeyen Bir Kadının Mektubu', N'Stefan Zweig', N'Novella', N'İş Bankası Kültür Yayınları', 80, 1),
( N'Satranç', N'Stefan Zweig', N'Novella', N'İş Bankası Kültür Yayınları', 96, 0),
( N'Körlük', N'José Saramago', N'Roman', N'Kırmızı Kedi Yayınları', 352, 0),
( N'Fahrenheit 451', N'Ray Bradbury', N'Distopya', N'İthaki Yayınları', 256, 1),
( N'Cesur Yeni Dünya', N'Aldous Huxley', N'Distopya', N'İthaki Yayınları', 320, 0),
( N'Yeraltından Notlar', N'Fyodor Dostoyevski', N'Felsefi Roman', N'İş Bankası Kültür Yayınları', 168, 1),
( N'Tutunamayanlar', N'Oğuz Atay', N'Roman', N'İletişim Yayınları', 724, 0),
( N'İnce Memed', N'Yaşar Kemal', N'Roman', N'Yapı Kredi Yayınları', 436, 1);


SELECT * FROM Kitap