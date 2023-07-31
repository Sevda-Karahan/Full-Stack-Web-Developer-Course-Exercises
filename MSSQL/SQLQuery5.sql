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

--Tabloya deneme adl� sutun eklendi.
alter table Ogrenciler1 add deneme int 

--Tablodan deneme adl� sutun silindi.
alter table Ogrenciler1 drop column deneme

insert into Ogrenciler1 (ogrenciNo, adSoyad, yas, adres, telefon) values (352, 'Sevda', 21, '�stanbul', 5385467890)
insert into Ogrenciler1 (ogrenciNo, adSoyad, yas, adres, telefon) values (415, 'Sibel', 20, 'Kars', 5769383456)

--Tablodaki toplam kay�t say�s�
select COUNT(*) from Ogrenciler1

--Tabloda �stanbul'da ya�ayan ��renci say�s�
select COUNT(*) from Ogrenciler1 where adres='�stanbul'

--Odeme isimli kolon silindi
alter table Ogrenciler1 drop column Odeme

select * from Ogrenciler1

--TRUNCATE (Tabloyu S�f�rlar)
truncate table Ogrenciler1
