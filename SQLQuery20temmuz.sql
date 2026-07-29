USE deneme13temmuzDb 

SELECT * FROM OrnekKullanici  WHERE Cinsiyet = 'B' OR  Cinsiyet IS NULL 
-- cinsiyeti null olan ve b olanları listele

--MIN MAX harflerde a-z sıralayarak yapar.
SELECT MIN(Yas) FROM OrnekKullanici 
-- en küçük yaş değerinin değeri nedir ?

SELECT MAX(Yas) FROM OrnekKullanici 
-- en büyük yaş değerinin değeri nedir ?

SELECT (MIN(Yas) + MAX(Yas)) / count(yas) FROM OrnekKullanici 
-- en büyük + en küçük yaşlar / yaştaki kişi sayısı

SELECT AVG(Yas) FROM OrnekKullanici
-- AVG gönderilen kolondaki ortalama değeri bulur

SELECT SUM(Yas) FROM OrnekKullanici
-- SUM gönderilen kolondaki sayıları toplar

-- erkek kayıtların yaşlarının ortalaması nedir?
SELECT AVG(Yas) FROM OrnekKullanici WHERE Cinsiyet = 'E'

SELECT * FROM OrnekKullanici WHERE Yas > (SELECT AVG(Yas) FROM OrnekKullanici)
-- yaşı ortalama yaştan büyük olan kullanıcıları listele

-- örnekkullanıcı tablosunda yaş bilgisi ortalama değerin 
-- %70 altında olan kayıtları listele
SELECT * FROM OrnekKullanici WHERE Yas < (SELECT AVG(Yas)*0.7 FROM OrnekKullanici)

-- LIKE filtreleme yaparak arama yapmamıza olanak tanır.
-- örneğin KullaniciAdi a ile başlayanları listele demek için like kullanılır.
-- % bir veya birden fazla herhangş bir karakter
SELECT * FROM OrnekKullanici WHERE KullaniciAdi LIKE 'a%'
-- a ile başlayan sonrasında istenildiği kadar karakter gelen kayıtlar

SELECT * FROM OrnekKullanici WHERE KullaniciAdi LIKE '%b%'
-- KullaniciAdi içinde b geçenler

SELECT * FROM OrnekKullanici WHERE KullaniciAdi LIKE '%s'
-- KullaniciAdi a ile bitenler

SELECT * FROM OrnekKullanici WHERE KullaniciAdi LIKE 'u_ur'
-- tek bi karakter

SELECT * FROM OrnekKullanici WHERE KullaniciAdi LIKE '____'
-- KullaniciAdi 4 karakterli

-- KullaniciAdi a veya b ile başlayanlar
SELECT * FROM OrnekKullanici WHERE KullaniciAdi LIKE 'a%' or KullaniciAdi LIKE 'b%'
--veya
SELECT * FROM OrnekKullanici WHERE KullaniciAdi LIKE '[ab]%'
-- köşeli parantez bulunduğu yere gelebilecek karakterleri barındırır

SELECT * FROM OrnekKullanici WHERE KullaniciAdi NOT LIKE 'a%'
-- NOT burada KullaniciAdi a ile başlamayanlar demek için kullanılır

-- cinsiyeti e veya k olanlar
SELECT * FROM OrnekKullanici WHERE Cinsiyet = 'E' or Cinsiyet = 'K'
-- veya
SELECT * FROM OrnekKullanici WHERE Cinsiyet IN('E','K')

-- yaşı 20 ile 35 arasında olan kayıtarı listele 20,35 dahil
SELECT * FROM OrnekKullanici WHERE Yas >= 20 AND Yas <=35
--veya
SELECT * FROM OrnekKullanici WHERE Yas BETWEEN 20 AND 35

SELECT * FROM OrnekKullanici WHERE Yas NOT BETWEEN 20 AND 35
-- yaşı 20 ile 35 arasında olmayanlar

SELECT KullaniciAdi AS [KULLANICI ADI], Sifre AS [ŞİFRE], Cinsiyet AS [CİNSİYET_E_K], Yas AS [KULLANICI YAŞ] FROM OrnekKullanici
-- AS ile kolona sorgu bazlı olarak geçiçi isim vereilebilir


SELECT Cinsiyet + ' / ' +  KullaniciAdi AS [CİNSİYET_KULLANICI_ADI] FROM OrnekKullanici
-- AS ile farklı kolonları birleştirip isimlendirerek sorgularımıza geçiçi kolonlar ekleyebiliriz

SELECT * FROM OrnekKullanici WHERE OrnekKullanici.Yas < 10
--veya
SELECT * FROM OrnekKullanici AS OK WHERE OK.Yas < 10
-- tabloya takma isim koymak içinde AS kullanılır


-- JOIN
-- birbirinden ayrı tabloları ortak kolonlar üzerinden birbirine bağlayarak sonuç üretmek için kullanılır
-- INNER JOIN --  iki tablonun ortak kesişim olanlarını alır.
SELECT * FROM OrnekKullanici INNER JOIN OrnekTablo20temmuz ON OrnekKullanici.KullaniciAdi = OrnekTablo20temmuz.KullaniciAdi

SELECT * FROM OrnekKullanici AS OK LEFT JOIN OrnekTablo20temmuz AS OKA ON OK.KullaniciAdi = OKA.KullaniciAdi
-- LEFT JOIN : joininn sol tarafında kalan tablodaki tüm değerleri getirir
-- sağ tarafında kalan tablodaki sadece eşleşenleri getirir eşleşmeyen değerler null kalır.

SELECT * FROM OrnekKullanici AS OK RIGHT JOIN OrnekTablo20temmuz AS OKA ON OK.KullaniciAdi = OKA.KullaniciAdi
-- RIGHT JOIN

SELECT * FROM OrnekKullanici AS OK FULL JOIN OrnekTablo20temmuz AS OKA ON OK.KullaniciAdi = OKA.KullaniciAdi
-- FULL JOIN her iki tablodaki bütün değerler

SELECT * FROM OrnekKullanici AS OK 
JOIN OrnekTablo20temmuz AS OKA ON
OK.KullaniciAdi = OKA.KullaniciAdi
WHERE OK.Cinsiyet = 'E'

-- hangi şehirlerde erkek kullanılar var şehir bilgisini tekrarsız listeleme yapalım
SELECT DISTINCT OKA.Sehir FROM OrnekKullanici AS OK 
JOIN OrnekTablo20temmuz AS OKA ON
OK.KullaniciAdi = OKA.KullaniciAdi
WHERE OK.Cinsiyet = 'E'

-- bu yaklaşıma SELF JOIN denir ama aslında bir tabloyu iki defa çekmektir bu kökünde bir join değildir.
SELECT OK1.KullaniciAdi as KULLANICI_1, OK2.KullaniciAdi As KULLANICI_2  FROM OrnekKullanici OK1, OrnekKullanici OK2
WHERE OK1.Yas = OK2.Yas AND OK1.KullaniciAdi <> OK2.KullaniciAdi


