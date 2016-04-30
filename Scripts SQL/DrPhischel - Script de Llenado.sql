USE DrPhischel;

INSERT INTO ROL (Descripcion) values ('Paciente');
INSERT INTO ROL (Descripcion) values ('Doctor');
INSERT INTO ROL (Descripcion) values ('Administrador');
	
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
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (92, 2.48, 3);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (95, 2.74, 4);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (88, 2.65, 5);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (84, 2.51, 6);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (89, 2.63, 7);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (75, 2.74, 8);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (98, 2.43, 9);
INSERT INTO PACIENTE (Peso,Altura,UserId) VALUES (93, 2.63, 10);

INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', 5, 9114064247038708, 11);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', 8, 4703870841727471, 12);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', 7, 4172747185588621, 13);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', 1, 8558862159578374, 14);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', 4, 5957837443409810, 15);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', 5, 4340981032024215, 16);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', 1, 3202421521652906, 17);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', 2, 2165290656005919, 18);
INSERT INTO DOCTOR (DireccionConsultorio,Especialidad,TarjetaCredito,UserId) VALUES ('', 3, 5600591991140642, 19);

INSERT INTO ADMINISTRADOR (Hired,UserId) VALUES ('1386-05-06', 20);
INSERT INTO ADMINISTRADOR (Hired,UserId) VALUES ('1387-02-03', 21);

INSERT INTO HISTORIALMEDICO (Descripcion,Estudios) VALUES ('El paciente se pesenta con dolor estomacal, palidez, deshidratación','presión normal, se le remedia suero');
INSERT INTO HISTORIALMEDICO (Descripcion,Estudios) VALUES ('Ardor de garganta, parece normal','se le remedia bupivicaína');
INSERT INTO HISTORIALMEDICO (Descripcion,Estudios) VALUES ('Intoxicacion, se presenta con irritacion en los ojos y deshidratación','se le medica Halothano y Bupivicaína');
INSERT INTO HISTORIALMEDICO (Descripcion,Estudios) VALUES ('El paciente se presenta con dolor estomacal, no presenta muestras de daño físico','presión normal, sangre normal, se le medica un placebo');

INSERT INTO RECETA(Imagen,Estado) VALUES ('wh456asfv.pgn', 'A');
INSERT INTO RECETA(Imagen,Estado) VALUES ('whañsdjkf.png', 'A');

/* COMPLETADAS */
INSERT INTO CITA(Fecha,Estado) VALUES ('03/25/2016 13:30', 'C');
INSERT INTO CITA(Fecha,Estado) VALUES ('03/15/2016 17:00', 'C');
INSERT INTO CITA(Fecha,Estado) VALUES ('03/30/2016 14:45', 'C');
INSERT INTO CITA(Fecha,Estado) VALUES ('03/27/2016 08:00', 'C');
/* PERDIDAS */
INSERT INTO CITA(Fecha,Estado) VALUES ('03/30/2016 07:30', 'M');
INSERT INTO CITA(Fecha,Estado) VALUES ('03/27/2016 15:00', 'M');
/* PENDIENTES */
INSERT INTO CITA(Fecha,Estado) VALUES ('06/13/2016 09:30', 'P');
INSERT INTO CITA(Fecha,Estado) VALUES ('06/21/2016 07:45', 'P');
INSERT INTO CITA(Fecha,Estado) VALUES ('06/05/2016 08:20', 'P');
INSERT INTO CITA(Fecha,Estado) VALUES ('07/25/2016 14:00', 'P');
INSERT INTO CITA(Fecha,Estado) VALUES ('06/16/2016 08:30', 'P');

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
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 1);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 2);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 3);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 4);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 5);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 6);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 7);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 8);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 9);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (1, 10);
/* ROL DOCTOR */
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 11);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 12);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 13);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 14);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 15);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 16);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 17);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 18);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (2, 19);
/* ROL ADMIN */
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (3, 20);
INSERT INTO ROL_POR_USUARIO (IdRol,IdUsuario) VALUES (3, 21);

