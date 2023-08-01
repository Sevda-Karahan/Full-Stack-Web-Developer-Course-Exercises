--BankaIst Ad�nda veritaban� olu�turun. 

create database BankaIst
use BankaIst
-- BankaBilgileri adl� tablo ol�turun. Tabloya �u alanlar� ekleyin:
-- bankaNo int primary key identity
-- bankaAdi varchar(50)
-- bankaAdres varchar(50)
-- bakiye money

create table BankaBilgileri
(
bankaNo int primary key identity,
bankaAdi varchar(50),
bankaAdres varchar(50),
bakiye money
)

-- insert ile 4 kay�t girilsin

insert into BankaBilgileri (bankaAdi, bankaAdres, bakiye) values ('Ziraat', '�stanbul', 2000)
insert into BankaBilgileri (bankaAdi, bankaAdres, bakiye) values ('Kuveyt T�rk', '�stanbul', 1000)
insert into BankaBilgileri (bankaAdi, bankaAdres, bakiye) values ('Yap� Kredi', 'Ankara', 1000)
insert into BankaBilgileri (bankaAdi, bankaAdres, bakiye) values ('Finansbank', 'Ordu', 5000)

--BankaBilgileri tablosundaki veriler getirilsin
select * from BankaBilgileri

--Kay�tl� banka say�s�
select count(*) from BankaBilgileri

--Tabloda kay�tl� en y�ksek bakiye
select max(bakiye) from BankaBilgileri 

--Tablodaki toplam bakiye
select sum(bakiye) from BankaBilgileri 

--BankaBilgileri tablosuna aciklama adl� s�tun ekle
alter table BankaBilgileri add aciklama varchar(50)

--BankaBilgileri tablosuna aciklama adl� s�tunu sil
alter table BankaBilgileri drop column aciklama 

--bankaAdres alan�nda ba� harfi	i ile ba�layan isimlerin bilgisi getiren sorgu
select * from BankaBilgileri where bankaAdres like 'i%'

--bankaAdi alan tipini varchar(40) olarak de�i�tirelim.
alter table BankaBilgileri alter column bankaAdi varchar(40)

--bakiyesi en y�ksek iki ki�iyi getiren sorgu
select top 2 * from BankaBilgileri order by bakiye desc

----bakiyesi en d���k ki�inin bilgilerini getiren sorgu
select * from BankaBilgileri where bakiye=(select min(bakiye) from BankaBilgileri)

--Tablo i�erisindeki b�t�n kay�tlar� silen sorgu
truncate table BankaBilgileri
