create database parcial2BaseDatos
go
use parcial2BaseDatos
go

create table invoice(
invoiceNumber int primary key identity,
invoiceDate nvarchar(50),
customerName nvarchar(50),
invoiceTotalValue int
)

create table invoice_detail(
articleId int primary key identity,
articleName nvarchar(20),
articlePrice float,
invoiceNumber int foreign key (invoiceNumber) references invoice (invoiceNumber)
)

insert into invoice values('2016-10-10', 'Empresa SRL', 200)
insert into invoice_detail values ('Articulo', 350, 1)