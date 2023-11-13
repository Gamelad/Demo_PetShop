select*from Users
select*from Products

alter proc sp_FilterSort
@selectFilter nvarchar(50),@selectSort nvarchar(50),@textSearch nvarchar(255)
as
begin 
	select*from Products
	where (@selectFilter = 'Все производители' 
    or ProductManufacturer like '%'+@selectFilter+'%') 
	and(
	ProductDescription like '%'+@textSearch+'%'
	or ProductCost like '%'+@textSearch+'%'
	or ProductManufacturer like '%'+@textSearch+'%'
	or ProductName like '%'+@textSearch+'%')
	order by case 
	when @selectSort = '1' then ProductCost else null
	end asc,
	case 
	when @selectSort = '2' then ProductCost else null 
	end desc;	
end;

execute sp_FilterSort 'Все производители','0',''