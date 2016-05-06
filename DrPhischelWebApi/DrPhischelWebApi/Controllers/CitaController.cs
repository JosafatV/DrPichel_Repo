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

        [HttpGet]
        public List<CitaPorPacienteYDoctor> getAllCitas()
        {
            return databaseAccess.getAllCitas();
        }
        [HttpGet]
        [Route("api/Cita/FechaHora/{FechaHora}/Doctor/{NoDoctor}")]
        public List<CitaPorPacienteYDoctor> getCitas(string NoDoctor, string FechaHora)
        {
            return databaseAccess.getCitas(NoDoctor, FechaHora);
        }

        [HttpPost]
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
        [HttpPut]
        public Cita putCita(Cita cita)
        {
            return databaseAccess.updateCita(cita);
        }

        [HttpDelete]
        [Route("api/Cita/{NoCita}")]
        public void DeleteCita(string Nocita)
        {
             databaseAccess.DeleteCita(Nocita);
        }



        public HttpResponseMessage Options()
        {
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
        }


    }
}
