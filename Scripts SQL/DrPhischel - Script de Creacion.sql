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
	Peso DECIMAL(4,2), /* kg */
	Altura DECIMAL(4,2), /* m */
	UserId INT not null,

	CONSTRAINT PK_PACIENTE
		PRIMARY KEY (UserId),

	CONSTRAINT FK_PACIENTE_UserId
		FOREIGN KEY (UserId) REFERENCES USUARIO(Id)
	)

CREATE TABLE ESPECIALIDADMEDICA (
	NoEspecialidad TINYINT IDENTITY(1,1),
	Nombre CHAR(20),

	CONSTRAINT PK_ESPECIALIDADMEDICA
		PRIMARY KEY (NoEspecialidad)
	)
CREATE TABLE DOCTOR(
	
	UserId INT not null,
	DireccionConsultorio CHAR(50),
	Especialidad tinyint,
	TarjetaCredito CHAR(16),
	
	CONSTRAINT PK_DOCTOR
		PRIMARY KEY (UserId),
	CONSTRAINT FK_DOCTOR_UserId
		FOREIGN KEY (UserId) REFERENCES USUARIO(Id),
	Constraint fk_especialidad 
		Foreign key (Especialidad) References EspecialidadMedica (NoEspecialidad)
	)


CREATE TABLE ADMINISTRADOR (
	UserId INT,
	Hired DATE,


	CONSTRAINT PK_ADMINSTRADOR
		PRIMARY KEY (UserId),

	CONSTRAINT FK_ADMINISTRADOR_UserId
		FOREIGN KEY (UserId) REFERENCES USUARIO(Id)
)
CREATE TABLE CITA (
	NoCita INT IDENTITY(1,1),
	NoDoctor INT,
	Fecha DATETIME,
	Estado CHAR,
	IdPaciente INT,
	CONSTRAINT FK_PACIENTE_ATIENDE_CITA_IdPaciente
		FOREIGN KEY (IdPaciente) REFERENCES PACIENTE(UserId),
	CONSTRAINT PK_CITA
		PRIMARY KEY (NoCita),
	CONSTRAINT FK_DOCTOR_DA_CITA_NoDoctor
		FOREIGN KEY (NoDoctor) REFERENCES DOCTOR(UserId)
)
/* work related entities */
CREATE TABLE ATENCION (
	NoAtencion INT IDENTITY(1,1),
	Descripcion VARCHAR(100),
	Estudios VARCHAR(100),
	NoCita INT,

	CONSTRAINT PK_HISTORIAL
		PRIMARY KEY (NoAtencion),
	Foreign key (NoCita) References Cita(NoCita)
)

CREATE TABLE HISTORIAL_POR_PACIENTE (
	IdPaciente INT,
	NoAtencion INT,

	CONSTRAINT PK_HISTORIAL_POR_PACIENTE
		PRIMARY KEY (IdPaciente, NoAtencion),

	CONSTRAINT FK_HISTORIAL_POR_PACIENTE_IdPaciente
		FOREIGN KEY (IdPaciente) REFERENCES PACIENTE(Userid),

	CONSTRAINT FK_Atencion_POR_PACIENTE_NoAtencion
		FOREIGN KEY (NoAtencion) REFERENCES ATENCION(NoAtencion)
		)



CREATE TABLE RECETA(
	NoReceta INT IDENTITY(1,1),
	Imagen VARCHAR(20),
	Estado CHAR,
	NoAtencion INT,
	NoDoctor INT,

	CONSTRAINT FK_RECETA_PACIENTE_DOCTOR_NoDoctor
		FOREIGN KEY (NoDoctor) REFERENCES DOCTOR(UserId),
	CONSTRAINT FK_RECETA_POR_NoAtencion
		FOREIGN KEY (NoAtencion) REFERENCES Atencion(NoAtencion),
	CONSTRAINT PK_RECETA
		PRIMARY KEY (NoReceta)
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
		FOREIGN KEY(IdPaciente) REFERENCES Paciente(UserId),

	CONSTRAINT FK_PACIENTE_POR_DOCTOR_NoDoctor
		FOREIGN KEY(NoDoctor) REFERENCES Doctor(UserId)
)

/*-                            replicas                           */


CREATE TABLE MEDICAMENTO(
	Nombre CHAR (15),
	Prescripcion BIT,
	Codigo VARCHAR(10),
	CasaFarmaceutica CHAR(15),
	Costo FLOAT,
	CONSTRAINT PK_MEDICAMENTO
		PRIMARY KEY (Codigo)
)

CREATE TABLE SUCURSAL (
	NoSucursal INT,
	Nombre CHAR (15),
	Direccion CHAR (100),
	Telefono CHAR(10),

	CONSTRAINT PK_SUCURSAL
		PRIMARY KEY (NoSucursal)
)

CREATE TABLE MEDICAMENTO_EN_SUCURSAL(
		CodigoMedicamento VARCHAR(10),
		NoSucursal INT,
		Cantidad INT,
		
		CONSTRAINT PK_MEDICAMENTOS_SE_ENCUENTRA_EN_SUCURAL
			PRIMARY KEY (CodigoMedicamento, NoSucursal),

		CONSTRAINT FK_MEDICAMENTOS_SE_ENCUENTRA_EN_SUCURAL_CodigoMedicamento
			FOREIGN KEY (CodigoMedicamento) REFERENCES MEDICAMENTO(Codigo) ON DELETE CASCADE ON UPDATE CASCADE ,

		CONSTRAINT FK_MEDICAMENTOS_SE_ENCUENTRA_EN_SUCURAL_NoSucursal
			FOREIGN KEY (NoSucursal) REFERENCES SUCURSAL(NoSucursal) ON DELETE CASCADE ON UPDATE CASCADE 
)


CREATE TABLE MEDICAMENTOS_POR_RECETA(
	NoReceta INT not null,
	IdMedicamento varchar(10) not null,
	Cantidad tinyint not null ,
	primary key(NoReceta, IdMedicamento),
	foreign key (NoReceta) References Receta(NoReceta),
	foreign key (IdMedicamento) References Medicamento(Codigo) 

)
		









