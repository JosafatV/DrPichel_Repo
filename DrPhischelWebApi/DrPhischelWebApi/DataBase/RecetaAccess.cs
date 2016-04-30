
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
        public MedicamentoPorReceta AddMedicamentoReceta(MedicamentoPorReceta medicamento_x_receta)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "insert into medicamentos_por_Receta (NoReceta, IdMedicamento, Cantidad)" 
                    +" values('"+medicamento_x_receta.NoReceta+"','"+medicamento_x_receta.IdMedicamento+"','"+medicamento_x_receta.Cantidad+"') "
                , con);
                con.Open();
                cmd.ExecuteNonQuery(); //execute query
            }
            return medicamento_x_receta;
        }
    }
}