--dml komutlarý
--insert(ekleme, kaydetme)

create database Magaza34

create table Malzemeler
(
malzeme int primary key,
malzemeAdi varchar(50),
fiyat int,
adet int,
uretimYeri varchar(50)
)

insert into Malzemeler(malzeme, malzemeAdi, fiyat, adet, uretimYeri) values (1, 'Bardak', 60, 100, 'Türkiye')
insert into Malzemeler(malzeme, malzemeAdi, uretimYeri) values (2, 'Macbook', 'ABD')

update Malzemeler set fiyat=38000 where malzemeAdi='Macbook'
update Malzemeler set adet=100 where malzemeAdi='Macbook'

---------------------------------------------------------------------------------------------------------------

create table Personeller
(
peresonelNo int primary key identity,
adSoyad varchar(50),
adres varchar(50),
maas int,
prim int
)

insert into Personeller	(adSoyad, adres, maas, prim) values ('Ayse Son', 'Giresun', 15000, 5000)
insert into Personeller	(adSoyad, adres, maas, prim) values ('Ayse Son', 'Giresun', 15000, 5000)
update Personeller set adSoyad='Selim Varlý', adres='Ordu', maas=12000, prim=300 where peresonelNo=2
insert into Personeller	(adSoyad, adres, maas, prim) values ('Kerem Ýkinci', 'Tekirdað', 20000, 8000)
