USE DrPhischel
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'insert_paciente')
DROP PROCEDURE dbo.insert_paciente
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'insert_doctor')
	DROP PROCEDURE dbo.insert_doctor
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'insert_atencion_paciente')
	DROP PROCEDURE dbo.insert_atencion_paciente
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'TR' AND name = 'agregar_a_tabla_Paciente_por_doctor')
	DROP trigger agregar_a_tabla_Paciente_por_doctor
GO


CREATE PROCEDURE dbo.insert_paciente @cedula int , @password char(20) , @nombre char(15) , @apellido char(15) , 
@FechaNacimiento Date ,  @Residencia char(45), @Estado char(1) , @peso Decimal(4,2) , @altura Decimal(4,2) 
AS
	declare @idUsuario int
	INSERT INTO USUARIO (Password,Cedula, Nombre,Apellido, FechaNacimiento, Residencia, Estado) 
	VALUES(@password, @cedula , @nombre ,  @apellido  , @FechaNacimiento , @Residencia ,  @Estado)

	SELECT @idUsuario = @@IDENTITY
	select SCOPE_IDENTITY() as LAST_ID 
	INSERT INTO PACIENTE (Peso,Altura, UserId) Values (@peso,@altura,@idUsuario)
	

Go

CREATE PROCEDURE dbo.insert_doctor @cedula int , @password char(20) , @nombre char(15) ,
@apellido char(15), @FechaNacimiento Date ,  @Residencia char(45), @Estado char(1) , 
@direccionConsultorio char(50) , @Especialidad tinyint, @tarjetaCredito char(16)
AS
	declare @idUsuario int
	INSERT INTO USUARIO (Password,Cedula, Nombre,Apellido, FechaNacimiento, Residencia, Estado) 
	VALUES(@password, @cedula , @nombre ,  @apellido  , @FechaNacimiento , @Residencia ,  @Estado)

	SELECT @idUsuario = @@IDENTITY
	 select SCOPE_IDENTITY() as LAST_ID

	INSERT INTO DOCTOR (DireccionConsultorio,Especialidad, TarjetaCredito, UserId) 
	Values (@direccionConsultorio,@Especialidad,@tarjetaCredito , @idUsuario )
	

Go


CREATE PROCEDURE dbo.insert_atencion_paciente  @Descripcion varchar(100), @Estudios varchar(100) , @NoCita int , @IdPaciente int
AS
	declare @NoAtencion int
	Insert into Atencion (Descripcion, Estudios , NoCita ) 
	Values (@Descripcion,@Estudios, @NoCita ) ; 

	SELECT  @NoAtencion = @@IDENTITY
	 select SCOPE_IDENTITY() as LAST_ID

	Insert into HISTORIAL_POR_PACIENTE (IdPaciente , NoAtencion) Values ( @IdPaciente, @NoAtencion ) ;


Go


GO
CREATE TRIGGER agregar_a_tabla_Paciente_por_doctor
ON CITA
AFTER UPDATE
AS
	declare @EstadoCita char(1)
	declare @OldEstado char(1)
	declare @doctor int
	declare @IdPaciente int

	select @OldEstado = Estado From deleted ;
	SELECT @EstadoCita = Estado FROM inserted;
	select @doctor = NoDoctor from inserted;
	Select @IdPaciente = IdPaciente from inserted;

	--if (@OldEstado = 'C') ---si esta completada.
	--begin
		--rollback
	--end		
	--else 
	if EXISTS (SELECT * FROM PACIENTE_POR_DOCTOR WHERE IdPaciente = @IdPaciente AND  NoDoctor = @doctor )
	begin
		print 'Ya existe este mes'
		rollback
	end 
	else if (@EstadoCita = 'C' )
	begin 
		INSERT INTO PACIENTE_POR_DOCTOR (IdPaciente,NoDoctor ) Values (@IdPaciente , @doctor) 
		print 'se agrego un paciente al doctor'
	end
Go