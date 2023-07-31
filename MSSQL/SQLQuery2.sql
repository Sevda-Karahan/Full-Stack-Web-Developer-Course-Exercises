create database Avm

create table Plaza
(
PlazaNo int,
PlazaAd varchar(40),
OgrenciSoyadý varchar(20),
CalisanSayisi int
)

--pk(Primary Key): Birincil Anahtar

--alter: varolan üzerinde deðiþiklik yapamak için kullanýlýr.

alter table Plaza add PlazaAdres varchar(100)

alter table Plaza add Sube varchar(40), Sehir varchar(40)