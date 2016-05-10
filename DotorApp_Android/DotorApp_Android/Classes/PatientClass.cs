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
        public string Nombre { set; get;  }
        public string Apellido { set; get; }
        public string Cedula { set; get; } 
        public string Peso { set; get; }
        public string Altura { set; get; }
        public string FechaNacimiento { set; get; }
        
    }
}
