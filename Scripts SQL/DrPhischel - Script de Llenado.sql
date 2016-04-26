INSERT INTO ROL (Descripcion) values (Paciente);
INSERT INTO ROL (Descripcion) values (Doctor);
INSERT INTO ROL (Descripcion) values (Administrador);
	
	/* PACIENTES */
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('323453234', 'Alfred', 'Cen', '1889-01-02', 'Colorado', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('323453815', 'Kregor', 'Than', '1815-01-02', 'Jericho Reach', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('323453816', 'Khiron', 'Ruberec', '1820-01-02', 'Karybdis', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('323453817', 'Meric', 'Voyen', '1785-01-02', 'Barbarus', 'B');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('323453652', 'Fabius', 'Bile', '1525-01-02', 'Chemos', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('323453818', 'Corbulo', 'Sanguinary', '1230-01-02', 'Baal', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('323453830', 'Ulrik', 'Lupus', '1526-01-02', 'Fenris', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('323453832', 'Sternhammer', 'Stormfang', '1702-01-02', 'Fenris', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('323453833', 'Fabrikus', 'Farbarius', '1562-01-02', 'Terra', 'I');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('323453834', 'Garreon', 'Abnett', '1468-01-02', 'Badab Primaris', 'I');
/* DOCTORES */
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('504340125', 'Lion', 'ElJonson', '1380-05-06', 'Holy Terra', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('504400342', 'Jaghatai', 'Khan', '1381-05-06', 'Limon', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('603640714', 'Leman', 'Russ', '1382-05-06', 'Heredia', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('500410698', 'Rogal', 'Dorn', '1383-05-06', 'Alajuela', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('208370808', 'Ferrus', 'Manus', '1384-05-06', 'Puntarenas', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('100160654', 'Roboute', 'Gulliman', '1383-05-06', 'Cartago', 'I');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('101370437', 'Fulgrim', 'Patriarch', '1382-05-06', 'Guanacaste', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('304820114', 'Alpharius', 'Omegon', '1385-05-06', 'San Jose', 'I');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('607020776', 'Konrad', 'Curze', '1381-05-06', 'San Jose', 'I');
/* ADMINISTRADOR */
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('106300667', 'Malcador', 'Sigillite', '1379-05-06', 'San Jose', 'A');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('102930586', 'Horus', 'Lupercal', '1380-02-03', 'San Jose', 'A');

INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (80, 2.30, 1);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (90, 2.25, 2);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (120, 2.48, 3);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (115, 2.74, 4);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (88, 2.65, 5);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (84, 2.51, 6);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (89, 2.63, 7);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (75, 2.74, 8);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (98, 2.43, 9);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (130, 2.63, 10);

INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', '', 9114064247038708, 11);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', '', 4703870841727471, 12);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', '', 4172747185588621, 13);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', '', 8558862159578374, 14);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', '', 5957837443409810, 15);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', '', 4340981032024215, 16);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', '', 3202421521652906, 17);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', '', 2165290656005919, 18);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', '', 5600591991140642, 19);

INSERT INTO ADMINISTRADOR (Hired,UserId) VALUES ('1386-05-06', 20);
INSERT INTO ADMINISTRADOR (Hired,UserId) VALUES ('1387-02-03', 21);

INSERT INTO HISTORIALMEDICO (Descripcion,Estudios) VALUES ('','');

INSERT INTO RECETA(Imagen,Estado) VALUES ('wh456asfv.pgn', 'A');
INSERT INTO RECETA(Imagen,Estado) VALUES ('whañsdjkf.png', 'A');

/* COMPLETADAS */
INSERT INTO CITA(Fecha,Estado) VALUES ('03/25/2016', 'C');
INSERT INTO CITA(Fecha,Estado) VALUES ('03/15/2016', 'C');
INSERT INTO CITA(Fecha,Estado) VALUES ('03/30/2016', 'C');
INSERT INTO CITA(Fecha,Estado) VALUES ('03/27/2016', 'C');
/* PERDIDAS */
INSERT INTO CITA(Fecha,Estado) VALUES ('03/30/2016', 'M');
INSERT INTO CITA(Fecha,Estado) VALUES ('03/27/2016', 'M');
/* PENDIENTES */
INSERT INTO CITA(Fecha,Estado) VALUES ('06/13/2016', 'P');
INSERT INTO CITA(Fecha,Estado) VALUES ('06/21/2016', 'P');
INSERT INTO CITA(Fecha,Estado) VALUES ('06/05/2016', 'P');
INSERT INTO CITA(Fecha,Estado) VALUES ('07/25/2016', 'P');
INSERT INTO CITA(Fecha,Estado) VALUES ('06/16/2016', 'P');

INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Alergología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Anestesiología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Cardiología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Gastroenterología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Endocrinología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Infectología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Nefrología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Neumología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Neurología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Oftalmología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Oncología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Toxicología');

/* ROL PACIENTE */
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 1)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 2)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 3)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 4)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 5)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 6)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 7)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 8)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 9)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 10)
/* ROL DOCTOR */
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 11)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 12)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 13)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 14)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 15)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 16)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 17)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 18)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 19)
/* ROL ADMIN */
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (3, 20)
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (3, 21)

INSERT INTO PACIENTE_POR_DOCTOR (IdPaciente,NoDoctor) VALUES (

INSERT INTO HISTORIAL_POR_PACIENTE (IdPaciente,NoHistorial) VALUES (1, 1);
INSERT INTO HISTORIAL_POR_PACIENTE (IdPaciente,NoHistorial) VALUES (1, 2);
INSERT INTO HISTORIAL_POR_PACIENTE (IdPaciente,NoHistorial) VALUES (2, 3);
INSERT INTO HISTORIAL_POR_PACIENTE (IdPaciente,NoHistorial) VALUES (2, 4);

INSERT INTO RECETA_POR_HISTORIAL (NoHistorial,NoReceta)  VALUES (

INSERT INTO RECETA_POR_DOCTOR (NoDoctor,NoReceta) VALUES (

INSERT INTO CITA_POR_PACIENTE (IdPaciente,NoCita) VALUES (

INSERT INTO CITA_POR_DOCTOR (NoDoctor,NoCita) VALUES (

INSERT INTO ESPECIALIDAD_POR_DOCTOR (NoDoctor,NoEspecialidad) values (
 
 
 






