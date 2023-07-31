-- select (seçmek,listelemek, getirmek)
-- from: hangi tabloya baðlý çalýþtýðýný gösterir
-- * : tüm tablo kolonlarýný getirir.
-- where sorguda koþul eklenildiðinde kullanýlýr.
-- where...and... : iki koþulu birbirine baðlarken kullanýlýr.

-- Personeller tablosundaki tüm veriler:
select * from Personeller 

select adSoyad,adres from Personeller 

select adSoyad,maas from Personeller where adres='Tekirdað'
select * from Personeller where adres='Tekirdað'

-- pirimi 4000in altýnda olan personellerin adsoyad bilgisini göster.
select adSoyad from Personeller where prim<4000

select * from Personeller where peresonelNo=3

insert into Personeller (adSoyad,adres,maas,prim) values ('Ece Gece', 'Ýstanbul', 30000, 5000)

--adresi Giresun ve primi>4000 olanlarýn bilgilerini getiren sorgu

select * from Personeller where adres='Giresun' and prim>4000

-- update : varolan veride deðiþiklik yaparken kullanýlýr.

-- personelNo 1 olan kiþinin  maaþý 22000 olarak güncellensin.

update Personeller set maas=22000 where peresonelNo=1

-- Kerem Ýkincinin adresini Sakarya olarak güncelleyen sorgu
update Personeller set adres='Sakarya' where adSoyad='Kerem Ýkinci'

-- order by : sýralama yapmak için kullanýlýr.
-- 2 anahtar kelimesi var
--asc  : küçükten büyüðe 
--desc : büyükten küçüðe

-- Personeller tablosunda adSoyad alfabetik olarak sýralansýn
select * from Personeller order by adSoyad asc

insert into Personeller (adSoyad,adres) values ('Sema Su', 'Yalova')
insert into Personeller (adSoyad,adres) values ('Sevgi Sel', 'Çanakkale')
update Personeller set maas=20000 where adSoyad='Sevgi Sel'

--maasý null olanlarýn bilgilerini getiren sorgu
select * from Personeller where maas is null

--primi null olanlarýn verisi
select * from Personeller where prim is null

--primi null olmayanlarýn verisi
select * from Personeller where prim is not null

--delete from: tablodaki verileri silmek için kullanýlýr.
delete from Personeller where maas is null

-- --Tablomdaki tüm verileri silmek için 
-- delete from Personeller