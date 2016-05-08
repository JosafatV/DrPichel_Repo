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
                HistoryView.PutExtra("PatientView", true); //send return info to next view
                StartActivity(HistoryView);
            };
        }

        void executeAddCitaAux(EditText txtNoDoc, EditText txtFecha, TextView txtAddCitaWarning)
        {
            string NoDoc = txtNoDoc.ToString();
            string Fecha = txtFecha.ToString();
            if (NoDoc.Equals("") || Fecha.Equals(""))
            {
                txtAddCitaWarning.SetText(1);
            } else
            {
                executeAddCita(NoDoc, Fecha);
            }
            
        }

        void executeAddCita (string NoDoctor, string Timestamp)
        {
            JSONParser parser = new JSONParser();
            string json = parser.citaToJSON(NoDoctor, Timestamp);

            ClientService client = new ClientService();
            string response = client.Post(json);

        }


    }
}