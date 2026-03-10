create database EventPlus;
Go

use EventPlus;
Go

create table TipoUsuario(
	IdTipoUsuario uniqueIdentifier primary key default ((newId())),
	Titulo varchar(100) not null
);
Go

create table TipoEvento(
	IdTipoEvento uniqueIdentifier primary key default ((newId())),
	Titulo varchar(100) not null
);

create table Usuario(
	IdUsuario uniqueIdentifier primary key default ((newId())),
	Nome  varchar(100) not null,
	Email varchar(256) unique not null,
	Senha varchar(60) not null,

	IdTipoUsuario uniqueIdentifier foreign key references TipoUsuario(IdTipoUsuario)
);
Go

create table Instituicao(
	IdInstituicao uniqueIdentifier primary key default ((newId())),
	NomeFantasia varchar(100) not null,
	CNPJ varchar(14) unique not null,
	Endereco varchar(100) not null,
);
go

create table Evento(
	IdEvento uniqueIdentifier primary key default ((newID())),
	Nome  varchar(100) not null,
	DataEvento datetime not null,
	Descricao text not null,

	IdTipoEvento uniqueidentifier foreign key references TipoEvento (IdTipoEvento),
	IdInstituicao uniqueidentifier foreign key references Instituicao(IdInstituicao),
);
go

create table Presenca (
	IdPresenca uniqueIdentifier primary key default ((newID())),
	Situacao bit not null,
	IdUsuario uniqueIdentifier foreign key references Usuario(IdUsuario),
	IdEvento uniqueidentifier foreign key references Evento (IdEvento),
);
go

create table ComentarioEvento(
	IdComentarioEvento uniqueIdentifier primary key default ((newID())),
	Descricao varchar(200) not null,
	Exibe bit not null,
	DataComentario datetime not null,

	IdUsuario uniqueIdentifier foreign key references Usuario(IdUsuario),
	IdEvento uniqueidentifier foreign key references Evento (IdEvento),
);