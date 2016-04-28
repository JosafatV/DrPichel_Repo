﻿
using DrPhischelWebApi.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;


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
                    "EXEC dbo.insert_paciente @cedula = '"+paciente.cedula+"', @password = '"+paciente.password+"', @nombre = '"+paciente.nombre+"', @apellido = '"+paciente.apellido+"',"
                    +" @FechaNacimiento = '"+paciente.FechaNacimiento+"', @Residencia = '"+paciente.Residencia+"', @Estado = '"+paciente.Estado+"', @peso = '"+paciente.peso+"', @altura = '"+paciente.altura+"'"
                    , con);
                con.Open();
                paciente.idPaciente = cmd.ExecuteScalar().ToString(); //execute query
            }
            return paciente;
        }
        public List<Paciente> getPacientes()
        {
            List<Paciente> listPacientes = new List<Paciente>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    " Select p.UserId, U.Cedula, u.Nombre, u.Apellido, CONVERT(VARCHAR(10),FechaNacimiento,120) as Fecha, u.Residencia, u.Estado, p.IdPaciente, p.Altura, p.Peso "
                    + " from USUARIO as U join PACIENTE as p   ON P.UserId = U.Id ;  "
                    , con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) //si existe en la base de datos
                {
                    Paciente paciente = new Paciente();
                    paciente.altura = rdr["Altura"].ToString();
                    paciente.apellido = rdr["Apellido"].ToString();
                    paciente.cedula = rdr["Cedula"].ToString();
                    paciente.Estado = rdr["Estado"].ToString();
                    paciente.FechaNacimiento = rdr["Fecha"].ToString();
                    paciente.idPaciente = rdr["idPaciente"].ToString();
                    paciente.idUsuario = rdr["UserId"].ToString();
                    paciente.nombre = rdr["Nombre"].ToString();
                    paciente.peso = rdr["Peso"].ToString();
                    paciente.Residencia = rdr["Residencia"].ToString();
                    listPacientes.Add(paciente);
                    
                }
            }
            return listPacientes;
        }

    }
}