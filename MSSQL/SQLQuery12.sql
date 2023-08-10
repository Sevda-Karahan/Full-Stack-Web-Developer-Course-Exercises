create proc AraOgrNo
@OgrenciNo int
as begin
select * from Ogrenciler where OgrenciNo like '%' + cast(@OgrenciNo as varchar(10)) + '%'
end

exec AraOgrNo 3
-----------------------------
create proc AraOgrAd
@AdSoyad varchar(50)
as begin
select * from Ogrenciler where AdSoyad like '%'+@AdSoyad+'%' 
end

exec AraOgrAd a
------------------------
create proc AraOgrSinif
@Sinif varchar(10)
as begin
select * from Ogrenciler where Sinif like '%'+@Sinif+'%' 
end

exec AraOgrSinif 4