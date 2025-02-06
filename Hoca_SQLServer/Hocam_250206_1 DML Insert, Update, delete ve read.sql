use YasinETicaretDersDB

select *from Categories
--DML
--Crud=> Insert(Create),REad, Update, delete

Insert into Categories ([Name]) values ('Kablo')
Insert into Categories ([Name]) values ('Mikrofon')
--
select *from Products
--*******************************************************************
--insert
insert into Products 
(Name,Price,Stock,CreateDate,Descriptions,UserId,CategoryId) values
('10 metre siyah',25,200,GETDATE(),'ttest için ekleme yapıldı',2,3)
select *from Users
insert into Users 
(UserName,UserTitle,UserHiringDate,Password,AuthorizationId) values
('Yasin','yeni personel kayıt işlemi proje yetkilisi',GETDATE(),'abv_234',1)
select *from UserAuthorizations
insert into UserAuthorizations (AuthorizationName) values('admin')
insert into UserAuthorizations (AuthorizationName) values('personel')
insert into UserAuthorizations (AuthorizationName) values('Müdür')
--******************************************************************
--update-güncelleme
--update işleminde MUTLAKA where ile ID belirtilmelidir
select *from Categories where CategoryId=4
select *from Categories where CategoryId in(3,4)
update Categories set Name='Mouse'  where CategoryId=4

select *from Products where ProductId in(4,5)
insert into Products 
(Name,Price,Stock,CreateDate,Descriptions,UserId,CategoryId) values
('10 metre siyah',25,200,GETDATE(),'ttest için ekleme yapıldı',2,3)
--insert işleminde eklenmeye çalışılan kayıt eğer başarısız ise PK onu oto olarak 1 artırır, her başarısız işlemde bu böyle devam eder

select *from Products where ProductId in(4,5,7)
update Products set 
Name='27" LCD TV',
Price=8900,
Stock=12,
CreateDate=GETDATE(),
CategoryId=2
where ProductId=4
--************************************
--değişik Insert etme işlemleri
select *from Products
select *from Categories
--mikro 5
insert into Products 
values
('Stiless mikrofon',4500,15,GETDATE(),'ürün toptan alındı',2,5)
--Insert ile yer değiştirme kolonlar
insert into Products 
(CategoryId,Name,CreateDate,Price,Stock,Descriptions,UserId)
values
(5,'Stiless mikrofon',GETDATE(),4500,15,'ürün toptan alındı',2)
--select ile Insert ekleme
insert into Products select Name,Price,Stock,CreateDate,Descriptions,UserId,CategoryId from Products 
--******************************************
declare @degiskenAdi nvarchar(250)='Stok yetersiz'
declare @sayi int 

SET @sayi=(SELECT SUM(Stock) FROM Products)

if(@sayi>1000)
BEGIN--{
select * from Products
END--}
else
BEGIN

--SELECT @degiskenAdi
print 'STOK YETERSİZ'
END
--5-20 ARASINDA TABLOLARA DATA EKLENECEK




