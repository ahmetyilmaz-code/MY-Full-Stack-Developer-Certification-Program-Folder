-- Sql de Yorum satırı // değil

USE deneme13temmuzDb -- USE ile çalışmak istediğiniz Dbyi seçiyoruz.

-- SQl de C# tan farklı olarak sadece belirli bir alanı seçerek 
--çalıştırma işlemini yapabiliriz.
-- USE master

-- SQL de büyük küçük harf duvarlılığı yok
-- select * froM OrnekKullanici == SELECT * FROM OrnekKullanici
SELECT * FROM OrnekKullanici -- OrnekKullanici tablosunda bulunan bütün verileri çek

-- * Yıldız nedir? 
SELECT KullaniciAdi,Cinsiyet FROM OrnekKullanici 
-- yıldız bütün kolonları getirir eğer istemezsek, istenilen kolon adı yazılarak getirilebilir.


SELECT DISTINCT Cinsiyet FROM OrnekKullanici
-- DISTINCT yazılınca Cinsiyet kolonunu tekrarsız getir ( sadece 1 kez yazar )


SELECT COUNT(*)  FROM OrnekKullanici
-- COUNT() == Foksiyon , metot // COUNT ilgili kolonda kaç adet kayıt olduğunu getirir.
-- eğer içinde * varsa tabloda kaç kayıt var demektir.

SELECT COUNT(Yas)  FROM OrnekKullanici
-- COUNT içine kolon adı yazılırsa kaç adet null olmayan kayıt var demektir.
-- Yas kolonunda null olmayan kaç kayıt var 5 // normalde 6 satır var

SELECT COUNT(DISTINCT Cinsiyet)  FROM OrnekKullanici
-- OrnekKullanici tablosunda Cinsiyet kolonunda kaç farklı kayıt var?

-- SQL de metinsel ifadeler 'asdfg' içerisinde yazılır.
-- büyük küçük duyarlı '' içi string gibi
SELECT * FROM OrnekKullanici WHERE Cinsiyet = 'K'
-- SQL de  = C#ta == demek
-- OrnekKullanici tablosundaki kolonlardan Cinsiyet'i K olanları getir.

-- Cinsiyeti E olan kaç kayıt var? // 3
SELECT COUNT(*) FROM OrnekKullanici WHERE Cinsiyet = 'E'

SELECT * FROM OrnekKullanici WHERE Yas < 30
-- Yas bilgisi 30dan küçük olan kayıtlar

SELECT * FROM OrnekKullanici WHERE Yas >= 25
-- Yas bilgisi 25ten büyük ve eşit olan kayıtlar

SELECT * FROM OrnekKullanici WHERE Cinsiyet <> 'E'
-- Cinsiyeti E olmayanları getir. // SQL <> , C# !=

SELECT * FROM OrnekKullanici ORDER BY Yas
-- Tablodaki Yas Kolonuna göre listeyi sırala 
-- sayıyal olduğu için küçüten büyüğe

SELECT * FROM OrnekKullanici ORDER BY KullaniciAdi
-- sayısal olmayanlarda a-z ye gider sıralama

SELECT * FROM OrnekKullanici ORDER BY Yas DESC
-- büyükten küçüğe sıralama
SELECT * FROM OrnekKullanici ORDER BY Yas ASC
-- küçükten büyüğe sıralama

SELECT * FROM OrnekKullanici ORDER BY Cinsiyet,Yas
-- cinsiyet bilgisi aynı olanlarıda yasa göre

SELECT * FROM OrnekKullanici ORDER BY Cinsiyet DESC, Yas ASC 
-- burada istenilen kolonu b>k (DESC) , veya k>b (ASC) sıralanabilir.
-- burada cinsiyet bilgisine göre büyükten küçüğe 
--cinsiyet bilgisi ile aynı olanlarıda yas bilgisine göre küçükten büyüğe sırala


-- Cinsiyeti E olan kayıtları Yas bilgisine göre küçükten büyüğe sıralayım
SELECT * FROM OrnekKullanici WHERE Cinsiyet='E' ORDER BY Yas DESC 

SELECT * FROM OrnekKullanici WHERE Cinsiyet = 'E' AND Yas <30 
-- OrnekKullanici tablosundan cinsiyetlier e ve yaşı 30dan küçük kayıtları getir.

SELECT * FROM OrnekKullanici WHERE Yas <0
-- eğer koyulan kayıt yoksa boş sonuç döndürür hata vermez.

