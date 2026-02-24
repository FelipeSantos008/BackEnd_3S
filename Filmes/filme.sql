create database Filmes;
go
use Filmes;
go

create table Genero(
	IdGenero varchar(40) primary key,
	Nome varchar(100) not null
);

create table Filme(
	IdFilme	varchar(40)	 primary key,
	Imagem	varchar(100),
	Titulo	varchar(100)  not null,
	IdGenero varchar(40)  foreign		key references Genero(IdGenero)
);

create table Usuario(
	IdUsuario varchar(40) primary key,
	Nome varchar(100) not null,
	Senha varchar(60) not null
);