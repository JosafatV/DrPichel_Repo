using System;
using System.Collections.Generic;
using System.Web.Http;
using DrPhischelWebApi.Models;
using DrPhischelWebApi.DataBase;
using System.Net.Http;
using System.Net;

namespace DrPhischelWebApi.Controllers
{
    public class DoctorController : ApiController
    {
        private DoctorAccess databaseAccess = new DoctorAccess();

        [HttpPost]
        public Doctor Post(Doctor doctor)
        {
            return databaseAccess.addDoctor(doctor);
        }
        [HttpGet]
        public List<Doctor> getAllDoctores()
        {
            return databaseAccess.getAllDoctors();
        }
        [HttpGet]
        [Route("api/Doctor/Ciudad/{ciudad}/Especialidad/{idEspecialidad}")]
        public List<Doctor> getDoctores(string ciudad, string idEspecialidad)
        {
            return databaseAccess.getDoctores(ciudad, idEspecialidad);
        }
        [HttpGet]
        [Route("api/Doctor/Especialidades")]
        public List<Especialidad> getEspecialidades()
        {
            return databaseAccess.getAllEspecialidades();
        }
        [HttpPost]
        [Route("api/Doctor/Especialidades")]
        public Especialidad postEspecialidad(Especialidad especialidad)
        {
            return databaseAccess.addEspecialidad(especialidad);
        }
        [HttpGet]
        [Route("api/Doctor/Ciudades")]
        public List<string> getCiudades()
        {
            return databaseAccess.getAllCiudadesConsultorio();
        }

        public HttpResponseMessage Options()
        {
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
        }
    }
}
