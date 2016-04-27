USE DrPhischel
GO

CREATE PROCEDURE SP_Cobro_Doctores 
		@MONTO INT, @FromDate DATE, @ToDate DATE
	AS
		SELECT U.Nombre, U.Apellido, COUNT(Cd.NoCita) AS Cantidad_De_Citas, COUNT(Cd.NoCita)*@MONTO AS Cobro
		FROM USUARIO AS U, DOCTOR AS D, CITA_POR_DOCTOR AS Cd
		WHERE U.Id = D.UserId AND  U.Estado='A' AND D.NoDoctor=Cd.NoDoctor
		GROUP BY U.Nombre, U.Apellido
		