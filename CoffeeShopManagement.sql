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

-- Cau lenh insert 10 dong bang table_food
declare @i int = 0
while @i <= 10
begin 
   insert into table_food(name) values (N'Bàn ' + cast(@i as nvarchar(100)))
   set @i = @i + 1
end


create proc USP_GetTableList
as 
select * from table_food

exec USP_GetTableList

update table_food set status = N'Có người' where id = 9


select * from bill
select * from bill_info
select * from food
select * from food_category

-- insert category
insert into food_category values(N'Hải sản');
insert into food_category values(N'Ốc');
insert into food_category values(N'Bò');
insert into food_category values(N'Heo');
insert into food_category values(N'Dê');
insert into food_category values(N'Gà');
insert into food_category values(N'Cá');
insert into food_category values(N'Trái cây');

-- insert Food
insert into food values(N'Lẩu gà hầm sả', 6, 120000);
insert into food values(N'Cánh gà chiên nước mắm', 6, 60000);
insert into food values(N'Tôm nướng muối ướt',1, 50000);
insert into food values(N'Cá lốc nướng', 7, 110000);
insert into food values(N'Gỏi bò bóp thấu', 3, 90000);
insert into food values(N'Thơm, ổi, xoài, dưa hấu', 8, 50000);
insert into food values(N'Cà na rang muối', 2, 30000);
insert into food values(N'Gỏi bò bóp thấu');
insert into food values(N'Gỏi bò bóp thấu');

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

select * from food_category
select * from food

-- Create procedure insert bill
create proc USP_InsertBill
@table_id int
as
begin
	insert into bill(checkin_date, checkout_date, table_id, status)
	values (GETDATE(), null, 0,@table_id );
	
end


create proc USP_InsertBillInfo
@bill_id int, @food_id int, @count int
as
begin
	insert into bill_info (bill_id, food_id, count)
	values (@bill_id, @food_id, @count)
end


alter proc USP_InsertBillInfo
@bill_id int, @food_id int, @count int
as
begin
	declare @isExistBillInfo int
	declare @foodCount int

	select @isExistBillInfo = count(*), @foodCount = count from bill_info
	where bill_id = @bill_id and food_id = @food_id

	if(@isExistBillInfo > 0)
	begin
		update bill_info set count = @foodCount + @count 
	end
	else
	begin
		insert into bill_info (bill_id, food_id, count)
		values (@bill_id, @food_id, @count) 
	end
end

 

					   