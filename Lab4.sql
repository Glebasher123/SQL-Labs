CREATE DATABASE Lab4
use Lab4;


CREATE TABLE Категория
(
[ID Категории] int not null identity PRIMARY KEY,
[Название категории] varchar(50) not null default 'Не указано'
)

alter table Категория add constraint CS_Check check ([Название категории] = 'Зефир' or [Название категории] = 'Конфеты' or [Название категории] = 'Шоколад')


CREATE TABLE Склад
(
[ID Склада] int not null identity PRIMARY KEY,
[Название склада] varchar(50) not null default 'Не указано'
)

alter table Склад add constraint CS_Check1 check ([Название склада] = 'Коммунарка' or [Название склада] = 'Красный пищевик' or [Название склада] = 'Roshen')


CREATE TABLE Товар
(
[№ товара] int not null identity PRIMARY KEY,
[Название товара] varchar(50) not null default 'Не указано',
[Вес товара] int not null default 0 CHECK([Вес товара] > 0 AND [Вес товара] < 1000),
[Цена] int not null default 0,

[ID Категории] int not null default 0,
[ID Склада] int not null default 0,
FOREIGN KEY ([ID Склада]) REFERENCES Склад([ID Склада]),
FOREIGN KEY ([ID Категории]) REFERENCES Категория([ID Категории]),

constraint CS_Check2 check ([Вес товара]>=10 or [Вес товара] <=1000)
)


CREATE TABLE Поставщик
(
[ID Поставщика] int not null identity PRIMARY KEY,
[Наименование] varchar(50) not null default 'Не указано',
[Телефон] varchar(15) not null default 'Не указано'
)

alter table Поставщик add constraint CS_Check3 check ([Наименование] = 'ООО Сладкий Алтай' or [Наименование] = 'Натуральные сладости' or [Наименование] = 'ООО Сладовик')


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

CREATE TABLE Покупатель
(
[№ Покупателя] int not null identity PRIMARY KEY,
[ФИО] varchar(50) not null default 'Не указано'
)

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
