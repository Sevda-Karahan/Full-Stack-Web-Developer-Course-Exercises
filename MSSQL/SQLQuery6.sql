--DDL KOMUTLARI
--Fonksiyonlar
	--SUM, AVG, MAX, M�N

use Okul1

select * from Ogrenciler1
--delete from Ogrenciler1

insert into Ogrenciler1 (ogrenciNo, adSoyad, yas, adres, telefon) values (352, 'Sevda', 21, '�stanbul', 5385467890)
insert into Ogrenciler1 (ogrenciNo, adSoyad, yas, adres, telefon) values (415, 'Sibel', 20, 'Kars', 5769383456)
insert into Ogrenciler1 (ogrenciNo, adSoyad, yas, adres, telefon) values (513, 'Kerem', 25, 'Ardahan', 5433425698)
insert into Ogrenciler1 (ogrenciNo, adSoyad, yas, adres, telefon) values (498, 'Hakan', 20, 'Gaziantep', 5463840947)
insert into Ogrenciler1 (ogrenciNo, adSoyad, yas, adres, telefon) values (234, 'Ahmet', 29, 'Sakarya', 5463840947)

update Ogrenciler1 set notu=95 where ogrenciNo=352
update Ogrenciler1 set notu=70 where ogrenciNo=415
update Ogrenciler1 set notu=90 where ogrenciNo=513
update Ogrenciler1 set notu=85 where ogrenciNo=498
update Ogrenciler1 set notu=50 where ogrenciNo=234

--Tablodaki notlar�n toplam�
select sum(notu) from Ogrenciler1

--Tablodaki notlar�n ortalamas�
select AVG(notu) from Ogrenciler1

--Tablodaki en y�ksek not
select max(notu) from Ogrenciler1

--Tablodaki en d���k not
select min(notu) from Ogrenciler1

--Tablodaki en y�ksek notlu ��rencinin adSoyad ve not bilgilerini getiren sorgu
select adSoyad, notu from Ogrenciler1 where notu=(select max(notu) from Ogrenciler1)

--Notu kolonunun veri tipini bigint'e �evir.
alter table Ogrenciler1 alter column notu bigint

alter table Ogrenciler1 alter column notu int

--adres kolonunun veri tipi varchar(70)'e �evir. (�ncesinde varchar(50) idi.)
alter table Ogrenciler1 alter column adres varchar(70)

--��renci ad� ba� harfi p ile v aras�nda olanlar ve son harfi a ile m aras�nda olanlar� getiren sorgu
select * from Ogrenciler1 where adSoyad like '[p-v]%' and adSoyad like '%[a-m]'

--adres k�sm�nda ba� harfi a ile ba�layanlar�n verilerini getiren sorgu
-- select * from Ogrenciler1 where adres like '[a]%' veya:
select * from Ogrenciler1 where adres like 'a%'

--En y�ksek not alan 3 ki�iyi getiren sorgu
select top 3 * from Ogrenciler1 order by notu desc

--En d���k not alan 2 ki�iyi getiren sorgu
select top 2 * from Ogrenciler1 order by notu asc

--En d���k not alan 2 ��rencinin adSoyad, ya� ve notu bilgilerini getiren sorgu
select top 2 adSoyad, yas, notu from Ogrenciler1 order by notu asc