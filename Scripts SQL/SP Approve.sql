USE DrPhischel
GO

CREATE PROCEDURE SP_Approve_Doctor
	@NoDoctor INT
	AS
		UPDATE USUARIO
		SET Estado='A' /* 'A' Approved */
		FROM USUARIO AS U, DOCTOR AS D
		WHERE D.UserId=U.Id AND D.NoDoctor=@NoDoctor
	GO


CREATE PROCEDURE SP_Approve_Paciente
	@IdPaciente INT
	AS
		UPDATE USUARIO
		SET Estado='A' /* 'A' Approved */
		FROM USUARIO AS U, PACIENTE AS P
		WHERE P.UserId=U.Id AND P.IdPaciente=@IdPaciente;
	GO