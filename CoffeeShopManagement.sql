create database CoffeeShopManagement
go
use CoffeeShopManagement

-- Food 
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfor

create table table_food(
	id int identity primary key,
	name nvarchar(100) not null default N'Bàn chưa có tên',
	status nvarchar(100) not null default N'Trống' -- trong || co nguoi
); 
go

create table account(
	display_name nvarchar(100) not null,
	username varchar(100) primary key,
	password varchar(100) not null default 0,
	type int not null default 0 -- 1: admin && 0: staff
);
go

create table food_category(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
); 
go

create table food(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	food_category_id int not null,
	price float not null,

	foreign key (food_category_id) references food_category(id)
);
go 

create table bill(
	id int identity primary key,
	checkin_date date not null,
	checkout_date date,
	table_id int not null,
	status int not null, --1: da thanh toan && 0: chua thanh toan

	foreign key (table_id) references table_food(id) 
);
go

create table bill_info(
	id int identity primary key,
 	bill_id int not null,
	food_id int not null,
	count int not null default 0,

	foreign key (bill_id) references bill(id),
	foreign key (food_id) references food(id),

);


insert into account
values (
		N'Truong Khai',
		N'Admin',
		'1',
		1);

insert into account
values (
		N'Nhan vien ABC',
		N'ABC',
		'0',
		0);
go
										

create proc USP_GetAccountByUserName
@username varchar(100)
as
begin 
	select * from account where username = @username
end
go
	 
exec USP_GetAccountByUserName @username = N'Admin'


select * from account 
where username = 'Admin' and password = '1'



create proc USP_Login
@username varchar(100), @password varchar(100)
as
begin
	select * from account where username = @username and password = @password
end

-- insert 10 rows into table_food
declare @i int = 0
while @i <= 10
begin 
   insert into table_food(name) values (N'Bàn ' + cast(@i as nvarchar(100)))
   set @i = @i + 1
end

-- CREATE PROCEDURE GET TABLE LIST
create proc USP_GetTableList
as 
select * from table_food

exec USP_GetTableList

-- insert category
insert into food_category values(N'Hải sản');
--insert into food_category values(N'Ốc');
insert into food_category values(N'Bò');
insert into food_category values(N'Heo');
--insert into food_category values(N'Dê');
insert into food_category values(N'Gà');
--insert into food_category values(N'Cá');
insert into food_category values(N'Trái cây');
insert into food_category values(N'Nước các loại');

-- insert Food
insert into food values(N'Lẩu gà hầm sả', 6, 120000);
insert into food values(N'Cánh gà chiên nước mắm', 6, 60000);
insert into food values(N'Tôm nướng muối ướt',1, 50000);
--insert into food values(N'Cá lốc nướng', 7, 110000);
insert into food values(N'Gỏi bò bóp thấu', 3, 90000);
insert into food values(N'Thơm, ổi, xoài, dưa hấu', 8, 50000);
--insert into food values(N'Cà na rang muối', 2, 30000);
insert into food values(N'Bò nướng', 3, 150000);
insert into food values(N'Bò lúc lắc', 3, 90000);
insert into food values(N'Chân gà nướng', 6, 60000);
insert into food values(N'Mề gà nướng', 6, 70000);
insert into food values(N'Gà nướng', 6, 100000);
insert into food values(N'Cafe đen', 9, 17000);
insert into food values(N'Cafe sữa', 9, 20000);
insert into food values(N'7 up', 9, 15000);
insert into food values(N'Coca', 9, 15000);
insert into food values(N'Sitting', 9, 15000);

-- insert Bill
insert into bill values(GETDATE(), null, 1, 0);
insert into bill values(GETDATE(), GETDATE(), 2, 1);
insert into bill values(GETDATE(), null, 3, 0);
insert into bill values(GETDATE(), null, 4, 0);

-- insert bill_infor
insert into bill_info values (1, 1, 5);
insert into bill_info values (2, 1, 2);
insert into bill_info values (3, 1, 3);
insert into bill_info values (4, 1, 4);


select f.name, bi.count, f.price, f.price*bi.count as total_price from bill_info as bi, bill as b, food f
where bi.bill_id = b.id and bi.food_id = f.id and b.table_id = 3 


-- Create procedure insert bill
create proc USP_InsertBill
@table_id int
as
begin
	insert into bill(checkin_date, checkout_date, table_id, status)
	values (GETDATE(), null, @table_id, 0);
end

-- TẠO PROCEDURE INSERT BILL INFO

create proc USP_InsertBillInfo
@bill_id int, @food_id int, @count int -- Khai báo 3 biến truyền vào
as
begin
	insert into bill_info (bill_id, food_id, count)
	values (@bill_id, @food_id, @count)
end

-- ALTER PROCEDURE INSERT BILL INFO

create proc USP_InsertBillInfo
@bill_id int, @food_id int, @count int -- khai báo biến truyền vào
as
begin
	declare @isExistBillInfo int -- biến: bill đã tồn tại hay chưa
	declare @foodCount int		 -- biến: số lượng từng món 

	select @isExistBillInfo = id, @foodCount = count from bill_info
	where bill_id = @bill_id and food_id = @food_id

	if(@isExistBillInfo > 0)  -- bill đã tồn tại thì thực hiện update count và delete count
	begin
		declare @newCount int = @foodCount + @count
		if (@newCount > 0) -- Nếu số lượng trong bill > 0 thì cộng lên
			update bill_info set count = @foodCount + @count where food_id = @food_id 
		else	
			delete bill_info where bill_id = @bill_id and food_id = @food_id
	end
	else  -- ngược lại bill chưa tồn tại insert mới bảng bill_info
	begin
		insert into bill_info (bill_id, food_id, count)
		values (@bill_id, @food_id, @count) 
	end
