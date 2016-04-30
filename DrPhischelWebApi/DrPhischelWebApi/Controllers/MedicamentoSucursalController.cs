using System;
using System.Collections.Generic;
using System.Web.Http;
using DrPhischelWebApi.Models;
using DrPhischelWebApi.DataBase;


namespace DrPhischelWebApi.Controllers
{
    public class MedicamentoSucursalController : ApiController
    {
        private MedicamentoSucursalAccess databaseAccess = new MedicamentoSucursalAccess(); 

        [Route("api/Sucursal")]
        public List<Sucursal> Get()
        {
            return databaseAccess.getAllSucursales();
        }

        [Route("api/Medicamento/Sucursal/{NoSucursal}")]
        public List<Medicamento> GetPorSucursal(string NoSucursal)
        {
            return databaseAccess.getAllMedicamentosPorSucursal(NoSucursal);
        }


    }
}
