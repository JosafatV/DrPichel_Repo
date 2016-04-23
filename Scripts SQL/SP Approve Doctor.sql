USE DrPhischel
GO

CREATE PROCEDURE SP_Approve_Doctor
	@NoDoctor INt
	AS
		UPDATE DOCTOR
		SET Estado='A' /* Aprovado */
		WHERE NoDoctor=@NoDoctor;


/*
  'A' Approved
  'X' Eliminated
  'P' Pending
*/