end


-- CREAE TRIGGER UPDATE BILL INFO
alter trigger UTG_UpdateBillInfo
on bill_info for insert, update
as
begin
	declare @bill_id int
	select @bill_id = bill_id from inserted

	declare @table_id int 
	select @table_id = table_id from bill where id = @bill_id and status = 0

	-- Xử lý chuyển bàn đổi status
	declare @count int
	select @count = count(*) from bill_info where bill_id = @bill_id

	if(@count > 0)
	begin
		update table_food set status = N'Trống' where id = @table_id 
	end
	else 
	begin
		print @table_id
		print @bill_id
		print @count

		update table_food set status = N'Có người' where id = @table_id 
	end
end


-- CREAE TRIGGER UPDATE BILL
create trigger UTG_UpdateBill
on bill for update
as
begin
	declare @bill_id int 
	select @bill_id = id from inserted
	
	declare @table_id int
	select @table_id = table_id from bill where id = @bill_id
	
	declare @count int = 0
	select @count = count(*) from bill where table_id = @table_id and status = 0
	
	if(@count = 0)
		update table_food set status = N'Trống' where id = @table_id   
end


-- CREATE PROCEDURE CHUYEN BAN
create proc USP_SwitchTable
@tableId1 int, @tableId2 int 
as
begin
	declare @firstBillId int 
	declare @secondBillId int
	declare @isFirstTableEmpty int = 1
	declare @isSecondTableEmpty int = 1

	select @secondBillId = id from bill where table_id = @tableId2 and status = 0
	select @firstBillId = id from bill where table_id = @tableId1 and status = 0

	-- neu bill 1 null -> tao 1 bill moi
	if(@firstBillId is null)
	begin
		insert into bill (checkin_date, checkout_date, table_id, status)
		values (GETDATE(), null, @tableId1, 0);

		select @firstBillId = max(id) from bill where table_id = @tableId1 and status = 0 
	end
	select @isFirstTableEmpty = count(*) from bill_info where bill_id = @firstBillId 

	-- bill 2
	if(@secondBillId is null)
	begin
		insert into bill (checkin_date, checkout_date, table_id, status)
		values (GETDATE(), null, @tableId2, 0);

		select @secondBillId = max(id) from bill where table_id = @tableId2 and status = 0 
	end

	select @isSecondTableEmpty = count(*) from bill_info where bill_id = @secondBillId 
	select id into BillInfoTableId from bill_info where bill_id = @secondBillId
	update bill_info set bill_id = @secondBillId where bill_id = @firstBillId
	update bill_info set bill_id = @firstBillId where id in (select * from BillInfoTableId)

	drop table BillInfoTableId
	if(@isFirstTableEmpty = 0)
		update table_food set status = N'Trống' where id = @tableId2
	if(@isSecondTableEmpty = 0)
		update table_food set status = N'Trống' where id = @tableId1
end



-- CREATE PROCEDURE GET LIST BILL
create proc USP_GetListBill		 
@checkin date, @checkout date
as
begin
	select t.name as [Tên bàn], b.totalPrice as [Tổng bill], b.checkin_date as [Ngày vào], b.checkout_date as [Ngày ra] 
	from bill as b, table_food as t
	where checkin_date >= @checkin and checkout_date <= @checkout and b.status = 1 and b.table_id = t.id
end 

exec USP_GetListBill @checkin = '2020/12/09', @checkout = '2020/12/09' 


-- CREATE PROCEDURE UPDATE ACCOUNT
create proc USP_UpdateAccount
@username varchar(100), @display_name nvarchar(100), @password varchar(50), @newpassword varchar(100)
as
begin
	declare @isRightPass int = 0

	select @isRightPass = count(*) from account where username = @username and password = @password
	if(@isRightPass = 1)
	begin
		-- truong hop chi doi display name -> chi cap nhat display name 
	   if(@newpassword = null or @newpassword = '')
	   begin
		  update account set display_name = @display_name where username = @username
	   end
	   -- nguoc lai user co nhap newpassword -> cap nhat lai ca password 
	   else
	    update account set display_name = @display_name, password = @newpassword where username = @username
	end
end

-- CREATE TRIGGER DELETE FOOD  (bill, bill_info)
create trigger UTG_DeleteFood
on bill_info for delete
as
begin
   declare @bill_info_id int
   declare @bill_id int
   select @bill_info_id = id, @bill_id = deleted.bill_id from deleted

   declare @table_id int
   select @table_id = table_id from bill where id = @bill_id

   declare @count int = 0

   select @count = count(*) from bill_info as bi, bill as b
   where b.id = bi.bill_id and b.id = @bill_id and b.status = 0

   if(@count = 0)
    	update table_food set status = N'Trống' where id = @table_id
end

--- FUNCTION CONVERT SIGN 
CREATE FUNCTION FunctionConVertSign(@inputVar NVARCHAR(MAX) )
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
    RETURN @inputVar
END

SELECT * FROM food WHERE dbo.FunctionConVertSign(name) LIKE N'%up%'
---------------------------

select username, display_name, type from account


select * from bill
select * from bill_info				    
select * from food
select * from food_category
select * from table_food
select * from account



