CREATE DATABASE Lab4
use Lab4;

CREATE TABLE Категория
(
[ID Категории] int not null identity PRIMARY KEY,
[Название категории] varchar(50) not null default 'Не указано'
)


insert into Категория ([Название категории]) values ('Зефир')
insert into Категория ([Название категории]) values ('Конфеты')
insert into Категория ([Название категории]) values ('Шоколад')
insert into Категория ([Название категории]) values ('Конфеты')
insert into Категория ([Название категории]) values ('Зефир')




CREATE TABLE Склад
(
[ID Склада] int not null identity PRIMARY KEY,
[Название склада] varchar(50) not null default 'Не указано'
)


insert into Склад ([Название склада]) values ('Roshen')
insert into Склад ([Название склада]) values ('Коммунарка')
insert into Склад ([Название склада]) values ('Roshen')
insert into Склад ([Название склада]) values ('Коммунарка')
insert into Склад ([Название склада]) values ('Красный пищевик')




CREATE TABLE Товар
(
[№ товара] int not null identity PRIMARY KEY,
[Название товара] varchar(50) not null default 'Не указано',
[Вес товара] int not null default 0,
[Цена] int not null default 0,

[ID Категории] int not null default 0,
[ID Склада] int not null default 0,
FOREIGN KEY ([ID Склада]) REFERENCES Склад([ID Склада]),
FOREIGN KEY ([ID Категории]) REFERENCES Категория([ID Категории]),


)

insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Зефир в шоколаде', 200, 15, 1, 1)
insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Зефир лимонный', 500, 7, 2, 1)
insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Зефир розовый', 400, 11, 3, 3)
insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Зефир белый', 700, 5, 4, 3)
insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Зефир лимонный', 1000, 14, 2, 1)


insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Шоколад белый', 250, 28, 1, 3) 
insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Шоколад горький', 2000, 12, 1, 3) 

insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Конфеты пчёлки', 1000, 54, 5, 2) 
insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Конфеты Алёнка', 350, 32, 4, 2)

insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Зефир с карамелью', 300, 7, 4, 3)




CREATE TABLE Поставщик
(
[ID Поставщика] int not null identity PRIMARY KEY,
[Наименование] varchar(50) not null default 'Не указано',
[Телефон] varchar(20) not null default 'Не указано'
)


insert into Поставщик ([Наименование], [Телефон]) values ('ООО Сладкий Алтай', '253-53-24')
insert into Поставщик ([Наименование], [Телефон]) values ('Натуральные сладости', '235-96-57')
insert into Поставщик ([Наименование], [Телефон]) values ('ООО Сладкий Алтай', '562-56-45')
insert into Поставщик ([Наименование], [Телефон]) values ('Натуральные сладости', '734-64-25')
insert into Поставщик ([Наименование], [Телефон]) values ('ООО Сладовик', '665-72-44')




CREATE TABLE Поставка
(
[ID Поставки] int not null identity PRIMARY KEY,
[Количество] int not null default 0,
[Дата Поставки] date not null default '2020-01-01',

[ID Поставщика] int not null default 0,
[№ товара] int not null default 0,
FOREIGN KEY ([ID Поставщика]) REFERENCES Поставщик([ID Поставщика]),
FOREIGN KEY ([№ товара]) REFERENCES Товар([№ товара]),

)

insert into Поставка ([Количество], [Дата Поставки], [ID Поставщика], [№ товара]) values (250, '2020-01-02', 1, 2)
insert into Поставка ([Количество], [Дата Поставки], [ID Поставщика], [№ товара]) values (400, '2020-02-04', 1, 2)
insert into Поставка ([Количество], [Дата Поставки], [ID Поставщика], [№ товара]) values (700, '2020-02-12', 1, 5)
insert into Поставка ([Количество], [Дата Поставки], [ID Поставщика], [№ товара]) values (1400, '2020-03-25', 1, 5)
insert into Поставка ([Количество], [Дата Поставки], [ID Поставщика], [№ товара]) values (1250, '2020-04-02', 1, 4)





CREATE TABLE Покупатель
(
[№ Покупателя] int not null identity PRIMARY KEY,
[ФИО] varchar(50) not null default 'Не указано'
)


insert into Покупатель ([ФИО]) values ('Выставкин Г.С.')
insert into Покупатель ([ФИО]) values ('Букаткин В.С.')
insert into Покупатель ([ФИО]) values ('Веракса Л.И.')
insert into Покупатель ([ФИО]) values ('Иванов И.И.')
insert into Покупатель ([ФИО]) values ('Борисов А.В.')

drop table Продажи

CREATE TABLE Продажи
(
[ID Продажи] int not null identity PRIMARY KEY,
[Дата Продажи] date not null default '2020-01-01',
[Количество] int not null default 0,
[Цена продажи] int not null default 0,

[№ товара] int not null default 0,
[№ Покупателя] int not null default 0,

FOREIGN KEY ([№ товара]) REFERENCES Товар([№ товара]),
FOREIGN KEY ([№ Покупателя]) REFERENCES Покупатель([№ Покупателя]),

)


insert into Продажи ([Дата Продажи], [Количество], [Цена продажи], [№ товара], [№ Покупателя]) values ('2020-01-02', 150, 50, 2, 2)
insert into Продажи ([Дата Продажи], [Количество], [Цена продажи], [№ товара], [№ Покупателя]) values ('2020-03-12', 400, 100, 2, 2)
insert into Продажи ([Дата Продажи], [Количество], [Цена продажи], [№ товара], [№ Покупателя]) values ('2020-02-25', 1200, 200, 4, 3)
insert into Продажи ([Дата Продажи], [Количество], [Цена продажи], [№ товара], [№ Покупателя]) values ('2020-03-31', 800, 150, 5, 4)
insert into Продажи ([Дата Продажи], [Количество], [Цена продажи], [№ товара], [№ Покупателя]) values ('2020-02-11', 600, 120, 5, 4)
