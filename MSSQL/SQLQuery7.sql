--BankaIst Adýnda veritabaný oluþturun. 

create database BankaIst
use BankaIst
-- BankaBilgileri adlý tablo olþturun. Tabloya þu alanlarý ekleyin:
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

-- insert ile 4 kayýt girilsin

insert into BankaBilgileri (bankaAdi, bankaAdres, bakiye) values ('Ziraat', 'Ýstanbul', 2000)
insert into BankaBilgileri (bankaAdi, bankaAdres, bakiye) values ('Kuveyt Türk', 'Ýstanbul', 1000)
insert into BankaBilgileri (bankaAdi, bankaAdres, bakiye) values ('Yapý Kredi', 'Ankara', 1000)
insert into BankaBilgileri (bankaAdi, bankaAdres, bakiye) values ('Finansbank', 'Ordu', 5000)

--BankaBilgileri tablosundaki veriler getirilsin
select * from BankaBilgileri

--Kayýtlý banka sayýsý
select count(*) from BankaBilgileri

--Tabloda kayýtlý en yüksek bakiye
select max(bakiye) from BankaBilgileri 

--Tablodaki toplam bakiye
select sum(bakiye) from BankaBilgileri 

--BankaBilgileri tablosuna aciklama adlý sütun ekle
alter table BankaBilgileri add aciklama varchar(50)

--BankaBilgileri tablosuna aciklama adlý sütunu sil
alter table BankaBilgileri drop column aciklama 

--bankaAdres alanýnda baþ harfi	i ile baþlayan isimlerin bilgisi getiren sorgu
select * from BankaBilgileri where bankaAdres like 'i%'

--bankaAdi alan tipini varchar(40) olarak deðiþtirelim.
alter table BankaBilgileri alter column bankaAdi varchar(40)

--bakiyesi en yüksek iki kiþiyi getiren sorgu
select top 2 * from BankaBilgileri order by bakiye desc

----bakiyesi en düþük kiþinin bilgilerini getiren sorgu
select * from BankaBilgileri where bakiye=(select min(bakiye) from BankaBilgileri)

--Tablo içerisindeki bütün kayýtlarý silen sorgu
truncate table BankaBilgileri
