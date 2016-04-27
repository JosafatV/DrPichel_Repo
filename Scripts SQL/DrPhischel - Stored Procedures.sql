USE DrPhischel
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'insert_paciente')
DROP PROCEDURE dbo.insert_paciente
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'insert_doctor')
	DROP PROCEDURE dbo.insert_doctor
GO

CREATE PROCEDURE dbo.insert_paciente @cedula int , @password char(20) , @nombre char(15) , @apellido char(15) , 
@FechaNacimiento Date ,  @Residencia char(45), @Estado char(1) , @peso Decimal(4,2) , @altura Decimal(4,2) 
AS
	declare @idUsuario int
	INSERT INTO USUARIO (Password,Cedula, Nombre,Apellido, FechaNacimiento, Residencia, Estado) 
	VALUES(@password, @cedula , @nombre ,  @apellido  , @FechaNacimiento , @Residencia ,  @Estado)

	SELECT @idUsuario = @@IDENTITY
	 
	INSERT INTO PACIENTE (Peso,Altura, UserId) Values (@peso,@altura,@idUsuario)
	select SCOPE_IDENTITY() as LAST_ID

Go

CREATE PROCEDURE dbo.insert_doctor @cedula int , @password char(20) , @nombre char(15) ,
@apellido char(15), @FechaNacimiento Date ,  @Residencia char(45), @Estado char(1) , 
@direccionConsultorio char(50) , @Especialidad char(1), @tarjetaCredito char(16)
AS
	declare @idUsuario int
	INSERT INTO USUARIO (Password,Cedula, Nombre,Apellido, FechaNacimiento, Residencia, Estado) 
	VALUES(@password, @cedula , @nombre ,  @apellido  , @FechaNacimiento , @Residencia ,  @Estado)

	SELECT @idUsuario = @@IDENTITY
	 
	INSERT INTO DOCTOR (DireccionConsultorio,Especialidad, TarjetaCredito, UserId) 
	Values (@direccionConsultorio,@Especialidad,@tarjetaCredito , @idUsuario )
	select SCOPE_IDENTITY() as LAST_ID

Go