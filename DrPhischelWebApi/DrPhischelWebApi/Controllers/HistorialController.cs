
using System.Collections.Generic;
using System.Web.Http;
using DrPhischelWebApi.Models;
using DrPhischelWebApi.DataBase;


namespace DrPhischelWebApi.Controllers
{
    public class HistorialController : ApiController
    {
        private HistorialAccess databaseAccess = new HistorialAccess();

        [Route("api/Historial/Paciente/{idPaciente}")]
        public List<HistorialPorPaciente> getHistorial(string idPaciente)
        {
            return databaseAccess.getHistorialPorpaciente(idPaciente);
        }

        [Route("api/Historial/Atenciones/Paciente/{idPaciente}")]
        public Atencion postAtencion(Atencion atencion, string idPaciente)
        {
            return databaseAccess.addAtencion(atencion, idPaciente);
        }
    }
}
