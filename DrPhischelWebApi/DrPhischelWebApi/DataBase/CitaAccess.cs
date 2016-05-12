
using DrPhischelWebApi.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DrPhischelWebApi.DataBase
{
    public class CitaAccess
    {
        public Cita AddCita(Cita cita)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                /*  "Insert into CITA(NoDoctor, Fecha, Estado, IdPaciente) "
                    +"Values('"+cita.NoDoctor+"', "
                    +"CONVERT(datetime, SWITCHOFFSET(CONVERT(datetimeoffset, '"+cita.FechaHora+"'), DATENAME(TzOffset, SYSDATETIMEOFFSET()))),"
                    +"'"+cita.Estado+"', '"+cita.idPaciente+"');"
                    +" select scope_identity() ;"*/
                SqlCommand cmd = new SqlCommand(
                    " Insert into CITA(NoDoctor, Fecha, Estado, IdPaciente) " 
                    +" Values('"+cita.NoDoctor+"', '"+cita.FechaHora+"', '"+cita.Estado+"', '"+cita.idPaciente+"'); "
                    +" select scope_identity() ;"
                , con);
               
                try
                {
                    con.Open();
                    cita.NoCita = cmd.ExecuteScalar().ToString(); //execute query
                }
                catch (SqlException ex)
                {
                    cita.NoCita = "Error";
                }
            }
            return cita;
        }

        public List<CitaPorPacienteYDoctor> getAllCitas()
        {
            List<CitaPorPacienteYDoctor> ListCitas = new List<CitaPorPacienteYDoctor>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                                "Select C.NoCita , U.Id , U.Nombre, U.Apellido, CONVERT(VARCHAR(10), c.Fecha,120) as Fecha, CONVERT(VARCHAR(10), c.Fecha, 108) as Hora ,"
                                + " C.Estado, C.NoDoctor, U2.Nombre as NombreDoctor, U2.Apellido AS ApellidoDoctor"
                                + " from CITA as C JOIN PACIENTE AS P ON C.IdPaciente = P.UserId"
                                +" JOIN USUARIO AS U ON P.UserId = U.Id JOIN DOCTOR AS D ON C.NoDoctor = D.UserId JOIN USUARIO AS U2 ON U2.Id = D.UserId "
                                + " where C.Estado != 'B' "
                    , con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) //si existe en la base de datos
                {
                    CitaPorPacienteYDoctor cita = new CitaPorPacienteYDoctor();
                    cita.ApellidoDoctor = rdr["ApellidoDoctor"].ToString();
                    cita.ApellidoPaciente = rdr["Apellido"].ToString();
                    cita.Estado = rdr["Estado"].ToString();
                    cita.Fecha = rdr["Fecha"].ToString();
                    cita.NoCita = rdr["NoCita"].ToString();
                    cita.NoDoctor = rdr["NoDoctor"].ToString();
                    cita.NombreDoctor = rdr["NombreDoctor"].ToString();
                    cita.NombrePaciente = rdr["Nombre"].ToString();
                    cita.HoraInicio = rdr["Hora"].ToString();
                    cita.idPaciente = rdr["Id"].ToString();
                    ListCitas.Add(cita);

                }
            }
            return ListCitas;
        }

        public List<CitaPorPacienteYDoctor> getCitas(string NoDoctor, string FechaHora)
        {
            List<CitaPorPacienteYDoctor> ListCitas = new List<CitaPorPacienteYDoctor>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                                "Select C.NoCita, U.Id , U.Nombre, U.Apellido, CONVERT(VARCHAR(10), c.Fecha,120) as Fecha, CONVERT(VARCHAR(10), c.Fecha, 108) as Hora ,"
                                + " C.Estado, C.NoDoctor, U2.Nombre as NombreDoctor, U2.Apellido AS ApellidoDoctor"
                                + " from CITA as C JOIN PACIENTE AS P ON C.IdPaciente = P.UserId"
                                + " JOIN USUARIO AS U ON P.UserId = U.Id JOIN DOCTOR AS D ON C.NoDoctor = D.UserId JOIN USUARIO AS U2 ON U2.Id = D.UserId"
                                + " Where C.NoDoctor = '"+NoDoctor+"' and  CONVERT(VARCHAR(10), c.Fecha, 120) = CONVERT(VARCHAR(10), '"+FechaHora+ "', 120) and C.Estado != 'B'"
                    , con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) //si existe en la base de datos
                {
                    CitaPorPacienteYDoctor cita = new CitaPorPacienteYDoctor();
                    cita.ApellidoDoctor = rdr["ApellidoDoctor"].ToString();
                    cita.ApellidoPaciente = rdr["Apellido"].ToString();
                    cita.Estado = rdr["Estado"].ToString();
                    cita.Fecha = rdr["Fecha"].ToString();
                    cita.NoCita = rdr["NoCita"].ToString();
                    cita.NoDoctor = rdr["NoDoctor"].ToString();
                    cita.NombreDoctor = rdr["NombreDoctor"].ToString();
                    cita.NombrePaciente = rdr["Nombre"].ToString();
                    cita.HoraInicio = rdr["Hora"].ToString();
                    cita.idPaciente = rdr["Id"].ToString();
                    ListCitas.Add(cita);

                }
            }
            return ListCitas;
        }
        public bool ExisteCita(Cita cita)
        {
           
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                                " select  NoCita from cita where Fecha = '"+cita.FechaHora+"' and NoDoctor = '"+cita.NoDoctor+"' ;"
                    , con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read()) //si existe en la base de datos
                {
                    rdr["NoCita"].ToString();
                    return true;
                }
            }

            return false;
        }

        public Cita updateCita(Cita cita)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    " Update Cita set Estado = '"+cita.Estado+"', NoDoctor = '"+cita.NoDoctor+"' , Fecha = '"+cita.FechaHora+"', idPaciente = '"+cita.idPaciente+"' where NoCita = '"+cita.NoCita+"' "
                , con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            return cita;

        }
         public void DeleteCita(string NoCita)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    " Update Cita set Estado = 'B' where NoCita = '"+NoCita+"' "
                , con);
                con.Open();
                cmd.ExecuteNonQuery();
            }

        }
    }
}