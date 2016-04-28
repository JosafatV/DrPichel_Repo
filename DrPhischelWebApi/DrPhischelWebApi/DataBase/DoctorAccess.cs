﻿
using DrPhischelWebApi.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace DrPhischelWebApi.DataBase
{
    public class DoctorAccess
    {
        public Doctor addDoctor(Doctor doctor)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(

"Exec dbo.insert_doctor @cedula= '"+doctor.cedula+"' , @password = '"+doctor.password+"', @nombre ='"+doctor.nombre+ "' , "
+" @apellido ='"+doctor.apellido+"' , @FechaNacimiento ='"+doctor.FechaNacimiento+"' , @Residencia  ='"+doctor.Residencia+"' , @Estado ='"+doctor.Estado+"',"
+"@direccionConsultorio = '"+doctor.DireccionConsultorio+"', @Especialidad = '"+doctor.Especialidad+"', @tarjetaCredito ='"+doctor.TarjetaCredito+"' "
                   
                , con);
                con.Open();
                doctor.NoDoctor = cmd.ExecuteScalar().ToString(); //execute query
            }
            return doctor;
        }
        public List<Doctor> getAllDoctors()
        {
            List<Doctor> ListDoctores = new List<Doctor>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
"Select D.UserId, U.Cedula, u.Nombre, u.Apellido, CONVERT(VARCHAR(10),FechaNacimiento,120) as Fecha , u.Residencia, u.Estado,"
+ "  D.NoDoctor, D.DireccionConsultorio, d.Especialidad, d.TarjetaCredito"
+"  from USUARIO as U join DOCTOR AS D  ON d.NoDoctor = U.Id;"
                    , con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) //si existe en la base de datos
                {
                    Doctor doctor = new Doctor();
                    doctor.DireccionConsultorio = rdr["DireccionConsultorio"].ToString();
                    doctor.apellido = rdr["Apellido"].ToString();
                    doctor.cedula = rdr["Cedula"].ToString();
                    doctor.Estado = rdr["Estado"].ToString();
                    doctor.FechaNacimiento = rdr["Fecha"].ToString();
                    doctor.NoDoctor = rdr["NoDoctor"].ToString();
                    doctor.idUsuario = rdr["UserId"].ToString();
                    doctor.nombre = rdr["Nombre"].ToString();
                    doctor.Especialidad = rdr["Especialidad"].ToString();
                    doctor.Residencia = rdr["Residencia"].ToString();
                    doctor.TarjetaCredito = rdr["TarjetaCredito"].ToString();
                    ListDoctores.Add(doctor);

                }
            }
            return ListDoctores;
        }
    }
}