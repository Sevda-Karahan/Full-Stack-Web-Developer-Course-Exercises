-- EOKUL adýnda database oluþtur.
-- Okul adýnda tablo oluþtur.

-- ogrenciNo (primary key, identity)  -----> identity : oto-increment
-- ogrenciAdi
-- soyadi
-- bolumu
-- dogumYeri 

-- 4 kayýt girelim (insert)

-- tüm tablo verilerini sorguyla getirelim.
-- adlarý alfabetik sýralatalým.
-- Bölümü Bilgisayar Mühendisliði olanlarýn verilerini sorgu ile getirelim.
-- 1 nolu öðrencinin adýný deðiþtirelim.

create database EOKUL

create table Okul
(
ogrenciNo int primary key identity,
ogrenciAdi varchar(50),
soyadi varchar(50),
bolumu varchar(50),
dogumYeri varchar(50)
)

insert into Okul (ogrenciAdi, soyadi, bolumu, dogumYeri) values ('Abuzittin','Teyare','Elektrik Mühendisliði','Muþ')
insert into Okul (ogrenciAdi, soyadi, bolumu, dogumYeri) values ('Selim','Zorlu','Bilgisayar Mühendisliði','Edirne')
insert into Okul (ogrenciAdi, soyadi, bolumu, dogumYeri) values ('Seçil','Eser','Hemþirelik','Ýstanbul')
insert into Okul (ogrenciAdi, soyadi, bolumu, dogumYeri) values ('Ece','Evgen','Hukuk','Ýzmir')

select * from Okul order by ogrenciAdi asc

select * from Okul where bolumu='Bilgisayar Mühendisliði'

update Okul set ogrenciAdi='Abi' where ogrenciNo=1
