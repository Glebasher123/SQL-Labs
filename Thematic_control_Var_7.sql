create database Movies
use Movies

create table Persona
(
IDPersona int not null identity PRIMARY KEY,
FIO varchar(50) not null default '�� �������',
DateBirth date not null default '2001-01-01',
DateDeath date not null default '���'
)

insert into Persona (FIO,DateBirth,DateDeath) values ('�������� �� ������', '2001-04-05', '2020-02-10'), ('��� �����', '2005-02-03', '2012-07-10'), ('������ ������', '2002-02-03', '2015-07-10')


create table FilmMaker
(
IDFilmMaker int not null identity PRIMARY KEY,
Film varchar(50) not null default '�� �������',
Person varchar(50) not null default '�� �������',
NatureOfParticipation varchar(50),
Role varchar(50) not null default '�� �������',

IDPersona int not null default 0,
FOREIGN KEY (IDPersona) REFERENCES Persona(IDPersona),

constraint NOP_Check check(NatureOfParticipation='��������' and NatureOfParticipation='�����' and  NatureOfParticipation='����������' and  NatureOfParticipation='��������' and NatureOfParticipation='���������' and NatureOfParticipation='��������')
)

insert into FilmMaker (Film,Person, NatureOfParticipation, Role, IDPersona) values ('�������', 'VIP', '�����', '��������', 1), ('�������', 'VIP', '��������', '�����������', 2), ('�������', 'VIP', '���������', '��������', 3)


drop table FilmMaker

create table Rewards
(
IDReward int not null identity PRIMARY KEY,
NameReward varchar(50) not null default '�� �������',
Nomination varchar(50),
YearOfAward date not null default '2001-01-01',

IDPersona int not null default 0,
FOREIGN KEY (IDPersona) REFERENCES Persona(IDPersona),

constraint Nomitanion_Check check(Nomination='������ �����' and Nomination='������ ��������' and  Nomination='������ ����' and Nomination='����� ����')
)

Create table Movies_table
(
IDMovie int not null identity PRIMARY KEY,
NameMovie varchar(50) not null default '�� �������',
FilmStudio varchar (50) not null default '�� �������',
RealaseYear int not null default 0,
Counrty varchar(50) default '�� �������',
LengthMovie time,
Genre varchar(20) not null default '�� �������',


IDFilmMaker int not null default 0,
IDReward int not null default 0,
IDPersona int not null default 0,
FOREIGN KEY (IDFilmMaker) REFERENCES FilmMaker(IDFilmMaker),
FOREIGN KEY (IDReward) REFERENCES Rewards(IDReward),
FOREIGN KEY (IDPersona) REFERENCES Persona(IDPersona)
)

------Task2-----

select Film, Person, NatureOfParticipation, Role, NameMovie, FilmStudio, RealaseYear, Counrty, LengthMovie, Genre
from  FilmMaker
	join Movies_table on FilmMaker.IDFilmMaker = Movies_table.IDFilmMaker

	where NatureOfParticipation = '��������' and NatureOfParticipation ='�����'


select Film, Person, NatureOfParticipation, Role, NameMovie, FilmStudio, RealaseYear, Counrty, LengthMovie, Genre, NameReward, Nomination, YearOfAward
from  FilmMaker
	join Movies_table on FilmMaker.IDFilmMaker = Movies_table.IDFilmMaker
	join Rewards on Movies_table.IDReward = Rewards.IDReward

	where NatureOfParticipation = '��������' and Nomination ='������ �����'


select Film,  Genre, charindex('��������',NatureOfParticipation) as '��������', charindex('���������',NatureOfParticipation) as '���������', charindex('�����',NatureOfParticipation) as '�����', charindex('����������',NatureOfParticipation) as '����������'
from  FilmMaker
	join Movies_table on FilmMaker.IDFilmMaker = Movies_table.IDFilmMaker
	join Persona on FilmMaker.IDPersona = Persona.IDPersona
	join Rewards on Persona.IDPersona = Rewards.IDPersona