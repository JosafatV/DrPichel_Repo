
using System.Collections.Generic;
using System.Web.Http;
using DrPhischelWebApi.Models;
using DrPhischelWebApi.DataBase;
using System.Net.Http;
using System.Net;

namespace DrPhischelWebApi.Controllers
{
    public class UserController : ApiController
    {
        private UsuarioAccess databaseAccess = new UsuarioAccess();

        [Route("api/LogInUser/Cedula/{Cedula}/Password/{Password}")]
        public List<Usuario> getUser(string Cedula, string Password)
        {
            return databaseAccess.getUsuario(Cedula, Password);
        }
        [Route("api/User/{IdUsuario}/Rol/{IdRol}")]
        public void setUserRol(string IdUsuario, string IdRol)
        {
            databaseAccess.setRolUsuario(IdUsuario, IdRol);
        }
        public HttpResponseMessage Options()
        {
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
        }
        [Route("api/User/prueba")]
        public UserController fdg() { return new UserController(); }

    }
}
