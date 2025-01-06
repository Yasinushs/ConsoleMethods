/*
SQL Server Giriş dersleri
SSMS=> SQL Server Management Studio=> Micro M ,Soft S=> MS-SQL Serever
Visual Studio => MS
.Net => Dot Net=> 
ASP Web Form--
ASP.Net MVC
ASP.Net Core=>2012-> 4 dil
MS-SQL Server 
ASP.Net CORE API
*/
/*
1-Oracle-> Postgre SQL,PL/SQL
2-MS-SQL Server
3-Mongo DB
4-My-SQL
5-SQLite
6-
SQL=> Structure Query Language=> Database bir Programlama dili değildir
.

*/
use NorthwindDB -- DB çağırmka için kullanılır
select * from Categories
select * from Products 

select  
CategoryID, 
CategoryName
from Categories
--Allians - İsimlendirme
select  
ProductID as ID,
ProductName AS 'Ürün Adı' , 
UnitsInStock as [Ürün Stoğu],
UnitPrice as Ürün_Fiyat
from Products
--***********************
-- Where-> bir koşul oluştumak için kullanılır
--Fiyatı 10 olan ürünleri getirelim
select *from Products where UnitPrice=10

/*
OPERATÖRLER
=
<
>
<=
>=
!=
and => 
or => 
*/
select *from Products where UnitPrice >= 100
select *from Products where UnitPrice >=10 and UnitPrice<=15

use NorthwindDB--DB çağırmak için kullanılır
select *from Categories

select *from Products
--select *from yazılan tabloda bütün verileri getirir
select 
--* yerine sadece istenilen kolon isimleri yazılarak sadece o kolonların verileri gösterilebilir
CategoryID,
CategoryName
from Categories
--Console=> console(C büyük olmalı)

selEct *fRom CategoriEs
--SQL de küçük-büyük harf duyarlılığı yoktur
select ProductID,ProductName ,UnitPrice,UnitsInStock from Products

--product tablosunda fiyat, adet, isim kolonlarını listele
--******************************************************************
--Allians-isimlendirme
select 
ProductID as ID,
ProductName as 'Ürün Adı' ,
UnitPrice as [Ürün Fiyatı],
UnitsInStock as ÜrünStok
from Products
--************************
--Where-> bir koşul oluşturmak için kullanılır
--Fİyatı 10 olan ürünleri getirelim
select *from Products where UnitPrice=10
/*
OPERATÖRLER
=
<
>
<=
>=
!=
and => 
or => 
*/
select *from Products where UnitPrice>=100
select *from Products where UnitPrice>=10 and UnitPrice<=15
--neler öğrendin-> select*from ,Allians,Where,Operatörler
select 
ProductID			as ID,
ProductName			as 'Ürün Adı',
UnitPrice			as  Fiyat,
UnitsInStock		as Stok

from Products where UnitPrice>=10 and UnitPrice<=15










