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

alter proc sp_AddCreate
@selectAddCreate nvarchar(50),@ID int,@Name nvarchar(100),@Desc nvarchar(max),@Manuf nvarchar(50),@Cost int
as
begin
	set nocount on;
	if @selectAddCreate = 'Add'
	begin
		insert into Products(ProductID,ProductName,ProductDescription,ProductManufacturer,ProductCost)
		values(@ID,@Name,@Desc,@Manuf,@Cost);
	end
	else if @selectAddCreate = 'Create'
	begin
		update Products
		set ProductName = @Name,
			ProductDescription = @Desc,
			ProductManufacturer = @Manuf,
			ProductCost = @Cost
			where ProductID = @ID;
	end
end;

execute sp_AddCreate 'add','','test','test2','test','555'
execute sp_AddCreate 'Create','1','Лакомство','Лакомство для кошек Dreamies Подушечки с курицей, 140 г','Dreames','124'

alter proc sp_Delete
@ID int
as
begin
	delete from Products where ProductID = @ID
end

execute sp_Delete '0'