create database SVentas

use SVentas

CREATE TABLE [dbo].[Deptos](
	[Id_Depto] [int] IDENTITY(1,1) NOT NULL,
	[NombreDepto] [nvarchar](25) NOT NULL,
	[EstadoD] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Depto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Deptos] ADD  DEFAULT ((1)) FOR [EstadoD]

CREATE TABLE [dbo].[Municipios](
	[Id_Mun] [int] IDENTITY(1,1) NOT NULL,
	[NombreMun] [nvarchar](25) NOT NULL,
	[Id_Depto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Mun] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Municipios]  WITH CHECK ADD FOREIGN KEY([Id_Depto])
REFERENCES [dbo].[Deptos] ([Id_Depto])

CREATE TABLE [dbo].[Clientes](
	[CodCliente] [char](4) NOT NULL,
	[PNC] [nvarchar](15) NOT NULL,
	[SNC] [nvarchar](15) NULL,
	[PAC] [nvarchar](15) NOT NULL,
	[SAC] [nvarchar](15) NULL,
	[Cedula] [char](16) NULL,
	[DirC] [nvarchar](50) NOT NULL,
	[Id_Depto] [int] NOT NULL,
	[FNac] [char](10) NULL,
	[EstadoC] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Proveedor](
	[RUC] [char](11) NOT NULL,
	[NombreProv] [nvarchar](40) NOT NULL,
	[DirProv] [nvarchar](50) NOT NULL,
	[Id_Depto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RUC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD FOREIGN KEY([Id_Depto])
REFERENCES [dbo].[Deptos] ([Id_Depto])

CREATE TABLE [dbo].[Productos](
	[CodProd] [char](5) NOT NULL,
	[NombreProd] [nvarchar](50) NOT NULL,
	[PrecioP] [money] NOT NULL,
	[ExistP] [int] NOT NULL,
	[RUC] [char](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodProd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([RUC])
REFERENCES [dbo].[Proveedor] ([RUC])

CREATE TABLE [dbo].[Ventas](
	[Id_Venta] [int] IDENTITY(1,1) NOT NULL,
	[FechaV] [date] NOT NULL,
	[CodCliente] [char](4) NOT NULL,
	[TotalV] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Ventas] ADD  DEFAULT (getdate()) FOR [FechaV]


ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD FOREIGN KEY([CodCliente])
REFERENCES [dbo].[Clientes] ([CodCliente])

CREATE TABLE [dbo].[Det_Ventas](
	[Id_Venta] [int] NOT NULL,
	[CodProd] [char](5) NOT NULL,
	[cantv] [int] NOT NULL,
	[stp] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Venta] ASC,
	[CodProd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Det_Ventas]  WITH CHECK ADD FOREIGN KEY([CodProd])
REFERENCES [dbo].[Productos] ([CodProd])


ALTER TABLE [dbo].[Det_Ventas]  WITH CHECK ADD FOREIGN KEY([Id_Venta])
REFERENCES [dbo].[Ventas] ([Id_Venta])


CREATE TABLE [dbo].[Compras](
	[NFactC] [char](5) NOT NULL,
	[FechaC] [date] NOT NULL,
	[RUC] [char](11) NOT NULL,
	[TotalC] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[NFactC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Compras]  WITH CHECK ADD FOREIGN KEY([RUC])
REFERENCES [dbo].[Proveedor] ([RUC])


CREATE TABLE [dbo].[Det_Compras](
	[NFactC] [char](5) NOT NULL,
	[CodProd] [char](5) NOT NULL,
	[cantc] [int] NOT NULL,
	[precioc] [money] NOT NULL,
	[subtc] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[NFactC] ASC,
	[CodProd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Det_Compras]  WITH CHECK ADD FOREIGN KEY([CodProd])
REFERENCES [dbo].[Productos] ([CodProd])


ALTER TABLE [dbo].[Det_Compras]  WITH CHECK ADD FOREIGN KEY([NFactC])
REFERENCES [dbo].[Compras] ([NFactC])


insert into Deptos values ('Managua',1),('Masaya',1), ('Granada',1),('Leon',1), ('Chinandega',1)

select * from Deptos

alter table Municipios add EstadoMun bit default 1

insert into Municipios values('Managua',1,1),('Tipitapa',1,1),('Nindiri',2,1),('Catarina',2,1),
('Diria',3,1)

select * from Municipios

insert into Clientes values('01','Reynaldo','','Castaño','Umaña','001-311271-0012R','Ducuali',1,'1971-12-31',1),
('02','Yasser', 'Ronaldo','Membreño','Gudiel','001-110681-0052J','Residencial Mayales',1,'1981-06-11',1)

select * from Clientes

alter table Proveedor add EstadoProv bit default 1

insert into Proveedor values('J01','Apple','Galeria Santo Domingo',1,1),('J02','La Curacao', 'Metrocentro',1,1),
('J03','Almacenes SIMAN','Galeria Santo Domingo',1,1)

select * from Proveedor

alter table Productos add EstadoProd bit default 1

insert into Productos values('01','Iphone 15 Pro',2500,5,'J01',1),('02','Iphone 15 pro max',2800,4,'J01',1)

select * from Productos





ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ((1)) FOR [EstadoC]


ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD FOREIGN KEY([Id_Depto])
REFERENCES [dbo].[Deptos] ([Id_Depto])


ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD CHECK  (([Cedula] like '[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][A-Z]'))



create table DevCE(
IdDCE int identity(1,1) primary key not null,
FechaDCE datetime default getdate() not null,
CodCliente char(4) foreign key references Clientes(CodCLiente) not null,
TotalDC money
)


create table Det_DevCE(
IdDCE int foreign key references DevCE(IdDCE) not null,
CodProd char(5) foreign key references Productos(CodProd) not null,
cantdc int not null,
subtdc float,
primary key(IdDCE,CodProd)
)

create table DevEP(
IdDEP int identity(1,1) primary key not null,
FechaDEP datetime default getdate() not null,
CodCliente char(4) foreign key references Clientes(CodCLiente) not null,
TotalDP money
)


create table Det_DevEP(
IdDEP int foreign key references DevEP(IdDEP) not null,
CodProd char(5) foreign key references Productos(CodProd) not null,
cantdp int not null,
subtdp float,
primary key(IdDEP,CodProd)
)

--- CRUD, Proveedor, Clientes y productos

------ Proveedor
--Insercion 
create procedure InsertProv
@IDP char(11),
@NP nvarchar(40),
@DP nvarchar(50),
@Id_Dep int
as
declare @idprov as char(11)
set @idprov=(select RUC from Proveedor 
where RUC=@IDP)
if(@IDP='' or @NP='' or @DP='' or @Id_Dep= '' )
begin
	print 'No pueden ser nulos'
end
else
begin
	if(@IDP=@idprov)
	begin
		print 'Proveedor ya registrado'
	end
	else
		begin
			insert into Proveedor values(@IDP,@NP,@DP,
			@Id_Dep,1)
	end
end
-- Procedimiento de Modificación
create procedure ModProv
@IDP char(11),
@NP nvarchar(40),
@DP nvarchar(50),
@Id_Dep int
as declare @ip as char(11)
set @ip=(select RUC from Proveedor where RUC=@IDP)
if(@IDP='' or @NP='' or @DP='')
begin
	print 'No pueden ser nulos'
end
else
		begin
			update Proveedor set NombreProv=@NP,
			DirProv=@DP, Id_Depto=@Id_Dep
			where RUC=@IDP and EstadoProv=1
	end

-- Procedimiento de Dar baja
create procedure DarBProv
@IDP char(11)
as
declare @idprov as char(11)
set @idprov=(select RUC from Proveedor 
where RUC=@IDP)
if(@IDP=@idprov)
begin
	update Proveedor set EstadoProv=0 where RUC=@IDP
end
else
begin
	print 'Proveedor no encontrado'
end

DarBProv 'J03'

select * from Proveedor where EstadoProv=0

--Buscar
create procedure BuscaProv
@IDP char(11)
as 
declare @idpr as char(11)
set @idpr=(select RUC from Proveedor where RUC=@IDP)
if(@IDP='')
begin
	print 'No puede ser nulo'
end
	else
	begin
		if(@IDP=@idpr)
		begin
			select * from Proveedor where RUC=@IDP
		end
		else
		begin
			print 'Proveedor no encontrado'
		end
	end
BuscaProv 'J01'
---- CLIENTES

--Insercion 
create procedure InsertClient
@CodCli char(4)
,@PNC nvarchar(15)
,@SNC nvarchar(15)
,@PAC nvarchar(15)
,@SAC nvarchar(15)
,@Cedula CHAR(6)
,@dirC nvarchar(50)
,@Id_DPT INT
,@FNAC CHAR(10)

as
declare @idC as char(4)
set @idc=(select CodCliente from Clientes
where CodCliente=@CodCli)
if(@CodCli='' or @PNC='' or @PAC='' or @SAC= '' OR @Cedula= '' OR @dirC='' )
begin
	print 'No pueden ser nulos'
end
else
begin
	if(@CodCli=@idC)
	begin
		print 'Cliente ya registrado'
	end
	else
		begin
			insert into Clientes values(@CodCli,@PNC,@SNC,@PAC,@SAC, @Cedula, @dirC,
			@Id_DPT, @FNAC,1)
	end
end
-- Procedimiento de Modificación
create procedure ModClient
@CodCli char(4)
,@PNC nvarchar(15)
,@SNC nvarchar(15)
,@PAC nvarchar(15)
,@SAC nvarchar(15)
,@Cedula CHAR(6)
,@dirC nvarchar(50)
,@Id_DPT INT
,@FNAC CHAR(10)
as declare @ic as char(4)
set @ic=(select CodCliente from Clientes where CodCliente=@CodCli)
if(@CodCli='' or @PNC='' or @PAC='' or @SAC= '' OR @Cedula= '' OR @dirC='')
begin
	print 'No pueden ser nulos'
end
else
		begin
			update Clientes set PNC=@PNC, SNC=@SNC, PAC= @PAC
			, SAC=@SAC, Cedula=@Cedula, DirC=@dirC, Id_Depto=@Id_DPT, 
			FNac=@FNAC
			where CodCliente=@CodCli and EstadoC=1
	end

-- Procedimiento de Dar baja
create procedure DarBClient
@Cod_Clien char(4)
as
declare @idclient as char(4)
set @idclient=(select CodCliente from Clientes
where CodCliente=@Cod_Clien)
if(@Cod_Clien=@idclient)
begin
	update Clientes set EstadoC=0 where CodCliente=@Cod_Clien
end
else
begin
	print 'Cliente no encontrado'
end

DarBProv '0003'

select * from Clientes where EstadoC=0

---Buscar
Create procedure BuscaCliente
@IDC char(4)
as
declare @idcl as char(5)
set @idcl=(select CodCliente from Clientes where CodCliente=@IDC)
if(@IDC='')
begin
	print 'No pueden ser nulos'
end
else
begin
	if(@IDC=@idcl)
	begin
	select * from Clientes where CodCliente=@IDC
	end
	else
	begin
		print 'Cliente no encontrado'
	end
end

---PRODUCTOS
--Insercion 
create procedure InsertProduct
@CodP char(5)
,@NP nvarchar(50)
,@PrecioP money
,@ExistP int
,@RUC char(11)
as
declare @idp as char(4)
set @idp=(select CodProd from Productos
where CodProd=@CodP)
if(@CodP='' or @NP='' OR @PrecioP='' or @ExistP='' or @RUC='')
begin
	print 'No pueden ser nulos'
end
else
begin
	if(@CodP=@idp)
	begin
		print 'Producto ya registrado'
	end
	else
		begin
			insert into Productos values(@CodP, @NP,@PrecioP, @ExistP, @RUC,1)
	end
end
-- Procedimiento de Modificación
create procedure ModProduct
@CodP char(5)
,@NP nvarchar(50)
,@PrecioP money
,@ExistP int
,@RUC char(11)
as declare @ip as char(5)
set @ip=(select CodProd from Productos where CodProd=@CodP)
if(@CodP='' or @NP='' OR @PrecioP='' or @ExistP='' or @RUC='')
begin
	print 'No pueden ser nulos'
end
else
		begin
			update Productos set NombreProd=@NP,
			PrecioP=@PrecioP, ExistP=@ExistP, RUC=@RUC
			where CodProd=@CodP and EstadoProd=1
	end

-- Procedimiento de Dar baja
create procedure DarBProducto
@CodP char(5)
as
declare @idprod as char(4)
set @idprod=(select CodProd from Productos
where CodProd= @idprod)
if(@CodP= @idprod)
begin
	update Clientes set EstadoC=0 where CodCliente=@CodP
end
else
begin
	print 'Producto no encontrado'
end

---Buscar
Create procedure BuscaProduc
@IDP char(5)
as
declare @idPro as char(5)
set @idPro=(select CodProd from Productos where CodProd=@IDP )
if(@IDP ='')
begin
	print 'No pueden ser nulos'
end
else
begin
	if(@IDP=@idPro)
	begin
	select * from Productos where CodProd=@IDP
	end
	else
	begin
		print 'Producto no encontrado'
	end
end


sp_addlogin 'LMTG', 'IL22', 'SVentas'
sp_addsrvrolemember 'LMTG', 'sysadmin'
sp_adduser 'LMTG', 'LUMME'
sp_addrolemember 'db_ddladmin', 'LUMME'