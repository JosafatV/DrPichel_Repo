CREATE PROCEDURE SP_Insert_SuperTable
	AS

	INSERT INTO USUARIO
	SELECT S.idUsuario, S.Password, S.Cedula, S.Nombre, S.Apellido, S.FechaNacimiento, S.Residencia, S.Estado
	FROM Sheet1$ AS S

	INSERT INTO PACIENTE
	SELECT S.Peso, S.Altura, S.idUsuario
	FROM Sheet1$ AS S
	WHERE Rol='P'

	INSERT INTO DOCTOR
	SELECT S.DirecciónConsultorio, S.TarjetaCredito, S.idUsuario
	FROM Sheet1$ AS S
	WHERE Rol='D';

	INSERT INTO ROL_POR_USUARIO
	SELECT S.idUsuario, S.Rol
	FROM Sheet1$ AS S