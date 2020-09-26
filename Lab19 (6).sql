use Lab4
drop table Товар
--Явная и неявная транзакция
TRUNCATE TABLE Товар
BEGIN TRAN 
	insert into Товар ([Название товара], [Вес товара], [Цена]) values ('Слодыч шахматный', 1000, 54) 
	insert into Товар ([Название товара], [Вес товара], [Цена]) values ('Слодыч ванильный', 350, 32)
	insert into Товар ([Название товара], [Вес товара], [Цена]) values ('Конфеты Шоколапки', 300, 7)
go
select @@TRANCOUNT As Значение_транзакции
rollback tran

SELECT * FROM Товар

--Автофиксация транзакции
print 'Транзакции 1: ' + cast(@@TRANCOUNT as Char(1))

begin tran qwe
print 'После Транзакции 1: ' + cast(@@TRANCOUNT as Char(1))
	insert into Товар ([Название товара], [Вес товара], [Цена]) values ('Слодыч шахматный', 1000, 54)

begin tran qwe1
print 'Транзакции 2: ' + cast(@@TRANCOUNT as char(1))
	insert into Товар ([Название товара], [Вес товара], [Цена]) values ('Слодыч шахматный', 1000, 54)

commit tran
print 'Значения транзакции 1: ' + cast(@@TRANCOUNT as char(1))

commit tran
print 'Транзакции 1: ' + cast(@@TRANCOUNT as Char(1))

-- Функция

CREATE FUNCTION Postavka(@Количество int)  
RETURNS int   
AS   
BEGIN   
    SELECT @Количество = @Количество + 5
    RETURN @Количество;  
END; 

select dbo.Postavka(2001);
