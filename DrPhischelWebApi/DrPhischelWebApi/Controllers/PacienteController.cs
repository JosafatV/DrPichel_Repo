using System;
using System.Collections.Generic;
using System.Web.Http;
using DrPhischelWebApi.Models;
using DrPhischelWebApi.DataBase;




namespace DrPhischelWebApi.Controllers
{
    public class PacienteController : ApiController
    {
        private PacienteAccess databaseAccess = new PacienteAccess();
        public Paciente Post(Paciente paciente)
        {
            return databaseAccess.addPaciente(paciente);
        }
        public List<Paciente> getPacientes()
        {
            return databaseAccess.getPacientes();
        }

    }

}
