using DrPhischelWebApi.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace DrPhischelWebApi.DataBase
{
    public class HistorialAccess
    {
        public List<HistorialPorPaciente> getHistorialPorpaciente(string id_Paciente)
        {
            List<HistorialPorPaciente> list_atenciones = new List<HistorialPorPaciente>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                                            "Select h.IdPaciente, h.NoAtencion, a.Descripcion, a.Estudios, a.NoCita, CONVERT(VARCHAR(10),c.Fecha,120) as Fecha , "
                                            + " D.UserId as NoDoctor , (U.Nombre + u.Apellido) as Doctor"

                                            + " from HISTORIAL_POR_PACIENTE AS H JOIN ATENCION AS a ON a.NoAtencion = H.NoAtencion"
                                            + " Join CITA AS c ON c.NoCita = a.NoCita  Join DOCTOR as D on c.NoDoctor = D.UserId"
                                            + " Join USUARIO as u on d.UserId = u.Id"
                                            + " where h.IdPaciente = '" + id_Paciente + "'"
                    , con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) //si existe en la base de datos
                {
                    HistorialPorPaciente atencion = new HistorialPorPaciente();
                    atencion.idPaciente = rdr["IdPaciente"].ToString();
                    atencion.NoAtencion = rdr["NoAtencion"].ToString();
                    atencion.Descripcion = rdr["Descripcion"].ToString();
                    atencion.Estudios = rdr["Estudios"].ToString();
                    atencion.NoCita = rdr["NoCita"].ToString();
                    atencion.Fecha = rdr["Fecha"].ToString();
                    atencion.NoDoctor = rdr["NoDoctor"].ToString();
                    atencion.Doctor = rdr["Doctor"].ToString();
                    list_atenciones.Add(atencion);

                }
            }
            return list_atenciones;
        }

        public Atencion addAtencion(Atencion atencion, string idPaciente)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "EXEC dbo.insert_atencion_paciente @Descripcion = '"+atencion.Descripcion+"', @Estudios= '"+atencion.Estudios+"' ,"
                    +" @NoCita = '"+ atencion.NoCita +"' , @IdPaciente = '"+idPaciente+"'"
                , con);
                
                try
                {
                    con.Open();
                    atencion.NoAtencion = cmd.ExecuteScalar().ToString(); //execute query
                }
                catch (SqlException ex)
                {
                    atencion.NoAtencion = "Error";
                }
            }
            return atencion;
        }
    }
}