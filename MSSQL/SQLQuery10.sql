use ozHospital1

select Hastalar.AdSoyad,Teshis from Hastalar inner join HastaDurum on Hastalar.HastaNo=HastaDurum.HastaNo
select Hastalar.AdSoyad, Yas, Kg from Hastalar left join HastaDurum on Hastalar.HastaNo=HastaDurum.HastaNo
select Hastalar.AdSoyad, Yas, Kg from Hastalar right join HastaDurum on Hastalar.HastaNo=HastaDurum.HastaNo
