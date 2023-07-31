-- select (se�mek,listelemek, getirmek)
-- from: hangi tabloya ba�l� �al��t���n� g�sterir
-- * : t�m tablo kolonlar�n� getirir.
-- where sorguda ko�ul eklenildi�inde kullan�l�r.
-- where...and... : iki ko�ulu birbirine ba�larken kullan�l�r.

-- Personeller tablosundaki t�m veriler:
select * from Personeller 

select adSoyad,adres from Personeller 

select adSoyad,maas from Personeller where adres='Tekirda�'
select * from Personeller where adres='Tekirda�'

-- pirimi 4000in alt�nda olan personellerin adsoyad bilgisini g�ster.
select adSoyad from Personeller where prim<4000

select * from Personeller where peresonelNo=3

insert into Personeller (adSoyad,adres,maas,prim) values ('Ece Gece', '�stanbul', 30000, 5000)

--adresi Giresun ve primi>4000 olanlar�n bilgilerini getiren sorgu

select * from Personeller where adres='Giresun' and prim>4000

-- update : varolan veride de�i�iklik yaparken kullan�l�r.

-- personelNo 1 olan ki�inin  maa�� 22000 olarak g�ncellensin.

update Personeller set maas=22000 where peresonelNo=1

-- Kerem �kincinin adresini Sakarya olarak g�ncelleyen sorgu
update Personeller set adres='Sakarya' where adSoyad='Kerem �kinci'

-- order by : s�ralama yapmak i�in kullan�l�r.
-- 2 anahtar kelimesi var
--asc  : k���kten b�y��e 
--desc : b�y�kten k����e

-- Personeller tablosunda adSoyad alfabetik olarak s�ralans�n
select * from Personeller order by adSoyad asc

insert into Personeller (adSoyad,adres) values ('Sema Su', 'Yalova')
insert into Personeller (adSoyad,adres) values ('Sevgi Sel', '�anakkale')
update Personeller set maas=20000 where adSoyad='Sevgi Sel'

--maas� null olanlar�n bilgilerini getiren sorgu
select * from Personeller where maas is null

--primi null olanlar�n verisi
select * from Personeller where prim is null

--primi null olmayanlar�n verisi
select * from Personeller where prim is not null

--delete from: tablodaki verileri silmek i�in kullan�l�r.
delete from Personeller where maas is null

-- --Tablomdaki t�m verileri silmek i�in 
-- delete from Personeller