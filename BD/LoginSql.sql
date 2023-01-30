create database loginVS

use loginVS

create table Administrativo(
	NombreA varchar(30) primary key not null,
	ContrasenaA varchar(30)not null
);

IF EXISTS (SELECT * FROM Administrativo WHERE NombreA = 'Antonio' and ContrasenaA = '123') select* from Administrativo;

insert into Administrativo1 values ('Amarcos','123')
insert into Administrativo1 values ('Amarlon','456')

insert into Administrativo1 values ('Spaco','123')
insert into Administrativo1 values ('Spepe','456')


insert into Administrativo1 values ('Cantonio','456')



create table Curd(
	Id varchar(30) primary key not null,
	Nombre varchar(30)not null,
	Apellido varchar(30)not null,
	Edad varchar(30)not null,
	Email varchar(30)not null,
	Telefono varchar(30)not null
);
delete curd where Id = '1'
insert into Curd values ('1','marcos','pacheco','17','marcos.com','1234-1234')
insert into Curd values ('2','antonio','ramirez','23','antonio.com','2345-2345')
insert into Curd values ('3','enrique','valle','34','enrique.com','3456-3456')
insert into Curd values ('4','patricio','castillo','19','patricio.com','4567-4567')
insert into Curd values ('5','antony','lopez','16','antony.com','5678-5678')

select* from Curd where Nombre = 'marcos'

update Curd set Nombre = 'marcos', Apellido = 'app' where Id = '1'