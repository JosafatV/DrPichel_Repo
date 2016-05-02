using DrPhischelWebApi.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace DrPhischelWebApi.DataBase
{
    public class MedicamentoSucursalAccess
    {

        public List<Sucursal> getAllSucursales()
        {
            List<Sucursal> listSucursales = new List<Sucursal>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                //the select command
                SqlCommand cmd = new SqlCommand(
                    "SELECT NoSucursal , Nombre , Direccion , Telefono FROM SUCURSAL; ", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) //si existe en la base de datos
                {
                    //a new instance of Sucursal per row
                    Sucursal sucursal = new Sucursal();
                    sucursal.NoSucursal = rdr["NoSucursal"].ToString();
                    sucursal.Nombre = rdr["Nombre"].ToString();
                    sucursal.Direccion = rdr["Direccion"].ToString();
                    sucursal.Telefono = rdr["Telefono"].ToString();
                    listSucursales.Add(sucursal);

                }
            }
            return listSucursales;

        }
        public List<Medicamento> getAllMedicamentosPorSucursal(string Nosucursal)
        {
            List<Medicamento> listMedicamentos = new List<Medicamento>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT M.Nombre, M.Codigo , M.Prescripcion , M.CasaFarmaceutica , M.Costo  FROM MEDICAMENTO AS M JOIN MEDICAMENTO_EN_SUCURSAL AS MS"
                    + " ON M.Codigo = MS.CodigoMedicamento "
                    + " WHERE MS.NoSucursal = '" + Nosucursal + "' AND MS.Cantidad > 0  ; "
                    , con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) //si existe en la base de datos
                {
                    Medicamento medicamento = new Medicamento();
                    medicamento.Nombre = rdr["Nombre"].ToString();
                    medicamento.codigo = rdr["Codigo"].ToString();
                    medicamento.Prescripcion = rdr["Prescripcion"].ToString();
                    if (medicamento.Prescripcion == "True") { medicamento.Prescripcion = "1"; }
                    if (medicamento.Prescripcion == "False") { medicamento.Prescripcion = "0"; }
                    medicamento.CasaFarmaceutica = rdr["CasaFarmaceutica"].ToString();
                    medicamento.Costo = rdr["Costo"].ToString();
                    listMedicamentos.Add(medicamento);
                }
            }
            return listMedicamentos;
        }

        public Medicamento addMedicamento(Medicamento medicamento)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO MEDICAMENTO (Nombre,Prescripcion,Codigo,CasaFarmaceutica,Costo)" 
                    +" VALUES ('"+medicamento.Nombre+"', '"+medicamento.Prescripcion+"', '"+medicamento.codigo+"','"+medicamento.CasaFarmaceutica+"', '"+medicamento.Costo+"');"
                , con);
                con.Open();
                cmd.ExecuteNonQuery();//execute query
            }
            return medicamento;
        }

        public Sucursal addSucursal(Sucursal sucursal)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO SUCURSAL (NoSucursal , Nombre , Direccion , Telefono)" 
                    +" VALUES ( '"+sucursal.NoSucursal+"', '"+sucursal.Nombre+"' , '"+sucursal.Direccion+"' , '"+sucursal.Telefono+"');"
                , con);
                con.Open();
                cmd.ExecuteNonQuery();//execute query
            }
            return sucursal;
        }

        public void addSucursal(string NoSucursal, string CodigoMedicamento, string cantidad)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO MEDICAMENTO_EN_SUCURSAL (CodigoMedicamento,NoSucursal,Cantidad) VALUES ('"+CodigoMedicamento+"', '"+NoSucursal+"' , '"+cantidad+"'); "
                , con);
                con.Open();
                cmd.ExecuteNonQuery();//execute query
            }
        }

    }
}