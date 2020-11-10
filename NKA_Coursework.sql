create database NKA
use NKA

CREATE TABLE [Данные клиента]
(
[ID клиента] int not null identity PRIMARY KEY,
[Фамилия] varchar(50) not null default 'Не указано',
[Имя] varchar(50) not null default 'Не указано',
[Отчество] varchar(50) not null default 'Не указано',
[Контактный номер] varchar(50) not null default 'Не указано',
[Адрес проживания] varchar(50) not null default 'Не указано'
)

CREATE TABLE [Информация о участке]
(
[Кадастровый номер участка] int not null identity PRIMARY KEY,
[Адрес участка] varchar(50) not null default 'Не указано',
[Кадастровая стоимость, руб] int not null default 0,
[Уточненная площадь]  int not null default 0,
[Состояние объекта] varchar(50) not null default 'Не указано',

[ID клиента] int not null default 0,
FOREIGN KEY ([ID клиента]) REFERENCES [Данные клиента]([ID клиента])
)

CREATE TABLE [Информация о строительстве]
(
[Номер строительства] int not null identity PRIMARY KEY,
[Поставщик бетона] varchar(50) not null default 'Не указано',
[Поставщик кирпича] varchar(50) not null default 'Не указано',
[Поставщики отделочных материалов] varchar(50) not null default 'Не указано',
[Стоимость котлована] int not null default 0,
[Стоимость фундамента] int not null default 0,
[Стоимость отделки] int not null default 0,
[Объект сдан или нет] varchar(50) not null default 'Не указано',

[Кадастровый номер участка] int not null default 0,
[ID клиента] int not null default 0,
FOREIGN KEY ([ID клиента]) REFERENCES [Данные клиента]([ID клиента]),
FOREIGN KEY ([Кадастровый номер участка]) REFERENCES [Информация о участке]([Кадастровый номер участка])
)

CREATE TABLE [Таблица оценки участка]
(
[Кадастровый номер] int not null identity PRIMARY KEY,
[Метод оценки участка] varchar(50) not null default 'Не указано',
[Окончательная кадастровая стоимость] int not null default 0,
[Заказчик кадастровой оценки] varchar(50) not null default 'Не указано',
[Используемые технологии] varchar(50) not null default 'Не указано',

[Кадастровый номер участка] int not null default 0,
[Номер строительства] int not null default 0,
FOREIGN KEY ([Кадастровый номер участка]) REFERENCES [Информация о участке]([Кадастровый номер участка]),
FOREIGN KEY ([Номер строительства]) REFERENCES [Информация о строительстве]([Номер строительства])
)

CREATE TABLE [Юридическое обеспечение гос.регистрации]
(
[ID регистрации] int not null identity PRIMARY KEY,
[Используемый регистр контроля] varchar(50) not null default 'Не указано',
[Регистрация недвижимости (участка)] varchar(50) not null default 'Не указано',
[Поставлен ли участок на учёт] varchar(50) not null default 'Не указано',

[Кадастровый номер] int not null default 0,
[Кадастровый номер участка] int not null default 0,
FOREIGN KEY ([Кадастровый номер]) REFERENCES [Таблица оценки участка]([Кадастровый номер]),
FOREIGN KEY ([Кадастровый номер участка]) REFERENCES [Информация о строительстве]([Кадастровый номер участка])
)