--Problema 1.3, Base de datos

create database Banco_114224

drop database Banco_114224

use Banco_114224
go

/*Creación de la base de datos DDL*/
create table TiposCuentas(
tipoCuenta int identity(1,1),
nombre varchar(20)

constraint pk_TiposCuentas primary key(tipoCuenta)
)

create table Cuentas(
cbu int,
saldo money,
tipoCuenta int,
ultimoMov datetime,
tipo bit --0 Habilitado / 1 Inhabilitado

constraint pk_cuentas primary key(cbu),
constraint fk_cuentas_tiposCuentas foreign key(tipoCuenta) references TiposCuentas(tipoCuenta),
)

create table Clientes(
dni int,
nombre varchar(15),
apellido varchar(25),
cbu int

constraint pk_clientes primary key(dni)
constraint fk_clientes_cuentas foreign key(cbu) references Cuentas(cbu)
)

/*Carga de datos DML*/
insert TiposCuentas(nombre)
values('Caja de ahorro')
insert TiposCuentas(nombre)
values('Cuenta Corriente')
insert TiposCuentas(nombre)
values('Cuenta sueldo')

select * from TiposCuentas

insert Cuentas(cbu, saldo, tipoCuenta, ultimoMov, tipo)
values(1, 10000, 3, '2022/08/15', 0)

select * from Cuentas

insert Clientes(dni, nombre, apellido, cbu)
values(1, 'Alex', 'Abrahamian', 1)

select * from Clientes

/*SP (Procedimiento almacenado)*/

create proc pa_Grilla_cli
as
select Clientes.dni as 'DNI', Clientes.nombre+', '+apellido as 'Cliente', Clientes.cbu as 'CBU', TiposCuentas.nombre as 'Tipo de Cuenta'  from Clientes join Cuentas on Clientes.cbu = Cuentas.cbu join
TiposCuentas on Cuentas.tipoCuenta = TiposCuentas.tipoCuenta
where tipo = 0
return

create proc pa_Grilla_cta
as
select cbu as 'CBU', convert(Int, Round(saldo, 0,1)) as 'Saldo', nombre as 'Tipo de Cuenta', convert(varchar(10), ultimoMov, 103) as 'Ultimo Movimiento' from Cuentas join TiposCuentas
on Cuentas.tipoCuenta=TiposCuentas.tipoCuenta
where tipo=0
return

create proc pa_Grilla_cta_cli
as
select dni as 'DNI', Clientes.nombre+', '+apellido as 'Cliente', Clientes.cbu as 'CBU', convert(Int, Round(saldo, 0,1)) as 'Saldo', TiposCuentas.nombre as 'Tipo de Cuenta', convert(varchar(10), ultimoMov, 103) as 'Ultimo Movimiento' from Cuentas join TiposCuentas
on Cuentas.tipoCuenta=TiposCuentas.tipoCuenta join Clientes on Clientes.cbu=Cuentas.cbu
where tipo=0
return

create proc pa_Grilla_cta_cli_Deshabilitadas
as
select dni as 'DNI', Clientes.nombre+', '+apellido as 'Cliente', Clientes.cbu as 'CBU', convert(Int, Round(saldo, 0,1)) as 'Saldo', TiposCuentas.nombre as 'Tipo de Cuenta', convert(varchar(10), ultimoMov, 103) as 'Ultimo Movimiento' from Cuentas join TiposCuentas
on Cuentas.tipoCuenta=TiposCuentas.tipoCuenta join Clientes on Clientes.cbu=Cuentas.cbu
where tipo=1
return

create proc pa_insert_cliente
@dni int,
@nombre varchar(15),
@apellido varchar(25),
@cbu int
as
insert into Clientes(dni, nombre, apellido, cbu)
values(@dni, @nombre, @apellido, @cbu)
return


create proc pa_insert_cuenta
@cbu int,
@saldo money,
@tipoCuenta int,
@ultimoMov datetime,
@tipo bit = 0
as
insert into Cuentas(cbu, saldo, tipoCuenta, ultimoMov, tipo)
values(@cbu, @saldo, @tipoCuenta, @ultimoMov, @tipo)
return


create proc pa_consulta_cli
@index int
as
select Clientes.dni, Clientes.nombre, apellido, Clientes.cbu from Clientes join Cuentas on Clientes.cbu = Cuentas.cbu
where Clientes.cbu = @index
return

create proc pa_consulta_cta
@index int
as
select cbu, saldo, Cuentas.tipoCuenta, ultimoMov from Cuentas join TiposCuentas on Cuentas.tipoCuenta=TiposCuentas.tipoCuenta
where cbu = @index
return

create proc pa_combo 
as
select * from TiposCuentas
return

create proc pa_update_cli
@dni int,
@nombre varchar(15),
@apellido varchar(25),
@cbu int
as
update Clientes
set nombre = @nombre, apellido = @apellido
where dni = @dni
return

create proc pa_update_cta
@cbu int,
@saldo money,
@tipoCuenta int,
@ultimoMov datetime,
@tipo bit
as
update Cuentas
set saldo = @saldo, tipoCuenta = @tipoCuenta, ultimoMov = @ultimoMov
where cbu = @cbu
return

create proc pa_delet_cli
@index int
as
delete Clientes where cbu = @index
return

create proc pa_delet_cta
@index int
as
delete Cuentas where cbu= @index
return

create proc pa_habilitar_deshabilitar
@cbu int,
@tipo bit
as
update Cuentas
set tipo = @tipo
where cbu = @cbu

create proc pa_TipoCuenta
as
select dni, cli.nombre, apellido, cta.cbu, saldo, t.nombre, ultimoMov
from Cuentas cta join TiposCuentas t on cta.tipoCuenta = t.tipoCuenta
join Clientes cli on cta.cbu=cli.cbu
return

