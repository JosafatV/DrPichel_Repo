using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DrPhischelWebApi.Models;

namespace DrPhischelWebApi.DataBase
{
    public class PacienteAccess
    {
        public Paciente addPaciente(Paciente  paciente)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO MEDICAMENTO (Nombre ,Prescripcion, Codigo , CasaFarmaceutica , Costo) " +
                    "VALUES('" + medicamento.Nombre + "', " + medicamento.Prescripcion + ", '" + medicamento.codigo + "', '" + medicamento.CasaFarmaceutica + "', " + medicamento.Costo + "); "
                    , con);
                con.Open();
                cmd.ExecuteNonQuery();

            }
            return paciente;
        }

    }
}