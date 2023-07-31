-- EOKUL ad�nda database olu�tur.
-- Okul ad�nda tablo olu�tur.

-- ogrenciNo (primary key, identity)  -----> identity : oto-increment
-- ogrenciAdi
-- soyadi
-- bolumu
-- dogumYeri 

-- 4 kay�t girelim (insert)

-- t�m tablo verilerini sorguyla getirelim.
-- adlar� alfabetik s�ralatal�m.
-- B�l�m� Bilgisayar M�hendisli�i olanlar�n verilerini sorgu ile getirelim.
-- 1 nolu ��rencinin ad�n� de�i�tirelim.

create database EOKUL

create table Okul
(
ogrenciNo int primary key identity,
ogrenciAdi varchar(50),
soyadi varchar(50),
bolumu varchar(50),
dogumYeri varchar(50)
)

insert into Okul (ogrenciAdi, soyadi, bolumu, dogumYeri) values ('Abuzittin','Teyare','Elektrik M�hendisli�i','Mu�')
insert into Okul (ogrenciAdi, soyadi, bolumu, dogumYeri) values ('Selim','Zorlu','Bilgisayar M�hendisli�i','Edirne')
insert into Okul (ogrenciAdi, soyadi, bolumu, dogumYeri) values ('Se�il','Eser','Hem�irelik','�stanbul')
insert into Okul (ogrenciAdi, soyadi, bolumu, dogumYeri) values ('Ece','Evgen','Hukuk','�zmir')

select * from Okul order by ogrenciAdi asc

select * from Okul where bolumu='Bilgisayar M�hendisli�i'

update Okul set ogrenciAdi='Abi' where ogrenciNo=1
