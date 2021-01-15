create database Movies
use Movies

create table Persona
(
IDPersona int not null identity PRIMARY KEY,
FIO varchar(50) not null default 'Не указано',
DateBirth date not null default '2001-01-01',
DateDeath date not null default 'Жив'
)

insert into Persona (FIO,DateBirth,DateDeath) values ('Леонардо Ди Каприо', '2001-04-05', '2020-02-10'), ('Том Харди', '2005-02-03', '2012-07-10'), ('Андрей Петров', '2002-02-03', '2015-07-10')


create table FilmMaker
(
IDFilmMaker int not null identity PRIMARY KEY,
Film varchar(50) not null default 'Не указано',
Person varchar(50) not null default 'Не указано',
NatureOfParticipation varchar(50),
Role varchar(50) not null default 'Не указано',

IDPersona int not null default 0,
FOREIGN KEY (IDPersona) REFERENCES Persona(IDPersona),

constraint NOP_Check check(NatureOfParticipation='Режиссер' and NatureOfParticipation='Актер' and  NatureOfParticipation='Композитор' and  NatureOfParticipation='Музыкант' and NatureOfParticipation='Сценарист' and NatureOfParticipation='Оператор')
)

insert into FilmMaker (Film,Person, NatureOfParticipation, Role, IDPersona) values ('Титаник', 'VIP', 'Актер', 'Водитель', 1), ('Титаник', 'VIP', 'Режиссер', 'Киносьемщик', 2), ('Титаник', 'VIP', 'Сценарист', 'Писатель', 3)


drop table FilmMaker

create table Rewards
(
IDReward int not null identity PRIMARY KEY,
NameReward varchar(50) not null default 'Не указано',
Nomination varchar(50),
YearOfAward date not null default '2001-01-01',

IDPersona int not null default 0,
FOREIGN KEY (IDPersona) REFERENCES Persona(IDPersona),

constraint Nomitanion_Check check(Nomination='Лучший фильм' and Nomination='Лучший режиссер' and  Nomination='Лучший актёр' and Nomination='Фильм года')
)

Create table Movies_table
(
IDMovie int not null identity PRIMARY KEY,
NameMovie varchar(50) not null default 'Не указано',
FilmStudio varchar (50) not null default 'Не указано',
RealaseYear int not null default 0,
Counrty varchar(50) default 'Не указано',
LengthMovie time,
Genre varchar(20) not null default 'Не указано',


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

	where NatureOfParticipation = 'Режиссер' and NatureOfParticipation ='Актер'


select Film, Person, NatureOfParticipation, Role, NameMovie, FilmStudio, RealaseYear, Counrty, LengthMovie, Genre, NameReward, Nomination, YearOfAward
from  FilmMaker
	join Movies_table on FilmMaker.IDFilmMaker = Movies_table.IDFilmMaker
	join Rewards on Movies_table.IDReward = Rewards.IDReward

	where NatureOfParticipation = 'Режиссер' and Nomination ='Лучший актер'


select Film,  Genre, charindex('Режиссер',NatureOfParticipation) as 'Режиссер', charindex('Сценарист',NatureOfParticipation) as 'Сценарист', charindex('Актер',NatureOfParticipation) as 'Актер', charindex('Композитор',NatureOfParticipation) as 'Композитор'
from  FilmMaker
	join Movies_table on FilmMaker.IDFilmMaker = Movies_table.IDFilmMaker
	join Persona on FilmMaker.IDPersona = Persona.IDPersona
	join Rewards on Persona.IDPersona = Rewards.IDPersona