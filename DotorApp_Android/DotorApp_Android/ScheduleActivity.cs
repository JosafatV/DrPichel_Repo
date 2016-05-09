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
using Android.Util;

using DoctorApp_Android.JSONParser;
using DoctorApp_Android.Client;

namespace DotorApp_Android
{
    [Activity(Label = "ScheduleActivity")]
    public class ScheduleActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Loads the layout (schedule) Log.Info("DotorApp_Android", ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Loading Schedule View");
            SetContentView(Resource.Layout.Schedule);
            
            // Movement buttons
            Button btnToAddPatient = FindViewById<Button>(Resource.Id.btnAddPatient);
            btnToAddPatient.Click += (sender, e) =>
            {
                var addPatientsView = new Intent(this, typeof(AddPatientActivity));
                StartActivity(addPatientsView);
            };
            
            Button btnToPatient = FindViewById<Button>(Resource.Id.btnSeePatient);
            btnToPatient.Click += (sender, e) =>
            {
                var PatientsView = new Intent(this, typeof(PatientActivity));
                StartActivity(PatientsView);
            };
        }

        protected override void OnStart()
        {
            base.OnStart();
            populateView();
        }

        protected override void OnRestart()
        {
            base.OnRestart();
            populateView();
        }

        private void populateView()
        {
            //load initial data from DB
            JSONParser json = new JSONParser();
            ClientService client = new ClientService();
            DateTime dt = new DateTime();

            string date = dt.ToString();

            Log.Info("DoctorApp_Android", "-----------------------------------------------------------------");
            Log.Info("DoctorApp_Android", date);

             client.Post(json.requestSchedule() );

            json.JSONtoSchedule();

            //Populate ListView
        }
    }
}