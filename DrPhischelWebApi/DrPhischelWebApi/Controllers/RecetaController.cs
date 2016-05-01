
using System.Web.Http;
using DrPhischelWebApi.Models;
using DrPhischelWebApi.DataBase;

namespace DrPhischelWebApi.Controllers
{
    public class RecetaController : ApiController
    {
        private RecetaAccess databaseAccess = new RecetaAccess();

        public Receta Post(Receta receta)
        {
            return databaseAccess.addReceta(receta);
        }

        [Route("api/Receta/Atencion/{NoAtencion}")]
        public VistaReceta get(string NoAtencion)
        {
            return databaseAccess.getReceta(NoAtencion);
        }
    }
}
