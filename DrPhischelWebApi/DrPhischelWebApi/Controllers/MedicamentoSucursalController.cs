using System;
using System.Collections.Generic;
using System.Web.Http;
using DrPhischelWebApi.Models;
using DrPhischelWebApi.DataBase;
using System.Net.Http;
using System.Net;


namespace DrPhischelWebApi.Controllers
{
    public class MedicamentoSucursalController : ApiController
    {
        private MedicamentoSucursalAccess databaseAccess = new MedicamentoSucursalAccess();

        [HttpGet]
        [Route("api/Sucursal")]
        public List<Sucursal> Get()
        {
            return databaseAccess.getAllSucursales();
        }

        [HttpGet]
        [Route("api/Medicamento/Sucursal/{NoSucursal}")]
        public List<Medicamento> GetPorSucursal(string NoSucursal)
        {
            return databaseAccess.getAllMedicamentosPorSucursal(NoSucursal);
        }

        [HttpPost]
        [Route("api/Medicamento")]
        public Medicamento postMedicamento( Medicamento medicamento)
        {
            return databaseAccess.addMedicamento(medicamento);
        }

        [HttpPost]
        [Route("api/Sucursal")]
        public Sucursal postSucursal(Sucursal sucursal)
        {
            return databaseAccess.addSucursal(sucursal);
        }

        [HttpPost]
        [Route("api/MedicamentoPorSucursal/Sucursal/{NoSucursal}/Medicamento/{CodigoMedicamento}/Cantidad/{Cantidad}")]
        public void postMedicamentoPorSucursal(string NoSucursal , string CodigoMedicamento, string Cantidad)
        {
            databaseAccess.addMedicamentoPorSucursal(NoSucursal, CodigoMedicamento, Cantidad);
        }


        public HttpResponseMessage Options()
        {
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
        }

    }
}
