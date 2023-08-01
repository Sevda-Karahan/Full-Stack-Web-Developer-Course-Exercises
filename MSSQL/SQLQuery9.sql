use Northwind

select * from Musteriler

--Musteriler tablosundaki musteriUnvani owner olmayanlar�n %10'nu getiren sorgu
-- <>, != anlam�na gelir. Herhangi birisi kullan�labilir.
select top 10 percent * from Musteriler where musteriUnvani<>'Owner'

select * from Tedarikciler

--Tedarikciler tablosunda �ehri Tokyo olanlar�n %50'nu getiren sorgu
select top 50 percent * from Tedarikciler where sehir='tokyo'

--Musteriler tablosundaki musteriID'leri z'den a'ya s�ralas�n.
select * from Musteriler order by musteriID desc

--Musteriler tablosundaki musteriUnvani owner olmayanlar�n son %10'luk dilimine giren kay�tlar� getiren sorgu
select top 10 percent * from Musteriler where MusteriUnvan�!='Owner' order by musteriUnvani desc

select * from Kategoriler

--KategoriAdi s�tun ad�n� Katalog olarak g�stersin.
--Tanimi s�tun ad�n� Aciklama Metni olarak g�stersin.

--as ile isimlendirme yap�l�r. Yani TAKMA �S�M vermi� olduk.
-- tek kelime �eklinde g�sterilmesini istedi�imizde t�rnak kullanmam�za gerek yok, birden fazla kelimede kullanmak �art

select KategoriAdi as Katalog, Tanimi as 'Aciklama Metni' from Kategoriler