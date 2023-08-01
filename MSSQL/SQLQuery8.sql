--like: arama yapmak için kullanılır
--%A : a ile bitenleri getir
--A% : a ile başlayanları getir

create database DENEME
use DENEME

--Deneme_not_null isimli tablo
--ID int
--ad varchar
--soyad varchar
--telefon char(10)

create table Deneme_not_null
(
	ID int primary key identity,
	ad varchar(50),
	soyad varchar(50),
	telefon char(10) not null
)

--Deneme_Unique isimli tablo
--ID int
--TC char(11) UNIQUE
--ad varchar
--soyad varchar
--telefon char(10)

create table Deneme_Unique
(
	ID int primary key identity(100,1),
	TC char(11) UNIQUE,
	ad varchar(50),
	soyad varchar(50),
	telefon char(10) not null
)

--Deneme_Check isimli tablo
--Id, ad, soyad, yas alanları
--yas alanı 18 yasından büyük olanları kayıt edebilsin

create table Deneme_Check
(
	Id int primary key identity(1,1),
	ad varchar(50),
	soyad varchar(50),
	yas tinyint,
	check (yas>=18)
)

--Deneme_Default adlı tablo
--Id, ad, soyad, sehir alanları
--sehir alanı bos geçildiğinde otomatik İstanbul yazsın.

--constraint: kısıtlayıcı
create table Deneme_Default
(
	Id int primary key identity(1,1),
	ad varchar(50),
	soyad varchar(50),
	sehir varchar(50) constraint denemeDefault default('İstanbul'),
)


create table Deneme_Default2
(
	Id int primary key identity(1,1),
	ad varchar(50),
	soyad varchar(50),
	sehir varchar(50) default('İstanbul'),
)
