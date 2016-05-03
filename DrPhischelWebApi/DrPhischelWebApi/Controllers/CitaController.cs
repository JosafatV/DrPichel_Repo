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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<CitaPorPacienteYDoctor> getAllCitas()
        {
            return databaseAccess.getAllCitas();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cita"></param>
        /// <returns></returns>
        public Cita Post(Cita cita)
        {
            return databaseAccess.AddCita(cita);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Options()
        {
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
        }


    }
}
