create proc Ogr_Listele --Listeleme Prosedürü
as begin
select * from Ogrenciler
end

create proc Ogr_Kaydet
@OgrenciNo int,
@AdSoyad varchar(50),
@Sinif varchar(10),
@Matematik int,
@Turkce int,
@Tarih int
as begin 
insert into Ogrenciler (OgrenciNo,AdSoyad,Sinif,Matematik,Turkce,Tarih) values (@OgrenciNo,@AdSoyad,@Sinif,@Matematik,@Turkce,@Tarih)
end

create proc Ogr_Guncelle
@ID int,
@OgrenciNo int,
@AdSoyad varchar(50),
@Sinif varchar(10),
@Matematik int,
@Turkce int,
@Tarih int
as begin 
update Ogrenciler set OgrenciNo=@OgrenciNo, AdSoyad=@AdSoyad, Sinif=@Sinif, Matematik=@Matematik, Turkce=@Turkce, Tarih=@Tarih where ID=@ID 
end

create proc Ogr_Sil
@ID int
as begin
delete from Ogrenciler where ID=@ID
end