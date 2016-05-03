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

namespace DotorApp_Android
{
    [Activity(Label = "ScheduleActivity")]
    public class ScheduleActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Loads the layout (schedule)
            SetContentView(Resource.Layout.Schedule);

            // Movement buttons
            Button btnToAddPatient = FindViewById<Button>(Resource.Id.btnAddPatient);
            {
                var addPatientsView = new Intent(this, typeof(AddPatientActivity));
                StartActivity(addPatientsView);
            };

            Button btnToPatient = FindViewById<Button>(Resource.Id.btnSeePatient);
            {
                var PatientsView = new Intent(this, typeof(PatientActivity));
                StartActivity(PatientsView);
            };

            //(do, while)
            //make POST to retrieve data from the db

            //use an iterative function to fill the view

            //wire the button to refresh
        }
    }
}