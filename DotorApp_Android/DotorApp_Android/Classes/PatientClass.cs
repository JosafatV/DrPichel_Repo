using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace DotorApp_Android
{
    public class PatientClass
    {
        String Nombre;
        String Apellido;
        String Cedula;
        String Peso;
        String Altura;
        String FechaNacimiento;

        //setter
        public void setPatient(String _Nombre, 
                               String _Apellido,
                               String _Cedula,
                               String _Peso,
                               String _Altura,
                               String _FechaNacimiento)
        {
            this.Nombre = _Nombre;
            this.Apellido = _Apellido;
            this.Cedula = _Cedula;
            this.Peso = _Peso;
            this.Altura = _Altura;
            this.FechaNacimiento = _FechaNacimiento;
        }

        //getters
        public String getNombre()
        {
            return this.Nombre;
        }

        public String getApellido()
        {
            return this.Apellido;
        }

        public String getCedula()
        {
            return this.Cedula;
        }

        public String getPeso()
        {
            return this.Peso;
        }

        public String getAltura()
        {
            return this.Altura;
        }
        public String getFechaNacimiento()
        {
            return this.FechaNacimiento;
        }
    }
}
