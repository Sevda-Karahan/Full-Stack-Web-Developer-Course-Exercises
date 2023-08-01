use Northwind

select * from Musteriler

--Musteriler tablosundaki musteriUnvani owner olmayanlarýn %10'nu getiren sorgu
-- <>, != anlamýna gelir. Herhangi birisi kullanýlabilir.
select top 10 percent * from Musteriler where musteriUnvani<>'Owner'

select * from Tedarikciler

--Tedarikciler tablosunda þehri Tokyo olanlarýn %50'nu getiren sorgu
select top 50 percent * from Tedarikciler where sehir='tokyo'

--Musteriler tablosundaki musteriID'leri z'den a'ya sýralasýn.
select * from Musteriler order by musteriID desc

--Musteriler tablosundaki musteriUnvani owner olmayanlarýn son %10'luk dilimine giren kayýtlarý getiren sorgu
select top 10 percent * from Musteriler where MusteriUnvaný!='Owner' order by musteriUnvani desc

select * from Kategoriler

--KategoriAdi sütun adýný Katalog olarak göstersin.
--Tanimi sütun adýný Aciklama Metni olarak göstersin.

--as ile isimlendirme yapýlýr. Yani TAKMA ÝSÝM vermiþ olduk.
-- tek kelime þeklinde gösterilmesini istediðimizde týrnak kullanmamýza gerek yok, birden fazla kelimede kullanmak þart

select KategoriAdi as Katalog, Tanimi as 'Aciklama Metni' from Kategoriler