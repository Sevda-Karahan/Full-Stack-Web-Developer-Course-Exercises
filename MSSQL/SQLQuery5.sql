create database Okul1

create table Ogrenciler1
(
ogrenciNo int not null,
adSoyad varchar(40) null,
yas int,
adres varchar(50),
telefon char(11),
Odeme money
)

select * from Ogrenciler1

--Tabloya notu stunu eklendi.
alter table Ogrenciler1 add notu int 

--Tabloya deneme adlý sutun eklendi.
alter table Ogrenciler1 add deneme int 

--Tablodan deneme adlý sutun silindi.
alter table Ogrenciler1 drop column deneme

insert into Ogrenciler1 (ogrenciNo, adSoyad, yas, adres, telefon) values (352, 'Sevda', 21, 'Ýstanbul', 5385467890)
insert into Ogrenciler1 (ogrenciNo, adSoyad, yas, adres, telefon) values (415, 'Sibel', 20, 'Kars', 5769383456)

--Tablodaki toplam kayýt sayýsý
select COUNT(*) from Ogrenciler1

--Tabloda Ýstanbul'da yaþayan öðrenci sayýsý
select COUNT(*) from Ogrenciler1 where adres='Ýstanbul'

--Odeme isimli kolon silindi
alter table Ogrenciler1 drop column Odeme

select * from Ogrenciler1

--TRUNCATE (Tabloyu Sýfýrlar)
truncate table Ogrenciler1
