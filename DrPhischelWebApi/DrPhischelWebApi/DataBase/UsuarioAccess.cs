using DrPhischelWebApi.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace DrPhischelWebApi.DataBase
{
    public class UsuarioAccess
    {
        public List<Usuario> getUsuario(string Cedula, string password )
        {
            List<Usuario> list_usuarios = new List<Usuario>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "Select u.Id , u.Cedula, u.Password,r.IdRol  from USUARIO as u  join ROL_POR_USUARIO as r on u.Id = r.IdUsuario "
                    +" where u.Password = '"+password+"' and Cedula = '"+Cedula+"'"
                    , con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) //si existe en la base de datos
                {
                    Usuario usuario = new Usuario();
                    usuario.Cedula = rdr["Cedula"].ToString();
                    usuario.id = rdr["Id"].ToString();
                    usuario.password = rdr["Password"].ToString();
                    usuario.rol = rdr["IdRol"].ToString();
                    list_usuarios.Add(usuario);
                }
            }
            return list_usuarios;
        }
    }
}