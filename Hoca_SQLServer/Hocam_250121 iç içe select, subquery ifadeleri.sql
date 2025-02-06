use NorthwindDB
--iç iç e select , subquery

--hem kategori adı hem de productname, unitprice Unitinstock kolonlarını listeleyen script kodlayınız
--yukardaki soru için şuana kadar yapılanlar ile çözülemez

--ana select Products tablosunu kullandı
select 
ProductName,
UnitPrice as Fiyat,
UnitsInStock as Stok,CategoryID
--iç select için categories tablosu kullanıldı
,(select c.CategoryName from Categories as c  where c.CategoryID=p.CategoryID ) as 'Kategori Adı'
,(select s.CompanyName+'-'+ContactName from Suppliers as s where s.SupplierID=p.SupplierID) as Tedarikçi
--
from Products as p
/*
iç select kuralları
1-iç select ana select where ile bağlanmalı
2-iç select ile sadece 1 kolon çağırbilirz anacak birden fazla aynı veri tipinde kolon + ile bağlanarak kullanabilir
3-iç select ile kullanılan Id kolon PK (Primary Key) kolon olmalıdır
*/

select *from Categories
select *from Products
--OrderDate, freight, employename,customer contact name listesini veriniz
-----------------------------------------------------
--adı ch ile başlayan ürünlerin satış adetlerini hesaplayınız

select *from Products where ProductName like 'ch%'
--ch ile başlayan ProductId 1,2,4,5,39,48,78
select *from  Orders
--

select *from [Order Details] where ProductID in(1,2,4,5,39,48,78)
--bu soru subquery ile çözülür
select 
ProductID
,(select p.ProductName from Products as p where p.ProductID=od.ProductID) as 'Product Name'
,SUM(od.Quantity) as Adet

from [Order Details] as od
where 
ProductID 
in
(select ProductID from Products where ProductName like 'ch%')
group by ProductID
order by ProductID
--group by
------------------------------------------
-- adı içinde et geçen personellerin çalıştığı siparişlerde her bir siparişte kaç ürün satıldığını hesapaylan scripti E.FİrstName,E.LastName, Sipariş Tarihi ve adetini veren yapıyı kodlayınız

select *from Employees where FirstName  like '%et%'

select *from Orders where EmployeeID in (3,4)
--

select 
OrderDate,OrderID
,(select e.FirstName+SPACE(1)+e.LastName from Employees as e where e.EmployeeID=o.EmployeeID) as 'Personel Bilgisi'
,
--iç select içinde group by mevcut
(select 
SUM(od.Quantity)
from [Order Details] as od where od.OrderID=o.OrderID
group by OrderID
) as 'Ürün Sayıs'
-----------------------
from Orders as o 
where OrderID
--
in (--OrderId getiren in
select OrderID from Orders as o where EmployeeID 
in (--personel adına göre arama yapan in
select EmployeeID from Employees where FirstName  like '%et%')
)
order by o.OrderID

select SUM(Quantity) from [Order Details] where OrderID in (10252)
-----------------------------------------------------
--Müşteri tablosunda ContactNme içinde son geçen müşterilerin yaptığı her siparişlerde kaç ürün satıldığını, hangi persomelin bu siparişte çalıştığı, sipariş tarihi, Kargo maliyetini hesaplayınız

select *from Customers
----------------------------------------

--Geçen hafta ödevleri
-- her bir müşterinin (Customer) kaç tane sipariş(Order) verdiğini hesaplayınız
--her bir üründen kaç tane satıldığımı hesaplayınız
--her bir siparişte kaç ürün olduğunu hesaplayınız
-------------------------------------------------------------
--250121 Ödevleri
--Müşteri tablosunda ContactNme içinde son geçen müşterilerin yaptığı her siparişlerde kaç ürün satıldığını, hangi persomelin bu siparişte çalıştığı, sipariş tarihi, Kargo maliyetini hesaplayınız
--Her bir kategorden kaç ürün satılmış hesaplayınız
--


