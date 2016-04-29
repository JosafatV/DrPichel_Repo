using System;
using System.Collections.Generic;
using System.Web.Http;
using DrPhischelWebApi.Models;
using DrPhischelWebApi.DataBase;
using System.Net.Http;
using System.Web.Http;

namespace DrPhischelWebApi.Controllers
{
    public class HistorialController : ApiController
    {
        private HistorialAccess databaseAccess = new HistorialAccess();

        public List<HistorialPorPaciente> getHistorial(string idPAciente)
        {
            return databaseAccess.getHistorialPorpaciente(idPAciente);
        }

        [Route("api/Historial/Paciente/{idPaciente}")]
        public Atencion postAtencion(Atencion atencion, idPaciente)
        {
            return databaseAccess.addAtencion(atencion);
        }
    }
}