INSERT INTO PACIENTE_POR_DOCTOR (IdPaciente,NoDoctor) VALUES (1, 1);
INSERT INTO PACIENTE_POR_DOCTOR (IdPaciente,NoDoctor) VALUES (1, 2);
INSERT INTO PACIENTE_POR_DOCTOR (IdPaciente,NoDoctor) VALUES (2, 1);
INSERT INTO PACIENTE_POR_DOCTOR (IdPaciente,NoDoctor) VALUES (3, 4);
INSERT INTO PACIENTE_POR_DOCTOR (IdPaciente,NoDoctor) VALUES (4, 1);
INSERT INTO PACIENTE_POR_DOCTOR (IdPaciente,NoDoctor) VALUES (4, 5);

INSERT INTO HISTORIAL_POR_PACIENTE (IdPaciente,NoHistorial) VALUES (1, 1);
INSERT INTO HISTORIAL_POR_PACIENTE (IdPaciente,NoHistorial) VALUES (1, 2);
INSERT INTO HISTORIAL_POR_PACIENTE (IdPaciente,NoHistorial) VALUES (2, 3);
INSERT INTO HISTORIAL_POR_PACIENTE (IdPaciente,NoHistorial) VALUES (2, 4);

INSERT INTO RECETA_POR_HISTORIAL (NoHistorial,NoReceta)  VALUES (2, 1)
INSERT INTO RECETA_POR_HISTORIAL (NoHistorial,NoReceta)  VALUES (3, 2)

INSERT INTO RECETA_POR_DOCTOR (NoDoctor,NoReceta) VALUES (2, 2);
INSERT INTO RECETA_POR_DOCTOR (NoDoctor,NoReceta) VALUES (1, 2);

INSERT INTO CITA_POR_PACIENTE (IdPaciente,NoCita) VALUES (3, 11);
INSERT INTO CITA_POR_PACIENTE (IdPaciente,NoCita) VALUES (4, 10);
INSERT INTO CITA_POR_PACIENTE (IdPaciente,NoCita) VALUES (5, 9);
INSERT INTO CITA_POR_PACIENTE (IdPaciente,NoCita) VALUES (1, 8);
INSERT INTO CITA_POR_PACIENTE (IdPaciente,NoCita) VALUES (4, 7);
INSERT INTO CITA_POR_PACIENTE (IdPaciente,NoCita) VALUES (3, 6);
INSERT INTO CITA_POR_PACIENTE (IdPaciente,NoCita) VALUES (1, 5);
INSERT INTO CITA_POR_PACIENTE (IdPaciente,NoCita) VALUES (1, 4);
INSERT INTO CITA_POR_PACIENTE (IdPaciente,NoCita) VALUES (2, 3);
INSERT INTO CITA_POR_PACIENTE (IdPaciente,NoCita) VALUES (1, 2);
INSERT INTO CITA_POR_PACIENTE (IdPaciente,NoCita) VALUES (2, 1);

INSERT INTO CITA_POR_DOCTOR (NoDoctor,NoCita) VALUES (1, 1);
INSERT INTO CITA_POR_DOCTOR (NoDoctor,NoCita) VALUES (2, 2);
INSERT INTO CITA_POR_DOCTOR (NoDoctor,NoCita) VALUES (1, 3);
INSERT INTO CITA_POR_DOCTOR (NoDoctor,NoCita) VALUES (3, 4);
INSERT INTO CITA_POR_DOCTOR (NoDoctor,NoCita) VALUES (1, 5);
INSERT INTO CITA_POR_DOCTOR (NoDoctor,NoCita) VALUES (2, 6);
INSERT INTO CITA_POR_DOCTOR (NoDoctor,NoCita) VALUES (1, 7);
INSERT INTO CITA_POR_DOCTOR (NoDoctor,NoCita) VALUES (4, 8);
INSERT INTO CITA_POR_DOCTOR (NoDoctor,NoCita) VALUES (5, 9);
INSERT INTO CITA_POR_DOCTOR (NoDoctor,NoCita) VALUES (3, 10);
INSERT INTO CITA_POR_DOCTOR (NoDoctor,NoCita) VALUES (2, 11);

