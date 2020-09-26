use Lab4

GO
Create trigger Count_Цена on Товар
after insert
as
if UPDATE(Цена)
begin
	declare @Цена int
	set @Цена = (select Цена from inserted)
	if @Цена > 15
		begin
		rollback tran
		print 'Цена больше 15'
	end 
end

insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Конфеты пчёлки', 1000, 14, 5, 2) 
insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Конфеты Алёнка', 350, 16, 4, 2)

GO
Create trigger Количество_Поставки on Поставка
after insert
as
if UPDATE(Количество)
begin
	declare @Counter int
	set @Counter = (select Количество from inserted)
	if @Counter < 500
		begin
		rollback tran
		print 'Количество поставки меньше 500'
	end 
end

insert into Поставка ([Количество], [Дата Поставки], [ID Поставщика], [№ товара]) values (700, '2020-01-02', 1, 2)
insert into Поставка ([Количество], [Дата Поставки], [ID Поставщика], [№ товара]) values (400, '2020-02-04', 1, 2)

GO
Create trigger Дата_Поставки on Поставка
after delete
as
begin
	print 'Вы удалили дату поставки'
end

delete from Поставка where [Дата Поставки]='2020-01-02'

GO
Create trigger Наименование_Поставщика on Поставщик
after delete
as
begin
	print 'Вы удалили одного поставщика'
end

delete from Поставщик where [ID поставщика]=2

GO
Create trigger Тип on Категория
after update
as
begin
	print 'Вы изменили тип предмета'
end

update Категория set [Название категории]='Вафли' where [Название категории]='Зефир'