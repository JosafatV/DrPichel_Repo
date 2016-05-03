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
    [Activity(Label = "AddCitaActivity")]
    public class AddCitaActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Loads the layout (Patient)
            SetContentView(Resource.Layout.AddCita);

            // Create your application here
            scheduleView.PutExtra("PatientView"); //send info to next view
        }
    }
}