INSERT INTO ESPECIALIDAD_POR_DOCTOR (NoDoctor,NoEspecialidad) values (1,5);
INSERT INTO ESPECIALIDAD_POR_DOCTOR (NoDoctor,NoEspecialidad) values (2,8);
INSERT INTO ESPECIALIDAD_POR_DOCTOR (NoDoctor,NoEspecialidad) values (3,7);
INSERT INTO ESPECIALIDAD_POR_DOCTOR (NoDoctor,NoEspecialidad) values (4,1);
INSERT INTO ESPECIALIDAD_POR_DOCTOR (NoDoctor,NoEspecialidad) values (5,4);
INSERT INTO ESPECIALIDAD_POR_DOCTOR (NoDoctor,NoEspecialidad) values (6,5);
INSERT INTO ESPECIALIDAD_POR_DOCTOR (NoDoctor,NoEspecialidad) values (7,1);
INSERT INTO ESPECIALIDAD_POR_DOCTOR (NoDoctor,NoEspecialidad) values (8,2);
INSERT INTO ESPECIALIDAD_POR_DOCTOR (NoDoctor,NoEspecialidad) values (9,3);



INSERT INTO SUCURSAL (NoSucursal , Nombre , Direccion , Telefono) VALUES (11,'Heredia' , 'San Pablo' ,'22654356');
INSERT INTO SUCURSAL (NoSucursal , Nombre , Direccion , Telefono) VALUES (22,'San Jose', 'San Jose Centro' ,'24346547');
INSERT INTO SUCURSAL (NoSucursal , Nombre , Direccion , Telefono) VALUES (33,'Alajuela', 'Poas' ,'9894774');

INSERT INTO MEDICAMENTO (Nombre,Prescripcion,Codigo,CasaFarmaceutica,Costo) VALUES ('Halothano', 1, '111', 'AbbottLabs', 500);
INSERT INTO MEDICAMENTO (Nombre,Prescripcion,Codigo,CasaFarmaceutica,Costo) VALUES ('Ketamina', 1, '222', 'AbbottLabs', 500);
INSERT INTO MEDICAMENTO (Nombre,Prescripcion,Codigo,CasaFarmaceutica,Costo) VALUES ('Bupivicaína', 0, '333', 'Pfizer', 200);
INSERT INTO MEDICAMENTO (Nombre,Prescripcion,Codigo,CasaFarmaceutica,Costo) VALUES ('Lidocaína', 0, '444', 'Bayer', 750);
INSERT INTO MEDICAMENTO (Nombre,Prescripcion,Codigo,CasaFarmaceutica,Costo) VALUES ('Ibuprofeno', 0, '555', 'Bayer', 500);
INSERT INTO MEDICAMENTO (Nombre,Prescripcion,Codigo,CasaFarmaceutica,Costo) VALUES ('Paracetamol', 0, '666', 'Bayer', 750);
INSERT INTO MEDICAMENTO (Nombre,Prescripcion,Codigo,CasaFarmaceutica,Costo) VALUES ('Codeína', 1, '777', 'Pfizer', 1250);
INSERT INTO MEDICAMENTO (Nombre,Prescripcion,Codigo,CasaFarmaceutica,Costo) VALUES ('Morfina', 1, '888', 'Pfizer', 2150);
INSERT INTO MEDICAMENTO (Nombre,Prescripcion,Codigo,CasaFarmaceutica,Costo) VALUES ('Alopurinol', 0, '999', 'AbbottLabs', 500);
INSERT INTO MEDICAMENTO (Nombre,Prescripcion,Codigo,CasaFarmaceutica,Costo) VALUES ('Clorfenamina', 0, '000', 'Bayer', 300);
INSERT INTO MEDICAMENTO (Nombre,Prescripcion,Codigo,CasaFarmaceutica,Costo) VALUES ('Dexametasona', 0, '010', 'Bayer', 200);

INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('111', 11 , 34); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('222', 11 , 100); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('333', 11 , 100);
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('444', 11 , 300); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('555', 11 , 34); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('777', 11 , 100); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('888', 11 , 100);
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('999', 11 , 300); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('111', 22 , 34); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('222', 22 , 100); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('444', 22 , 100);
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('555', 22 , 300); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('666', 22 , 34); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('333', 22 , 100); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('010', 22 , 300); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('777', 33 , 34); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('666', 33 , 100); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('555', 33 , 100);
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('444', 33 , 300); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('333', 33 , 34); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('222', 33 , 100); 
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('111', 33 , 100);
INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('010', 33 , 300); 
