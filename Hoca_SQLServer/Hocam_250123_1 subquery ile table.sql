--250121 Ödevleri
--Müşteri tablosunda ContactNme içinde son geçen müşterilerin yaptığı her siparişlerde kaç ürün satıldığını, hangi persomelin bu siparişte çalıştığı, sipariş tarihi, Kargo maliyetini hesaplayınız 

use NorthwindDB

--select 

--c.CategoryName,
--SanalTablo.ProductName,SanalTablo.UnitPrice
--from (select *from Products)  as SanalTablo
--inner join Categories as c on c.CategoryID=SanalTablo.CategoryID

--1- Müşteri tablosunda ContactNme içinde son geçen müşterilerin yaptığı her siparişlerde kaç ürün satıldığını
--2-, hangi persomelin bu siparişte çalıştığı, sipariş tarihi, Kargo maliyetini hesaplayınız 

--select 
--  c.ContactName,o.OrderDate,o.Freight
--from
--Customers  as c
--inner join Orders as o  on o.CustomerID=c.CustomerID
--where ContactName like '%son%'
--order by c.ContactName

declare @aramaKelimesi nvarchar(250)='rst'
--declare @tarih datetime=getdate()
--declare @sayi int=90
--declare @fiyat decimal(16,2)=14.45

select 
sanalTablo.ContactName,e.FirstName,e.LastName,
sanalTablo.OrderDate,sanalTablo.Freight
,SUM(od.Quantity)
--sanal tablo alanı
from
(
select 
  c.ContactName,o.OrderDate,o.Freight,o.OrderID,o.EmployeeID
from
Customers  as c
inner join Orders as o  on o.CustomerID=c.CustomerID
where ContactName like '%'+@aramaKelimesi+'%'
) as sanalTablo--
--
inner join [Order Details] as od on od.OrderID=sanalTablo.OrderID
inner join Employees as e on e.EmployeeID=sanalTablo.EmployeeID
group by e.FirstName,e.LastName,sanalTablo.OrderDate,sanalTablo.Freight,sanalTablo.ContactName
