using System;
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
                        +"@direccionConsultorio = '"+doctor.DireccionConsultorio+"', @Especialidad = '"+doctor.Especialidad+"', @tarjetaCredito ='"+doctor.TarjetaCredito+ "', @CiudadConsultorio = '"+ doctor.CidudadConsultorio+"'"

                , con);
               
                try
                {
                    con.Open();
                    doctor.idUsuario = cmd.ExecuteScalar().ToString(); //execute query
                }
                catch (SqlException ex)
                {
                    doctor.idUsuario = "Error";
                }
            }
            return doctor;
        }
        public List<Doctor> getAllDoctors(string Estado)
        {
            List<Doctor> ListDoctores = new List<Doctor>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                                "Select D.UserId, U.Cedula, u.Nombre, u.Apellido, CONVERT(VARCHAR(10),FechaNacimiento,120) as Fecha, u.Residencia, u.Estado,"
                                + " D.DireccionConsultorio, D.Especialidad, D.TarjetaCredito , D.CiudadConsultorio"
                                + "  from USUARIO as U join DOCTOR AS D  ON D.UserId = U.Id Where U.Estado = '"+Estado+"';"
             
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
                    doctor.idUsuario = rdr["UserId"].ToString();
                    doctor.nombre = rdr["Nombre"].ToString();
                    doctor.Especialidad = rdr["Especialidad"].ToString();
                    doctor.Residencia = rdr["Residencia"].ToString();
                    doctor.TarjetaCredito = rdr["TarjetaCredito"].ToString();
                    doctor.CidudadConsultorio = rdr["CiudadConsultorio"].ToString();
                    ListDoctores.Add(doctor);

                }
            }
            return ListDoctores;
        }
        public List<Doctor> getDoctores(string Ciudad , string idEspecialidad)
        {
            List<Doctor> ListDoctores = new List<Doctor>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                                "Select D.UserId, U.Cedula, u.Nombre, u.Apellido, CONVERT(VARCHAR(10),FechaNacimiento,120) as Fecha, u.Residencia, u.Estado,"
                                + " D.DireccionConsultorio, D.Especialidad, D.TarjetaCredito , D.CiudadConsultorio"
                                + "  from USUARIO as U join DOCTOR AS D  ON D.UserId = U.Id"
                                +"  where D.CiudadConsultorio = '"+ Ciudad+ "'  AND D.Especialidad = '"+idEspecialidad+ "' and U.Estado = 'A'"
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
                    doctor.idUsuario = rdr["UserId"].ToString();
                    doctor.nombre = rdr["Nombre"].ToString();
                    doctor.Especialidad = rdr["Especialidad"].ToString();
                    doctor.Residencia = rdr["Residencia"].ToString();
                    doctor.TarjetaCredito = rdr["TarjetaCredito"].ToString();
                    doctor.CidudadConsultorio = rdr["CiudadConsultorio"].ToString();
                    ListDoctores.Add(doctor);

                }
            }
            return ListDoctores;
        }

        public Especialidad addEspecialidad(Especialidad especialidad)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    " Insert into EspecialidadMedica ( NoEspecialidad , Nombre) VALUES ( '"+especialidad.NoEspecialidad+"', '"+especialidad.Nombre+"' ) ;"
                , con);     
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery(); //execute query
                }
                catch (SqlException ex)
                {
                    especialidad.NoEspecialidad = "Error";
                }

            }
            return especialidad;

        }

        public List<Especialidad> getAllEspecialidades()
        {
            List<Especialidad> ListRol = new List<Especialidad>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select NoEspecialidad, Nombre from ESPECIALIDADMEDICA", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) //si existe en la base de datos
                {
                    Especialidad especialidad = new Especialidad();
                    especialidad.NoEspecialidad = rdr["NoEspecialidad"].ToString();
                    especialidad.Nombre = rdr["Nombre"].ToString();
                    ListRol.Add(especialidad);

                }
            }
            return ListRol;
        }

        public List<string> getAllCiudadesConsultorio()
        {
            List<string> Ciudades = new List<string>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "Select distinct(CiudadConsultorio)  from DOCTOR Join USUARIO ON DOCTOR.UserId = USUARIO.Id Where Estado = 'A'"
                    , con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) //si existe en la base de datos
                {
                    Ciudades.Add(rdr["CiudadConsultorio"].ToString());
                }
            }
            return Ciudades;
        }

        public Doctor updateDoctor(Doctor doctor)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "Update Usuario set Password = '" + doctor.password + "' , cedula = '" + doctor.cedula + "' , "
                    + " Nombre = '" + doctor.nombre +"' , Apellido = '"+ doctor.apellido + "' ,"
                    +" FechaNacimiento = '"+doctor.FechaNacimiento+"' , Residencia = '"+doctor.Residencia+"' , Estado = '"+doctor.Estado+"' where Id = '"+doctor.idUsuario+"' ; "
                    +" Update Doctor set CiudadConsultorio = '"+doctor.CidudadConsultorio+"' , DireccionConsultorio = '"+doctor.DireccionConsultorio+"' , "
                    +" Especialidad = '"+doctor.Especialidad+"' , TarjetaCredito = '"+doctor.TarjetaCredito+"' where  UserId = '"+doctor.idUsuario+"' "  ;
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery(); //execute query
      

            }
            return doctor;
        }




        

      /*  public void update_especialidad_a_Doctor(string NoEspecialidad, string NoDoctor)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    " Insert into EspecialidadMedica ( NoEspecialidad , Nombre) VALUES ( '" + especialidad.NoEspecialidad + "', '" + especialidad.Nombre + "' ) ;"
                , con);
                con.Open();
                cmd.ExecuteNonQuery(); //execute query
            }
            return especialidad;

        }*/
    }
}