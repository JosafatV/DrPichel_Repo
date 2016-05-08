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
            
            // Bind the ui
            EditText Nombre = FindViewById<EditText>(Resource.Id.txtNombre);
            EditText Apellido = FindViewById<EditText>(Resource.Id.txtApellido);
            EditText Cedula = FindViewById<EditText>(Resource.Id.txtCedula);
            EditText Altura = FindViewById<EditText>(Resource.Id.txtAltura);
            EditText Peso = FindViewById<EditText>(Resource.Id.txtPeso);
            EditText Genero = FindViewById<EditText>(Resource.Id.txtGenero);
            EditText FechaNacimiento = FindViewById<EditText>(Resource.Id.txtFechaNacimiento);
            TextView Warning = FindViewById<TextView>(Resource.Id.txtAddPatientWarning);

            Button btnToCitas = FindViewById<Button>(Resource.Id.btnSeeCitasfromAddPatient);
            btnToCitas.Click += (sender, e) =>
            {
                var scheduleView = new Intent(this, typeof(ScheduleActivity));
                StartActivity(scheduleView);
            };

            Button ClearButton = FindViewById<Button>(Resource.Id.btnClear); 
            ClearButton.Click += (sender, e) =>
            {
                executeClear(Nombre, Apellido, Cedula, Altura, Peso, Genero, FechaNacimiento, Warning);
            };

            Button submitButton = FindViewById<Button>(Resource.Id.btnSubmit);
            submitButton.Click += (sender, e) =>
            {
                executeSubmitAux(Nombre, Apellido, Cedula, Altura, Peso, Genero, FechaNacimiento, Warning);
            };
        }
        
        void executeClear(EditText Nombre, EditText Apellido, EditText Cedula, EditText Altura, EditText Peso, EditText Genero, EditText FechaNacimiento, TextView Warning)
        {
            Nombre.SetText(0);
            Apellido.SetText(0);
            Cedula.SetText(0);
            Altura.SetText(0);
            Peso.SetText(0);
            Genero.SetText(0);
            FechaNacimiento.SetText(0);
            Warning.SetText(0);
        }

        void executeSubmitAux(EditText txtNombre,EditText txtApellido,EditText txtCedula,EditText txtAltura,EditText txtPeso,EditText txtGenero,EditText txtFechaNacimiento,TextView txtWarning)
        {
            string Nombre = txtNombre.ToString();
            string Apellido = txtApellido.ToString();
            string Cedula = txtCedula.ToString();
            string Altura = txtAltura.ToString();
            string Peso = txtPeso.ToString();
            string Genero = txtGenero.ToString();
            string FechaNacimiento = txtFechaNacimiento.ToString();

            //validate inputs
            if (Nombre.Equals("") || Apellido.Equals("") || Cedula.Equals("") || Altura.Equals("") || Peso.Equals("") || Genero.Equals("") || FechaNacimiento.Equals(""))
            {
                txtWarning.SetText(1);
            } else
            {
                executeSubmit(Nombre, Apellido, Cedula, Altura, Peso, Genero, FechaNacimiento);
            }
        }

        void executeSubmit(string Nombre, string Apellido, string Cedula, string Altura, string Peso, string Genero, string FechaNacimiento)
        {
            //Parse data into json format
            JSONParser jsp = new JSONParser();
            string json = jsp.patientToJSON(Nombre, Apellido, Cedula, Altura, Peso, Genero, FechaNacimiento);

            //post data
        }
    }
}