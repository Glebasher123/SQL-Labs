create database NKA1
use NKA1

CREATE TABLE [������ �������]
(
[ID �������] int not null PRIMARY KEY,
[�������] varchar(50) not null default '�� �������',
[���] varchar(50) not null default '�� �������',
[��������] varchar(50) not null default '�� �������',
[���������� �����] varchar(50) not null default '�� �������',
[����� ����������] varchar(50) not null default '�� �������'
)

CREATE TABLE [���������� � �������]
(
[����������� ����� �������] int not null identity PRIMARY KEY,
[��������� �2, ���] int not null default 0,
[���������� �������]  int not null default 0,
[��������� �������] varchar(50) not null default '�� �������',
[����������� ���������, ���] int not null default 0,

[ID �������] int not null default 0,
FOREIGN KEY ([ID �������]) REFERENCES [������ �������]([ID �������])
)



CREATE TABLE [���������� � �������������]
(
[����� �������������] int not null identity PRIMARY KEY,
[���������� ���������� ����������] varchar(50) not null default '�� �������',
[��������� ����������] int not null default 0,
[������ ���� ��� ���] varchar(50) not null default '�� �������',


[����������� ����� �������] int not null default 0,

FOREIGN KEY ([����������� ����� �������]) REFERENCES  [���������� � �������]([����������� ����� �������])
)

CREATE TABLE [������� ������ �������]
(
[����������� �����] int not null identity PRIMARY KEY,
[����� ������ �������] varchar(50) not null default '�� �������',
[������������� ����������� ���������] int not null default 0,
[�������� ����������� ������] varchar(50) not null default '�� �������',
[������������ ����������] varchar(50) not null default '�� �������',

[����������� ����� �������] int not null default 0,
[����� �������������] int not null default 0,

FOREIGN KEY ([����������� ����� �������]) REFERENCES [���������� � �������]([����������� ����� �������]),
FOREIGN KEY ([����� �������������]) REFERENCES [���������� � �������������]([����� �������������])
)


CREATE TABLE [����������� ����������� ���.�����������]
(
[ID �����������] int not null identity PRIMARY KEY,
[������������ ������� ��������] varchar(50) not null default '�� �������',
[����������� ������������ (�������)] varchar(50) not null default '�� �������',
[��������� �� ������� �� ����] varchar(50) not null default '�� �������',

[����������� �����] int not null default 0,
[����������� ����� �������] int not null default 0,
FOREIGN KEY ([����������� �����]) REFERENCES [������� ������ �������]([����������� �����]),
FOREIGN KEY ([����������� ����� �������]) REFERENCES [���������� � �������]([����������� ����� �������])
)