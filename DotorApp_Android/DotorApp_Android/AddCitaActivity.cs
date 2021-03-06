using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;
using Android.Widget;

using DoctorApp_Android.JSONParser;
using DoctorApp_Android.Client;

namespace DotorApp_Android
{
    [Activity(Label = "AddCitaActivity")]
    public class AddCitaActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Loads the layout (Patient)
            SetContentView(Resource.Layout.AddCita);

            //ui
            EditText txtNoDoc = FindViewById<EditText>(Resource.Id.txtNombreDoctor);
            EditText txtFecha = FindViewById<EditText>(Resource.Id.txtCitaTimetamp);
            TextView txtWarning = FindViewById<TextView>(Resource.Id.txtAddCitaWarning);

            Button btnAddCita = FindViewById<Button>(Resource.Id.btnAddCita);
            btnAddCita.Click += (sender, e) =>
            {
                executeAddCitaAux(txtNoDoc, txtFecha, txtWarning);
            };

            Button btnSeeHistory = FindViewById<Button>(Resource.Id.btnVerHistorial);
            btnSeeHistory.Click += (sender, e) =>
            {
                var HistoryView = new Intent(this, typeof(HistorialActivity));
                StartActivity(HistoryView);
            };
        }

        void executeAddCitaAux(EditText txtNoDoc, EditText txtFecha, TextView txtAddCitaWarning)
        {
            string NoDoc = txtNoDoc.Text.ToString();
            string Fecha = txtFecha.Text.ToString();
            if (NoDoc.Equals("") || Fecha.Equals(""))
            {
                txtAddCitaWarning.SetText("Todos los espacios son requeridos", null);
            } else
            {
                executeAddCita(NoDoc, Fecha);
            }
            
        }

        void executeAddCita (string NoDoctor, string Timestamp)
        {
            JSONParser parser = new JSONParser();
            string json = parser.citaToJSON(NoDoctor, Timestamp);
            Log.Info("DoctorApp_Android", "-----------------------------------------------------");
            Log.Info("DoctorApp_Android", json);

            ClientService client = new ClientService();
            //string response = client.Post(json);
            //parser.JSONtoCita(response);
        }
    }
}