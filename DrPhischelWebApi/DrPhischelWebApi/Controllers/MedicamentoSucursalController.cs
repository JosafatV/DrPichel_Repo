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
        public Medicamento postMedicamento(Medicamento medicamento)
        {
            return databaseAccess.addMedicamento(medicamento);
        }
        [HttpPost]
        [Route("api/Medicamento/List")]
        public List<Medicamento> PostList(List<Medicamento> list)
        {
            databaseAccess.deleteSentence("Delete from medicamento");
            for (int i = 0; i < list.Count; i++)
            {
                databaseAccess.addMedicamento(list[i]);
            }
            return list;
        }

        [HttpPost]
        [Route("api/Sucursal")]
        public Sucursal postSucursal(Sucursal sucursal)
        {
            return databaseAccess.addSucursal(sucursal);
        }
        [HttpPost]
        [Route("api/Sucursal/List")]
        public List<Sucursal> PostSucursalList(List<Sucursal> list)
        {
            databaseAccess.deleteSentence("Delete from Sucursal");
            for (int i = 0; i < list.Count; i++)
            {
                databaseAccess.addSucursal(list[i]);
            }
            return list;
        }

        [HttpDelete]
        [Route("api/MedicamentoPorSucursal")]
        public void deleteSucursalPorMedicamento() {
            databaseAccess.deleteSentence("Delete from Medicamento_en_sucursal");
        }



        [HttpPost]
        [Route("api/MedicamentoPorSucursal/Sucursal/{NoSucursal}/Medicamento/{CodigoMedicamento}/Cantidad/{Cantidad}")]
        public void postMedicamentoPorSucursal(string NoSucursal , string CodigoMedicamento, string Cantidad)
        {
            databaseAccess.addMedicamentoPorSucursal(NoSucursal, CodigoMedicamento, Cantidad);
        }



        [HttpOptions]
        [Route("api/MedicamentoPorSucursal")]
        [Route("api/Medicamento/List")]
        [Route("api/Sucursal/List")]
        [Route("api/MedicamentoPorSucursal/Sucursal/{NoSucursal}/Medicamento/{CodigoMedicamento}/Cantidad/{Cantidad}")]
        public HttpResponseMessage Options2()
        {
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
        }

    }
}
