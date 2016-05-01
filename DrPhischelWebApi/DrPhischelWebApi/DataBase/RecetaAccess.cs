
using DrPhischelWebApi.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;



namespace DrPhischelWebApi.DataBase
{
    public class RecetaAccess
    {
        public Receta addReceta(Receta receta)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "Insert into RECETA (Estado, NoAtencion, NoDoctor) Values ('"+receta.Estado+"','"+receta.NoAtencion+"','"+receta.NoDoctor+"')"
                , con);
                con.Open();
                receta.NoReceta = cmd.ExecuteScalar().ToString(); //execute query
            }
            return receta;
        }

        public VistaReceta getReceta(string NoAtencion)
        {
            VistaReceta receta = new VistaReceta();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                        "Select NoReceta, r.Estado, r.NoAtencion, r.NoDoctor, (u2.Nombre + u2.Apellido) as Doctor,"
                        +" (u.Nombre + u.Apellido) as NombrePaciente, h.IdPaciente, u.Cedula"
                        +" from RECETA AS R JOIN HISTORIAL_POR_PACIENTE AS H ON R.NoAtencion = H.NoAtencion"
                        +" JOIN USUARIO AS U ON U.Id = H.IdPaciente JOIN USUARIO AS U2 ON R.NoDoctor = U2.Id"
                        +" where R.NoAtencion = '"+NoAtencion+"'"
                    , con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read()) //si existe en la base de datos
                {
                    receta.Cedula = rdr["Cedula"].ToString();
                    receta.Doctor = rdr["Doctor"].ToString();
                    receta.Estado = rdr["Estado"].ToString();
                    receta.IdPaciente = rdr["IdPaciente"].ToString();
                    receta.NoAtencion = rdr["NoAtencion"].ToString();
                    receta.NoDoctor = rdr["NoDoctor"].ToString();
                    receta.NombrePaciente = rdr["NombrePaciente"].ToString();
                    receta.NoReceta = rdr["NoReceta"].ToString();
                }
            }
            return receta;
        }
    }
}