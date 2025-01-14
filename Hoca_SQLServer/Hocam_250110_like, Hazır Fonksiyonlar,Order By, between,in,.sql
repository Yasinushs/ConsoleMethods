--Ders-2 
/*
like, Hazır Fonksiyonlar,Order By-top, between,in,

*/
--Like=> arama işlemlerinde kullanılır
use NorthwindDB

select* from Products where ProductName='chai'
select* from Products where ProductName like 'chai'
select* from Products where ProductName like '%ch%'--içinde ch geçenleri aratır
--%,_
select* from Products where ProductName like '%ch'--sonu ch ile bitenler, başında ne ile başladığı önemsiz olan yapıları listeler
select* from Products where ProductName like '%i'--sonu i ile biteleri getirir

select* from Products where ProductName like 'i%'--i harfi ile başlayıp, sonu ne ile bittiği önemsiz gibi arama yapar
select* from Products where ProductName like '%i%'--içinde i harfi geçen, başta, sonda, ortada yani yer bağımsız i içeren kayıtları getirir
select* from Products where ProductName like '_i%'--2. harfi i olan, sonu ne ile bittiği önemsiz olan kayıtları listeler
select* from Products where ProductName like '_i%' and (UnitsInStock>30 and UnitPrice>20)
--*********************************************************
--Hazır fonksiyonlar sum, count,avg
select  SUM(UnitsInStock) from Products --sum toplama yapar
select *from Products
select COUNT(*) from Products --Count ile data lar bir bir sayılır.
select SUM(2+8)--toplam 10 gösterir
select count(2+8)--adet sayımı yapar, 1 gösterir.
--count eğer null değer gelirse sayım yapmaz, es geçer
select * from Products
select COUNT(ProductID) from Products--78 sonuç gelir
select COUNT(CategoryID) from Products--77 sonuç gelecek. Bunun nedeni CategoryId kolonunda bir değer null dır bunu Count okuyamaz
/*
(7+5)/2=6
*/
select SUM(UnitPrice)/COUNT(UnitPrice) as 'Ortalama' from Products
select AVG(UnitPrice) 'Ortalama' from Products
--Hazır fonksiyon ile birden fazla kolon işlemi yapıldıysa 2. bir kolon çağırma işlemi ancak group by ile olur
select SUM(UnitPrice) as ToplamFiyat, SUM(UnitsInStock) as ToplamStok from Products
--****************************************************
--Order By => sıralama yapar
select *from Products order by UnitPrice --küçükten büyüğe ya da a-z ye sıralama yapar.Eğer asc (ascending) yoksa oto olarak asc yapar ve asc 1-büyüğe ya da a-z ye sıralama yapar
select *from Products order by UnitPrice  asc
select *from Products order by UnitPrice  desc--desc ise descanding demektir bu da büyükten-küçüğe ya da z-a ya sırlama yapar
--top kullanımı
select top 10 *from Products order by UnitPrice 
--Order by bir SQL kodunda her zaman en sonda yazılması gereklidir
--**************************************************
--between aralık değerinde arama yapmak için kullanılır. Verilen aralık değerindeki değerler eşit olarak kabul edilir
select *from Products where UnitPrice between 10 and 20
select *from Products where UnitPrice>=10 and UnitPrice<=20 
select *from Products where UnitPrice>=10 and UnitPrice<=20 order by UnitPrice
--*************************************************
--in=> içeren dataları ama eşitlik için
select *from Products where UnitPrice=10 or UnitPrice=20 or UnitPrice=30 or UnitPrice=40
select *from Products where UnitPrice in (10,20,30,40)
--*******************************************
--1)ürün fiyatı 15-20 arasında olan ilk 5 ürünü ürünadı, fiyatı,stoğu getirinz
--2)Siparişler tablosunda en çok kargo ödemesi yapılan 10 siparişi kodlayınız
--3)en son sipariş veren 15 müşteriyi listeleyiniz(customerId, freight, OrderDate,OrderId, EmployeId)
--4)En pahalı satılan 20 ürünü ProductID,OrerID,UnitPrice,Quantity kolonlarını listeleyerek gösteriniz
----*******************************
--Ödev1) En çok hangi bölgeye sipariş gittiğini bulunuz?
--Ödev2) En pahalı satılan 3 ürünü gösteriniz?
--ödev3) En çok kargo ödemesi yapılan müşteriyi listeleyiniz
--ödev4) En çok sipariş verilen yılda en fazla sipariş verilen 4 ayı gösterini






