using System.Collections.Generic;
using System.Web.Http;
using DrPhischelWebApi.Models;
using DrPhischelWebApi.DataBase;
using System.Net.Http;
using System.Net;

namespace DrPhischelWebApi.Controllers
{
    public class CitaController : ApiController
    {
        CitaAccess databaseAccess = new CitaAccess();

        public List<CitaPorPacienteYDoctor> getAllCitas()
        {
            return databaseAccess.getAllCitas();
        }

        public Cita Post(Cita cita)
        {
            return databaseAccess.AddCita(cita);
        }
        public HttpResponseMessage Options()
        {
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
        }


    }
}
