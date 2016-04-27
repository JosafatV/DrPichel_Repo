USE master
IF EXISTS(select * from sys.databases where name = 'DrPhischel')
DROP DATABASE DrPhischel

GO

CREATE DATABASE DrPhischel;
GO

USE DrPhischel;

CREATE TABLE ROL (
	IdRol TINYINT IDENTITY (1,1),
	Descripcion CHAR(15),

  CONSTRAINT PK_ROL
		PRIMARY KEY (IdRol),

	CONSTRAINT UK_ROL_Descripcion
		UNIQUE (Descripcion)
) 

CREATE TABLE USUARIO (
	Id INT IDENTITY(1,1),
	Password Char (20) DEFAULT '12345678',
	Cedula CHAR(11),
	Nombre CHAR (15),
	Apellido CHAR(15),
	FechaNacimiento DATE,
	Residencia CHAR(45),
	Estado CHAR,

	CONSTRAINT PK_CLIENTE
		PRIMARY KEY (Id),
	CONSTRAINT UK_CEDULA_CLIENTE
		UNIQUE(Cedula)
)

/* type of users */
CREATE TABLE PACIENTE (
	IdPaciente INT IDENTITY(1,1),
	Peso DECIMAL(4,2), /* kg */
	Altura DECIMAL(4,2), /* m */
	UserId INT not null,

	CONSTRAINT PK_PACIENTE
		PRIMARY KEY (IdPaciente),

	CONSTRAINT FK_PACIENTE_UserId
		FOREIGN KEY (UserId) REFERENCES USUARIO(Id)
	)


CREATE TABLE DOCTOR(
	NoDoctor INT IDENTITY(1,1),
	DireccionConsultorio CHAR(50),
	Especialidad CHAR,
	TarjetaCredito CHAR(16),
	UserId INT not null,

	CONSTRAINT PK_DOCTOR
		PRIMARY KEY (NoDoctor),
	
	CONSTRAINT FK_DOCTOR_UserId
		FOREIGN KEY (UserId) REFERENCES USUARIO(Id)
	)


CREATE TABLE ADMINISTRADOR (
	IdAdmin INT IDENTITY(1,1),
	Hired DATE,
	UserId INT,

	CONSTRAINT PK_ADMINSTRADOR
		PRIMARY KEY (IdAdmin),

	CONSTRAINT FK_ADMINISTRADOR_UserId
		FOREIGN KEY (UserId) REFERENCES USUARIO(Id)
)

/* work related entities */
CREATE TABLE HISTORIALMEDICO (
	NoHistorial INT IDENTITY(1,1),
	Descripcion VARCHAR(100),
	Estudios VARCHAR(100),

	CONSTRAINT PK_HISTORIAL
		PRIMARY KEY (NoHistorial),
	)


CREATE TABLE RECETA(
	NoReceta INT IDENTITY(1,1),
	Imagen VARCHAR(20),
	Estado CHAR,

	CONSTRAINT PK_RECETA
		PRIMARY KEY (NoReceta)
	)


CREATE TABLE CITA (
	NoCita INT IDENTITY(1,1),
	Fecha DATETIME,
	Estado CHAR,

	CONSTRAINT PK_CITA
		PRIMARY KEY (NoCita)
	)


CREATE TABLE ESPECIALIDADMEDICA (
	NoEspecialidad TINYINT IDENTITY(1,1),
	Nombre CHAR(20),

	CONSTRAINT PK_ESPECIALIDADMEDICA
		PRIMARY KEY (NoEspecialidad)
	)

/* relationships */
CREATE TABLE ROL_POR_USUARIO (
	IdRol TINYINT,
	IdUsuario INT,

	CONSTRAINT PK_ROL_POR_USUARIO
		PRIMARY KEY (IdRol, IdUsuario),

	CONSTRAINT FK_PACIENTE_POR_DOCTOR_IdRol
		FOREIGN KEY(IdRol) REFERENCES ROL(IdRol),

	CONSTRAINT FK_PACIENTE_POR_DOCTOR_IdUsuario
		FOREIGN KEY(IdUsuario) REFERENCES USUARIO(Id)
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

	CONSTRAINT FK_HISTORIAL_POR_PACIENTE_IdPaciente
		FOREIGN KEY (IdPaciente) REFERENCES PACIENTE(IdPaciente),

	CONSTRAINT PK_HISTORIAL_POR_PACIENTE_NoHistorial
		FOREIGN KEY (NoHistorial) REFERENCES HISTORIALMEDICO(NoHistorial)
			)


CREATE TABLE RECETA_POR_HISTORIAL (
	NoHistorial INT,
	NoReceta INT,

	CONSTRAINT PK_RECETA_POR_HISTORIAL
		PRIMARY KEY (NoHistorial, NoReceta),

	CONSTRAINT FK_RECETA_POR_HISTORIAL_NoHistorial
		FOREIGN KEY (NoHistorial) REFERENCES HISTORIALMEDICO(NoHistorial),

	CONSTRAINT FK_RECETA_POR_HISTORIAL_NoReceta
		FOREIGN KEY (NoReceta) REFERENCES RECETA(NoReceta)
	)


CREATE TABLE RECETA_POR_DOCTOR (
	NoDoctor INT,
	NoReceta INT,

	CONSTRAINT PK_RECETA_PACIENTE_DOCTOR
		PRIMARY KEY (NoDoctor, NoReceta),

	CONSTRAINT FK_RECETA_PACIENTE_DOCTOR_NoDoctor
		FOREIGN KEY (NoDoctor) REFERENCES DOCTOR(NoDoctor),

	CONSTRAINT FK_RECETA_PACIENTE_DOCTOR_NoReceta
		FOREIGN KEY (NoReceta) REFERENCES RECETA(NoReceta)
		)

CREATE TABLE CITA_POR_PACIENTE (
	IdPaciente INT,
	NoCita INT,

	CONSTRAINT PK_PACIENTE_ATIENDE_CITA 
		PRIMARY KEY (NoCita, IdPaciente),

	CONSTRAINT FK_PACIENTE_ATIENDE_CITA_IdPaciente
		FOREIGN KEY (IdPaciente) REFERENCES PACIENTE(IdPaciente),

	CONSTRAINT FK_PACIENTE_ATIENDE_CITA_NoCita
		FOREIGN KEY (NoCita) REFERENCES CITA(NoCita)
	)


CREATE TABLE CITA_POR_DOCTOR(
	NoDoctor INT,
	NoCita INT,

	CONSTRAINT PK_DOCTOR_DA_CITA 
		PRIMARY KEY (NoCita, NoDoctor),

	CONSTRAINT FK_DOCTOR_DA_CITA_NoCita
		FOREIGN KEY (NoCita) REFERENCES CITA(NoCita),

	CONSTRAINT FK_DOCTOR_DA_CITA_NoDoctor
		FOREIGN KEY (NoDoctor) REFERENCES DOCTOR(NoDoctor)
		)

CREATE TABLE ESPECIALIDAD_POR_DOCTOR (
	NoDoctor INT,
	NoEspecialidad TINYINT,

	CONSTRAINT PK_ESPECIALIDAD_POR_DOCTOR 
		PRIMARY KEY (NoDoctor, NoEspecialidad),

	CONSTRAINT FK_ESPECIALIDAD_POR_DOCTOR_NoEspecialidad
		FOREIGN KEY (NoEspecialidad) REFERENCES ESPECIALIDADMEDICA(NoEspecialidad),

	CONSTRAINT FK_ESPECIALIDAD_POR_DOCTOR_NoDoctor
		FOREIGN KEY (NoDoctor) REFERENCES DOCTOR(NoDoctor)
		)