SELECT * FROM OrnekKullanici WHERE Cinsiyet = 'K' AND Yas >20 AND KullaniciAdi = 'kübra'
-- bir sorguda kaç kolon varsa okadar and yazılabilir.

SELECT * FROM OrnekKullanici WHERE Cinsiyet = 'E' OR Yas <29
-- OR yada anlamına gelir
-- Cinsiyeti E yada yaşı 29dan küçük olanları listele

-- Cinsiyeti K olan ve yaşı 20den büyük eşit olan kayıtları KullaniciAdi bilgisine göre küçükten büyüğe sıralayım.
SELECT * FROM OrnekKullanici WHERE Cinsiyet ='K' AND Yas >= 20 ORDER BY KullaniciAdi ASC

SELECT * FROM OrnekKullanici WHERE NOT Yas<29
-- yaşı 29dan küçük olmayanları sırala, not olumsuzuz yani değili


-- bir tabloya sorgu ile nasıl veri atarım?
INSERT INTO OrnekKullanici 
VALUES('rıza','2345','E',24)
-- INSERT INTO ile bir tablonun içerisine kayıt atabiliriz.
-- örneği yukarıda KullaniciAdi='riza' , Sifre='2345' , Cinsiyet='E' , Yas=24 olan
--bir kaydı oluşturacak sorguyu yazdık

INSERT INTO OrnekKullanici(Sifre,KullaniciAdi,Yas,Cinsiyet)
VALUES('2345','dilek',65,'B')
-- INSERT INTO ile tablo yanına kolon simgelerini yazarak
--VALUES kısmında hangi sırada değerleri vereceğimi belirtebilirim.

INSERT INTO OrnekKullanici(Sifre,KullaniciAdi,Yas,Cinsiyet)
VALUES('2345','çiçek',34,'K')
,('5678','derya',23,'K')
-- VALUES'ten sonra , konularak istenildiği kadar tek seferde kayıt atanabilir.

SELECT * FROM OrnekKullanici WHERE Yas IS NULL
-- = operatörü ile null değer kontrölü yapamayız bunun yerine is null şeklinde sogulamalıyız

SELECT * FROM OrnekKullanici WHERE Yas IS NOT NULL
-- null olmayan kayıtlar için IS NOT NULL kullanmalıyız.

--**********************
-- UPDATE ile bir tablo içindeki verileri güncelleyebilirim.
-- UPDATE sorgusunda en önemli şey EĞER WHERE ifadesi yazmadan çalıştırısam
--tabloda bulunan TÜM KAYITLARIN verileri güncellenir
--yani burada OrnekKullanici tablosunda bulunan tüm kayıtları 31 yap demiş oluyoruz
--BUNA ÇOK DİKKAT
UPDATE OrnekKullanici SET Yas = 31
--************************

UPDATE OrnekKullanici SET Yas = 32 WHERE KullaniciAdi = 'behlül'
-- KullaniciAdi bilgisi behlül olan kaydın yaşını 32 yap

BEGIN TRAN T1 -- BEGIN TRAN ile ayrı bir kanalda iş açıyorum normaldeki sorgu ortamından
-- başka ortama geçiyorum
UPDATE OrnekKullanici SET Yas = 33
SELECT * FROM OrnekKullanici
ROLLBACK TRAN T1 -- ROLLBACK TRAN ile bu yapılan bütün işlemleri geri alıyorum UPDATE gibi özellikle
-- verilerimi doğrudan etkileyecek hassas işler için kullanılır.
-- BEGİN TRAN ile ROLLBACK TRAN arasındaki T1 isimli işleri yap ve değerleri geri al

--******************************
DElETE FROM OrnekKullanici -- bu şekilde DELETE'i WHERE kullanmadan yazılırsa bütün veriler
--silinir şirkette sana ikramiye verir. WHERE Kullanmadan yapma
--*************************

DElETE FROM OrnekKullanici WHERE KullaniciAdi = 'orlando'
-- KullaniciAdi orlando olan kayıt silindi.

--DROP TABLE OrnekKullanici -- bu ileride göreceiğmiz IDENTITY verilerini siler
--yani tüm iz düşümlerini siler AMAN YAPMA

SELECT TOP 10 * FROM OrnekKullanici
-- SELECT TOP ile kayıtlardan istenilen adette listelemek için kullanılır.
-- İlk 10 kaydı getir demek

SELECT TOP 20 PERCENT * FROM OrnekKullanici
--ilk %20 kayıt
