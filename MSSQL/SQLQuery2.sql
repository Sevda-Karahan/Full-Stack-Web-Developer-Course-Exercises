create database Avm

create table Plaza
(
PlazaNo int,
PlazaAd varchar(40),
OgrenciSoyad� varchar(20),
CalisanSayisi int
)

--pk(Primary Key): Birincil Anahtar

--alter: varolan �zerinde de�i�iklik yapamak i�in kullan�l�r.

alter table Plaza add PlazaAdres varchar(100)

alter table Plaza add Sube varchar(40), Sehir varchar(40)