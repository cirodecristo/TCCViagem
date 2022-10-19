use master
go

if exists(select*from sys.databases where name = 'WebSiteViagem')
	drop database WebSiteViagem
go

create database WebSiteViagem
go

use WebSiteViagem
go

create table Usuario(
	ID int identity primary key,
	Name varchar(100) not null,
	Email varchar(100) not null, 
	Cidade varchar(30) not null,
	Pais varchar(30) not null,
	Telefone varchar(30) not null,
	UserID varchar(60) not null, 
	Userpass varchar(MAX) not null
);
go
