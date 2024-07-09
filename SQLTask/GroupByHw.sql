use Northwind

-- Çalışanların yapmış olduğu sipariş adedi (orders)  

select EmployeeID, COUNT(*) as [Sifarislerin sayi] from Orders
group by EmployeeID

-- Employees tablosundan; FirstName alanına göre, isimleri ASC olarak sıraladıktan sonra, sonuç kümesinin ilk beş kaydını ülkelerine göre gruplayınız.

select Country, Count(*) as [Iscilerin umumi sayi] from (
select  TOP(5) FirstName, Country from Employees 
order by FirstName) as tbl 
group by Country

-- Ürün bedeli 35$'dan az olan ürünlerin kategorilerine göre gruplanması

select CategoryID, COUNT(*) as [Urunlerin umumi sayi] from Products where UnitPrice < 35
group by CategoryID 

-- Baş harfi A-K aralığında olan ve stok miktarı 5 ile 50 arasında olan ürünleri kategorilerine göre gruplayınız.

select CategoryID, Count(*) as [Urunlerin umumi sayi] from Products 
         where ProductName like '[A-K]%'
		 and UnitsInStock between 5 and 50 
group by CategoryID

-- Her bir siparişteki toplam ürün sayısını bulunuz.

select OrderID, sum(Quantity) as [Toplam urun sayisi] from [Order Details] group by OrderID

-- Her bir siparişin tutarına göre listelenmesi

select OrderID, sum(Quantity * UnitPrice) as [Sifarislerin tutari] from [Order Details] group by OrderID order by 2

-- Toplam tutarı 2500 ile 3500 arasında olan siparişlerin gruplanması

select OrderID, sum(Quantity * UnitPrice) as [Sifarislerin tutari]  from [Order Details] group by OrderID
having sum(Quantity * UnitPrice) between 2500 and 3500
-- order by [Sifarislerin tutari] 

-- Her bir siparişteki toplam ürün sayısı 200'den az olanlar

select OrderID, sum(Quantity) as [Toplam urun sayisi] from [Order Details] group by OrderID 
having sum(Quantity) < 200
-- order by [Toplam urun sayisi]



