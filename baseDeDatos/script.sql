
CREATE DATABASE ProspectosClientes  
ON   
( NAME = ProspectosClientes_dat,  
    FILENAME = 'C:\EjercicioPracticoPlasco\baseDeDatos\ProspectosClientesdat.mdf',  
    SIZE = 10,  
    MAXSIZE = 50,  
    FILEGROWTH = 5 )  
LOG ON  
( NAME = Sales_log,  
    FILENAME = 'C:\EjercicioPracticoPlasco\baseDeDatos\ProspectosClienteslog.ldf',  
    SIZE = 5MB,  
    MAXSIZE = 25MB,  
    FILEGROWTH = 5MB );  
GO  

use ProspectosClientes

create table Estatus(
 idEstatus int identity(1,1) primary key,
 nombre varchar(50)
)

create table Prospecto(
 idProspecto int identity(1,1) primary key,
 nombre varchar(100) not null,
 primerApellido varchar(100) not null,
 segundoApellido varchar(100) null,
 calle varchar(100) not null,
 numero varchar(10) not null,
 colonia varchar(100) not null,
 codigoPostal varchar(10) not null,
 telefono varchar(14) not null,
 RFC varchar(13) not null,
 idEstatus int not null,
 observaciones varchar(500) null

FOREIGN KEY(idEstatus) REFERENCES Estatus(idEstatus)
)

create table Documento(
idDocumento int identity(1,1) primary key,
nombre varchar(150) not null,
informacion varbinary(MAX)
)

create table DocumentoProspecto(
idProspecto int not null,
idDocumento int not null,

FOREIGN KEY(idProspecto) REFERENCES Prospecto(idProspecto),
FOREIGN KEY(idDocumento) REFERENCES Documento(idDocumento)
)

insert into Estatus values('Enviado');
insert into Estatus values('Autorizado');
insert into Estatus values('Rechazado');

alter table prospecto add evaluado char(1) null
alter table Documento alter column informacion varbinary(MAX) null

select * from Prospecto
select * from Documento
select * from DocumentoProspecto
select max(idProspecto) from Prospecto

insert into DocumentoProspecto (idProspecto,idDocumento) values(8,13)

select d.nombre from Documento as d inner join DocumentoProspecto as dc on d.idDocumento = dc.idDocumento inner join 
Prospecto as p on dc.idProspecto = p.idProspecto where p.idProspecto = 14