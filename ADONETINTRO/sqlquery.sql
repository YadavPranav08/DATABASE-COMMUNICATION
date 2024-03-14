create database B22ADONETDB

use B22ADONETDB

create table Trainer
(
ID int primary key identity,
Name varchar(50),
city varchar(20),
Experience int 
)

go

insert into Trainer values ('Vikul', 'Pune', 15 ), 
('Usha', 'Mumbai', 3), ('Pranav', 'Shreepur', 1)

select * from Trainer