USE DrPhischel
GO

CREATE PROCEDURE SP_Cobro_Doctores 
		@MONTO INT, @FromDate DATE, @ToDate DATE
	AS
		SELECT D.Cedula, D.Nombre, D.Apellido, COUNT(Pd.IdPaciente) AS NoPacientes, COUNT(Pd.IdPaciente)*@MONTO AS MONTO
		FROM DOCTOR AS D, PACIENTE_POR_DOCTOR AS Pd, CITA AS C
		WHERE D.NoDoctor=Pd.NoDoctor AND C.IdPaciente=Pd.IdPaciente AND C.Fecha BETWEEN @FromDate AND @ToDate
		