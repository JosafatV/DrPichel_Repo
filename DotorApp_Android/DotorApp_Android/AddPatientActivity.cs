using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using DoctorApp_Android.JSONParser;

namespace DotorApp_Android
{
    [Activity(Label = "AddPatientActivity")]
    public class AddPatientActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Loads the layout (addPatient)
            SetContentView(Resource.Layout.AddPatient);

            Button btnToCitas = FindViewById<Button>(Resource.Id.btnSeeCitasfromAddPatient);
            {
                var scheduleView = new Intent(this, typeof(ScheduleActivity));
                StartActivity(scheduleView);
            };

            /*
            Button ClearButton = FindViewById<Button>(Resource.Id.btnClear); 
            ClearButton.Click += (sender, e) =>
            {
                EditText Nombre = FindViewById<EditText>(Resource.Id.txtNombre);
                EditText Apellido = FindViewById<EditText>(Resource.Id.txtApellido);
                EditText Cedula = FindViewById<EditText>(Resource.Id.txtCedula);
                EditText Altura = FindViewById<EditText>(Resource.Id.txtAltura);
                EditText Peso = FindViewById<EditText>(Resource.Id.txtPeso);
                EditText Genero = FindViewById<EditText>(Resource.Id.txtGenero);
                EditText FechaNacimiento = FindViewById<EditText>(Resource.Id.txtFechaNacimiento);

                //set text in camps to ""

            };

            Button submitButton = FindViewById<Button>(Resource.Id.btnSubmit);
            submitButton.Click += (sender, e) =>
            {
                //get data from GUI
                String Nombre = (String)FindViewById<EditText>(Resource.Id.txtNombre);
                String Apellido = (String)FindViewById<EditText>(Resource.Id.txtApellido);
                String Cedula = (String)FindViewById<EditText>(Resource.Id.txtCedula);
                String Altura = (String)FindViewById<EditText>(Resource.Id.txtAltura);
                String Peso = (String)FindViewById<EditText>(Resource.Id.txtPeso);
                String Genero = (String)FindViewById<EditText>(Resource.Id.txtGenero);
                String FechaNacimiento = (String)FindViewById<EditText>(Resource.Id.txtFechaNacimiento);

                //Parse data into json format
                JSONParser jsp = new JSONParser();
                string json = jsp.patientToJSON(Nombre, Apellido, Cedula, Altura, Peso, Genero, FechaNacimiento);

                //post data
            };*/

        }
    }
}