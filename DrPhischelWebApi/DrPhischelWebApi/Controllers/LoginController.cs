
using System.Collections.Generic;
using System.Web.Http;
using DrPhischelWebApi.Models;
using DrPhischelWebApi.DataBase;
using System.Net.Http;
using System.Net;

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
        public HttpResponseMessage Options()
        {
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
        }

    }
}
