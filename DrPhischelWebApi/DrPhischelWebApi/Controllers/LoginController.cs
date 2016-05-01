
using System.Collections.Generic;
using System.Web.Http;
using DrPhischelWebApi.Models;
using DrPhischelWebApi.DataBase;

namespace DrPhischelWebApi.Controllers
{
    public class LoginController : ApiController
    {
        private UsuarioAccess databaseAccess = new UsuarioAccess();

        [Route("api/LogInUser/Cedula/{Cedula}/Password/{Password}")]
        public List<Usuario> getUser(string Cedula, string Password)
        {
            return databaseAccess.getUsuario(Cedula, Password);
        }

    }
}
