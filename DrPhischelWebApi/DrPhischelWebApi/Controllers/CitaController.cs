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
        public Cita Post([FromBody]Cita cita)

        {
            if (!databaseAccess.ExisteCita(cita))
            {
                return databaseAccess.AddCita(cita);
            }
            else
            {
                return new Cita();
           }
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
