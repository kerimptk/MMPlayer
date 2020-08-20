create database MMP_DB
go
use MMP_DB
go
create table calma_listesi_kart(
	id int primary key identity(1,1),
	liste_adi varchar(100),
	sil_id int default 1,
	olusturma_tarihi datetime default getdate(),
	guncelleme_tarihi datetime default getdate()
)
go
create table calma_liste_detay(
	id int primary key identity(1,1),
	calma_listesi_id int references calma_listesi_kart(id),
	parca_url varchar(1000),
	sil_id int default 1,
	olusturma_tarihi datetime default getdate(),
	guncelleme_tarihi datetime default getdate()
)