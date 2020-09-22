CREATE DATABASE Lab5
use Lab5;

CREATE TABLE Категория
(
[ID Категории] int not null identity PRIMARY KEY,
[Название категории] varchar(50) not null default 'Не указано'
)

alter table Категория add constraint CS_Check check ([Название категории] = 'Зефир' or [Название категории] = 'Конфеты' or [Название категории] = 'Шоколад')

insert into Категория ([Название категории]) values ('Зефир')
insert into Категория ([Название категории]) values ('Конфеты')
insert into Категория ([Название категории]) values ('Шоколад')
insert into Категория ([Название категории]) values ('Конфеты')
insert into Категория ([Название категории]) values ('Зефир')

update Категория set [Название категории]='Конфеты' where [Название категории]='Шоколад'
update Категория set [Название категории]='Зефир' where [Название категории]='Конфеты'

delete from Категория where [Название категории]='Конфеты'


CREATE TABLE Склад
(
[ID Склада] int not null identity PRIMARY KEY,
[Название склада] varchar(50) not null default 'Не указано'
)

alter table Склад add constraint CS_Check1 check ([Название склада] = 'Коммунарка' or [Название склада] = 'Красный пищевик' or [Название склада] = 'Roshen')

insert into Склад ([Название склада]) values ('Roshen')
insert into Склад ([Название склада]) values ('Коммунарка')
insert into Склад ([Название склада]) values ('Roshen')
insert into Склад ([Название склада]) values ('Коммунарка')
insert into Склад ([Название склада]) values ('Красный пищевик')

update Склад set [Название склада]='Roshen' where [Название склада]='Красный пищевик'
update Склад set [Название склада]='Красный пищевик' where [Название склада]='Roshen'

delete from Склад where [Название склада]='Коммунарка'


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

constraint CS_Check2 check ([Вес товара]>=10 or [Вес товара] <=1000)
)

insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Зефир в шоколаде', 200, 15, 1, 1)
insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Зефир лимонный', 500, 7, 2, 1)
insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Зефир розовый', 400, 11, 3, 3)
insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Зефир белый', 700, 5, 4, 3)
insert into Товар ([Название товара], [Вес товара], [Цена], [ID Категории], [ID Склада]) values ('Зефир лимонный', 1000, 14, 2, 1)


update Товар set [Вес товара]='100' where [Вес товара]='400'
update Товар set [Цена]='22' where [Цена]='5'

delete from Товар where [Вес товара]='200'
delete from Товар where [Цена]='11'


CREATE TABLE Поставщик
(
[ID Поставщика] int not null identity PRIMARY KEY,
[Наименование] varchar(50) not null default 'Не указано',
[Телефон] varchar(20) not null default 'Не указано'
)

alter table Поставщик add constraint CS_Check3 check ([Наименование] = 'ООО Сладкий Алтай' or [Наименование] = 'Натуральные сладости' or [Наименование] = 'ООО Сладовик')

insert into Поставщик ([Наименование], [Телефон]) values ('ООО Сладкий Алтай', '253-53-24')
insert into Поставщик ([Наименование], [Телефон]) values ('Натуральные сладости', '235-96-57')
insert into Поставщик ([Наименование], [Телефон]) values ('ООО Сладкий Алтай', '562-56-45')
insert into Поставщик ([Наименование], [Телефон]) values ('Натуральные сладости', '734-64-25')
insert into Поставщик ([Наименование], [Телефон]) values ('ООО Сладовик', '665-72-44')

update Поставщик set [Телефон]='номер недоступен' where [Телефон]='665-72-44'

delete from Поставщик where [Наименование]='Натуральные сладости'


CREATE TABLE Поставка
(
[ID Поставки] int not null identity PRIMARY KEY,
[Количество] varchar(50) not null default 0,
[Дата Поставки] date not null default '2020-01-01',

[ID Поставщика] int not null default 0,
[№ товара] int not null default 0,
FOREIGN KEY ([ID Поставщика]) REFERENCES Поставщик([ID Поставщика]),
FOREIGN KEY ([№ товара]) REFERENCES Товар([№ товара]),

constraint CS_Check4 check ([Количество]>=100 or [Количество] <=1500)
)

insert into Поставка ([Количество], [Дата Поставки], [ID Поставщика], [№ товара]) values (250, '2020-01-02', 1, 2)
insert into Поставка ([Количество], [Дата Поставки], [ID Поставщика], [№ товара]) values (400, '2020-02-04', 1, 2)
insert into Поставка ([Количество], [Дата Поставки], [ID Поставщика], [№ товара]) values (700, '2020-02-12', 1, 5)
insert into Поставка ([Количество], [Дата Поставки], [ID Поставщика], [№ товара]) values (1400, '2020-03-25', 1, 5)
insert into Поставка ([Количество], [Дата Поставки], [ID Поставщика], [№ товара]) values (1250, '2020-04-02', 1, 4)


update Поставка set [Количество]='800' where [Количество]='250'
update Поставка set [Количество]='200' where [Количество]='700'

delete from Поставка where [№ товара]='3'


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

update Покупатель set [ФИО]='Чурганов Д.В.' where [ФИО]='Борисов А.В.'

delete from Покупатель where [ФИО]='Чурганов Д.В.'

CREATE TABLE Продажи
(
[ID Продажи] int not null identity PRIMARY KEY,
[Дата Продажи] date not null default '2020-01-01',
[Количество] varchar(50) not null default 0,
[Цена продажи] varchar(10) not null default 0,

[№ товара] int not null default 0,
[№ Покупателя] int not null default 0,

FOREIGN KEY ([№ товара]) REFERENCES Товар([№ товара]),
FOREIGN KEY ([№ Покупателя]) REFERENCES Покупатель([№ Покупателя]),

constraint CS_Check5 check ([Количество]>=100 or [Количество] <=1500)
)


insert into Продажи ([Дата Продажи], [Количество], [Цена продажи], [№ товара], [№ Покупателя]) values ('2020-01-02', 150, 50, 2, 2)
insert into Продажи ([Дата Продажи], [Количество], [Цена продажи], [№ товара], [№ Покупателя]) values ('2020-03-12', 400, 100, 2, 2)
insert into Продажи ([Дата Продажи], [Количество], [Цена продажи], [№ товара], [№ Покупателя]) values ('2020-02-25', 1200, 200, 4, 3)
insert into Продажи ([Дата Продажи], [Количество], [Цена продажи], [№ товара], [№ Покупателя]) values ('2020-03-31', 800, 150, 5, 4)
insert into Продажи ([Дата Продажи], [Количество], [Цена продажи], [№ товара], [№ Покупателя]) values ('2020-02-11', 600, 120, 5, 4)


update Продажи set [Количество]='800' where [Количество]='1200'
update Продажи set [Количество]='1250' where [Количество]='800'

delete from Продажи where [Цена продажи]='50'
