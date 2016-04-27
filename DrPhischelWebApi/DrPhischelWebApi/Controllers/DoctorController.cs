using System;
using System.Collections.Generic;
using System.Web.Http;
using DrPhischelWebApi.Models;
using DrPhischelWebApi.DataBase;

namespace DrPhischelWebApi.Controllers
{
    public class DoctorController : ApiController
    {
        private DoctorAccess databaseAccess = new DoctorAccess();
        public Doctor Post(Doctor doctor)
        {
            return databaseAccess.addDoctor(doctor);
        }
        public List<Doctor> getAllDoctores()
        {
            return databaseAccess.getAllDoctors();
        }
    }
}
