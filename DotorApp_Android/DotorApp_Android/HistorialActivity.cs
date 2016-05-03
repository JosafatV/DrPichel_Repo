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
    [Activity(Label = "HistorialActivity")]
    public class HistorialActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Loads the layout (Patient)
            SetContentView(Resource.Layout.Historial);

            // This string determines to which vew go back
            String fromView = "DoctorView"; 

            Button btnVolver = FindViewById<Button>(Resource.Id.btnVolverDeHistorial);
            btnVolver.Click += (sender, e) =>
            {
                if (fromView.Equals("DoctorView"))
                {
                    var pacientesView = new Intent(this, typeof(PatientActivity));
                    StartActivity(pacientesView);
                }
                else // "PaientView"
                {
                    var addCitaView = new Intent(this, typeof(AddCitaActivity));
                    StartActivity(addCitaView);
                }
            };
        }
    }
}