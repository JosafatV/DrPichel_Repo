USE master
IF EXISTS(select * from sys.databases where name='DrPhischel')
DROP DATABASE DrPhischel

GO
CREATE DATABASE DrPhischel;
GO

USE DrPhischel;
GO

CREATE TABLE PACIENTE (
	IdPaciente INT IDENTITY(1,1),				 
	Cedula CHAR(11),
	Nombre CHAR (15),
	Apellido CHAR(15),
	FechaNacimiento DATE,
	Residencia CHAR(45),
	Peso DECIMAL(3,2), /* kg */
	Altura DECIMAL(3), /* cm */
	Estado CHAR,

	CONSTRAINT PK_CLIENTE
		PRIMARY KEY (IdPaciente),

	CONSTRAINT UK_CEDULA_CLIENTE 
		UNIQUE(Cedula)
	)
	

CREATE TABLE DOCTOR(
	NoDoctor INT IDENTITY(1,1),
	Cedula CHAR(15),
	Nombre CHAR(15),
	Apellido CHAR(15),
	FechaNacimiento DATE,
	Residencia CHAR(50),
	DireccionConsultorio CHAR(50),
	Especialidad CHAR,
	TarjetaCredito DECIMAL(16),
	Estado CHAR,

	CONSTRAINT PK_DOCTOR 
		PRIMARY KEY (NoDoctor),

	CONSTRAINT UK_DOCTOR_Cedula 
		UNIQUE (Cedula)
	)


CREATE TABLE HISTORIAL (
	NoHistorial INT IDENTITY(1,1),
	Descripcion VARCHAR(30),
	Estudios VARCHAR(30),

	CONSTRAINT PK_HISTORIAL
		PRIMARY KEY (NoHistorial),
	)

	
CREATE TABLE RECETA(
	NoReceta INT IDENTITY(1,1),
	Imagen IMAGE,
	Estado CHAR,

	CONSTRAINT PK_RECETA
		PRIMARY KEY (NoReceta)
	)


CREATE TABLE CITA (
	NoCita INT IDENTITY(1,1),
	IdPaciente INT,
	NoDoctor INT,
	Fecha DATETIME,
	Estado CHAR,

	CONSTRAINT PK_CITA
		PRIMARY KEY (NoCita),

	CONSTRAINT FK_CITA_IdPaciente
		FOREIGN KEY (IdPaciente) REFERENCES PACIENTE(IdPaciente),

	CONSTRAINT FK_CITA_NoDoctor
		FOREIGN KEY (NoDoctor) REFERENCES DOCTOR(NoDoctor)
	)
	
CREATE TABLE PACIENTE_POR_DOCTOR (
	IdPaciente INT,
	NoDoctor INT,

	CONSTRAINT PK_PACIENTE_POR_DOCTOR
		PRIMARY KEY (IdPaciente, NoDoctor),

	CONSTRAINT FK_PACIENTE_POR_DOCTOR_IdPaciente
		FOREIGN KEY(IdPaciente) REFERENCES Paciente(IdPaciente),

	CONSTRAINT FK_PACIENTE_POR_DOCTOR_NoDoctor
		FOREIGN KEY(NoDoctor) REFERENCES Doctor(NoDoctor)
		)

	CREATE TABLE HISTORIAL_POR_PACIENTE (
		IdPaciente INT,
		NoHistorial INT,

		CONSTRAINT PK_HISTORIAL_POR_PACIENTE
			PRIMARY KEY (IdPaciente, NoHistorial),

		CONSTRAINT PK_HISTORIAL_POR_PACIENTE_IdPaciente
			FOREIGN KEY (IdPaciente) REFERENCES PACIENTE(IdPaciente),

		CONSTRAINT PK_HISTORIAL_POR_PACIENTE_NoHistorial
			FOREIGN KEY (NoHistorial) REFERENCES HISTORIAL(NoHistorial)
			)
		


CREATE TABLE RECETA_POR_HISTORIAL (
	NoHistorial INT,
	NoReceta INT,

	CONSTRAINT PK_RECETA_POR_HISTORIAL
		PRIMARY KEY (NoHistorial, NoReceta),

	CONSTRAINT FK_RECETA_POR_HISTORIAL_NoHistorial
		FOREIGN KEY (NoHistorial) REFERENCES HISTORIAL(NoHistorial),

	CONSTRAINT FK_RECETA_POR_HISTORIAL_NoReceta
		FOREIGN KEY (NoReceta) REFERENCES RECETA(NoReceta)
	)

	CREATE TABLE RECETA_PACIENTE_DOCTOR (
	IdPaciente INT,
	NoDoctor INT,
	NoReceta INT,

	CONSTRAINT PK_RECETA_PACIENTE_DOCTOR 
		PRIMARY KEY (IdPaciente, NoDoctor, NoReceta),

	CONSTRAINT FK_RECETA_PACIENTE_DOCTOR_IdPaciente
		FOREIGN KEY (IdPaciente) REFERENCES PACIENTE(IdPaciente),

	CONSTRAINT FK_RECETA_PACIENTE_DOCTOR_NoDoctor
		FOREIGN KEY (NoDoctor) REFERENCES DOCTOR(NoDoctor),

	CONSTRAINT FK_RECETA_PACIENTE_DOCTOR_NoReceta
		FOREIGN KEY (NoReceta) REFERENCES RECETA(NoReceta)
		)
CREATE TABLE ROL(
	Codigo Char (1),
	Descripcion varchar(60),
	primary key (codigo)
)

CREATE TABLE ADMINISTRADOR(
	Codigo INT,
	Nombre Varchar(50),
	Apellidos varchar (80),
	primary key (codigo) 
)

CREATE TABLE ROL_POR_USUARIO(
	idUsuario int,
	CodigoRol char(1),
	primary key (idUsuario, CodigoRol),
	foreign key (CodigoRol) References Rol(Codigo)
)