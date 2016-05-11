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
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_Cobro_Doctores')
	DROP Procedure SP_Cobro_Doctores
GO



CREATE PROCEDURE dbo.insert_paciente @cedula int , @password char(20) , @nombre char(15) , @apellido char(15) , 
@FechaNacimiento Date ,  @Residencia char(45), @Estado char(1) , @peso Decimal(4,2) , @altura Decimal(4,2) 
AS
	declare @idUsuario int
	INSERT INTO USUARIO (Password,Cedula, Nombre,Apellido, FechaNacimiento, Residencia, Estado) 
	VALUES(@password, @cedula , @nombre ,  @apellido  , @FechaNacimiento , @Residencia ,  'A')

	SELECT @idUsuario = @@IDENTITY
	select SCOPE_IDENTITY() as LAST_ID 
	INSERT INTO PACIENTE (Peso,Altura, UserId) Values (@peso,@altura,@idUsuario)
	

Go

CREATE PROCEDURE dbo.insert_doctor @cedula int , @password char(20) , @nombre char(15) ,
@apellido char(15), @FechaNacimiento Date ,  @Residencia char(45), @Estado char(1) , 
@direccionConsultorio char(50) , @Especialidad tinyint, @tarjetaCredito char(16) , @CiudadConsultorio char(15)
AS
	declare @idUsuario int
	INSERT INTO USUARIO (Password,Cedula, Nombre,Apellido, FechaNacimiento, Residencia, Estado) 
	VALUES(@password, @cedula , @nombre ,  @apellido  , @FechaNacimiento , @Residencia ,  'I')

	SELECT @idUsuario = @@IDENTITY
	 select SCOPE_IDENTITY() as LAST_ID

	INSERT INTO DOCTOR (DireccionConsultorio,Especialidad, TarjetaCredito, UserId, CiudadConsultorio) 
	Values (@direccionConsultorio,@Especialidad,@tarjetaCredito , @idUsuario, @CiudadConsultorio )
	

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
	declare @Fecha Date

	select @OldEstado = Estado From deleted ;
	SELECT @EstadoCita = Estado FROM inserted;
	select @doctor = NoDoctor from inserted;
	Select @IdPaciente = IdPaciente from inserted;

	if EXISTS (SELECT * FROM PACIENTE_POR_DOCTOR 
	WHERE IdPaciente = @IdPaciente AND  NoDoctor = @doctor AND Month(Fecha) = Month(GETDATE()) AND YEAR(Fecha) = YEAR(GETDATE()) )
	begin
		print 'Ya existe este mes'
		rollback
	end 
	else if (@EstadoCita = 'C' AND  @OldEstado <> 'C' )
	begin 
		INSERT INTO PACIENTE_POR_DOCTOR (IdPaciente,NoDoctor , Fecha) Values (@IdPaciente , @doctor , GETDATE()) 
		print 'se agrego un paciente al doctor'
	end
Go

CREATE PROCEDURE dbo.insert_excel
AS
	INSERT INTO USUARIO (Password, Cedula, Nombre, Apellido, FechaNacimiento, Residencia, Estado)
	SELECT S.Password, S.Cedula, S.Nombre, S.Apellido, S.FechaNacimiento, S.Residencia, S.Estado
	FROM Sheet1$ AS S

	INSERT INTO PACIENTE (Peso, Altura, UserId)
	SELECT S.Peso, S.Altura, U.Id
	FROM Sheet1$ AS S, USUARIO AS U
	WHERE S.Cedula = U.Cedula
Go

CREATE PROCEDURE SP_Cobro_Doctores  @PacienteId INT , @FechaRequested Date
	AS
		SELECT NoDoctor , Count(IdPaciente) as NumeroPacientes, count(IdPaciente)*500 as MontoAlCobro
		 from PACIENTE_POR_DOCTOR join USUARIO on NoDoctor = Id 
			where IdPaciente =  @PacienteId   AND Month(Fecha) = Month(@FechaRequested) 
			AND Year(Fecha) = Year(@FechaRequested)
			group by (NoDoctor)




--exec SP_Cobro_Doctores  @DoctorId =2 , @PacienteId =1 , @Mes=5 , @Anio = 2016


		--declare @x decimal(2,0) 
		--select @x = 5
--Select Month(getdate()) as mes where Month(getdate()) = @x


