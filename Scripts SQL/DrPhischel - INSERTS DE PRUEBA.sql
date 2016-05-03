USE DrPhischel;


INSERT INTO ROL (Descripcion) values ('Paciente');
INSERT INTO ROL (Descripcion) values ('Doctor');
INSERT INTO ROL (Descripcion) values ('Administrador');



INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Alergología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Anestesiología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Cardiología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Gastroenterología');
INSERT INTO ESPECIALIDADMEDICA(Nombre) VALUES ('Endocrinología');




EXEC dbo.insert_paciente @cedula = '115230337' , @password = '12345' , @nombre = 'Sebastian' , @apellido = 'Gonzalez' , 
@FechaNacimiento = '1995-01-19' ,  @Residencia = 'Estados unidos', @Estado = 'N' , @peso = 80.7 , @altura = 1.76 
EXEC dbo.insert_paciente @cedula = '234523452' , @password = '12345' , @nombre = 'Cristian' , @apellido = 'Bolaños' , 
@FechaNacimiento = '1995-01-19' ,  @Residencia = 'Estados unidos', @Estado = 'N' , @peso = 70.7 , @altura = 1.75 
EXEC dbo.insert_paciente @cedula = '109785676' , @password = '12345' , @nombre = 'Celso' , @apellido = 'Borges' , 
@FechaNacimiento = '1995-01-19' ,  @Residencia = 'Estados unidos', @Estado = 'N' , @peso = 70.7 , @altura = 1.80 
insert into ROL_POR_USUARIO (IdRol, IdUsuario) values ('1','1');
insert into ROL_POR_USUARIO (IdRol, IdUsuario) values ('1','2');
insert into ROL_POR_USUARIO (IdRol, IdUsuario) values ('1','3');


EXEC dbo.insert_doctor @cedula ='112312321' , @password ='234234' , @nombre = 'Sternhammer' ,
@apellido = 'Stormfang', @FechaNacimiento = '1910-09-09' ,  @Residencia ='nowhere', @Estado = 'd' , 
@direccionConsultorio = 'Badab Primaris' , @Especialidad = '1', @tarjetaCredito = '345345353' , @CiudadConsultorio = 'San jose'
EXEC dbo.insert_doctor @cedula ='32423441' , @password ='234234' , @nombre = 'jaco' ,
@apellido = 'Ulrik', @FechaNacimiento = '1991-09-09' ,  @Residencia ='nowhere', @Estado = 'd' , 
@direccionConsultorio = 'Fenris' , @Especialidad = '4', @tarjetaCredito = '3344132', @CiudadConsultorio = 'Heredia'
EXEC dbo.insert_doctor @cedula ='23422342' , @password ='234234' , @nombre = 'jaco' ,
@apellido = 'Fabrikus', @FechaNacimiento = '1990-05-09' ,  @Residencia ='nowhere', @Estado = 'd' , 
@direccionConsultorio = 'Jericho Reach' , @Especialidad = '2', @tarjetaCredito = '345345353' , @CiudadConsultorio = 'Cartago'
insert into ROL_POR_USUARIO (IdRol, IdUsuario) values ('2','4');
insert into ROL_POR_USUARIO (IdRol, IdUsuario) values ('2','5');
insert into ROL_POR_USUARIO (IdRol, IdUsuario) values ('2','6');


INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('304820114', 'Alpharius', 'Omegon', '1385-05-06', 'San Jose', 'I');
INSERT INTO USUARIO (Cedula,Nombre,Apellido,FechaNacimiento,Residencia,Estado) VALUES ('607020776', 'Konrad', 'Curze', '1381-05-06', 'San Jose', 'I');
INSERT INTO ADMINISTRADOR (Hired,UserId) VALUES ('1386-05-06', 7);
INSERT INTO ADMINISTRADOR (Hired,UserId) VALUES ('1387-02-03', 8);
insert into ROL_POR_USUARIO (IdRol, IdUsuario) values ('2','7');
insert into ROL_POR_USUARIO (IdRol, IdUsuario) values ('2','8');





Insert into CITA(NoDoctor, Fecha, Estado, IdPaciente) 
Values('5','2019-05-05','P','1'); 
select scope_identity() ;
Insert into CITA(NoDoctor, Fecha, Estado, IdPaciente) 
Values('6','2019-05-05','P','3'); 
select scope_identity() ;


EXEC dbo.insert_atencion_paciente @Descripcion = 'No tiene nada', @Estudios= 'Le hice examen de sangre' , @NoCita = '1' , @IdPaciente = '1'


update CITA set Estado = 'C' where NoCita = 2



Insert into RECETA (Estado, NoAtencion, NoDoctor) Values ('A','1','4')




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


 