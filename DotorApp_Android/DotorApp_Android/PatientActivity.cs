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
    [Activity(Label = "PatientActivity")]
    public class PatientActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Loads the layout (Patient)
            SetContentView(Resource.Layout.Patient);

            // Create your application here
            Button btnToCitas = FindViewById<Button>(Resource.Id.btnSeeCitasfromPatient);
            btnToCitas.Click += (sender, e) =>
            {
                var scheduleView = new Intent(this, typeof(ScheduleActivity));
                StartActivity(scheduleView);
            };
            
        }

        protected override void OnStart()
        {
            base.OnStart();

            //load initial data from DB
            DateTime dt = new DateTime();
            string date = dt.ToString();
            Console.Write(date); //print date to console

            //Populate ListView
        }

        //Functions
    }
}

