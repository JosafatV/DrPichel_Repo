using System;
using System.Net;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Java;

using DoctorApp_Android.JSONParser;

namespace DotorApp_Android
{
    [Activity(Label = "DotorApp_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Loads the main layout (login)
            SetContentView(Resource.Layout.Main);

            //button assignment and action
            Button LoginButton = FindViewById<Button>(Resource.Id.btnLogin);
            LoginButton.Click += (sender, e) =>
            {

                //get inputed credentials
                String Username = (String)FindViewById<EditText>(Resource.Id.txtUsername);
                String Password = (String)FindViewById<EditText>(Resource.Id.txtPassword);

                //send data to DB--

                //get this from DB
                String Rol = "D";
                String UserId = "1";

                if (Rol.Equals("D"))
                {
                    var scheduleView = new Intent(this, typeof(ScheduleActivity));
                    scheduleView.PutExtra(UserId, Rol); //send info to next view
                    StartActivity(scheduleView);
                } else if (Rol.Equals("P"))
                {
                    var addCitaView = new Intent(this, typeof(AddCitaActivity));
                    addCitaView.PutExtra(UserId, Rol); //send info to next view
                    StartActivity(addCitaView);
                } else
                {
                    TextView txtWarning = FindViewById<TextView>(Resource.Id.txtLoginWarning);
                    //txtWarning.SetText("Error iniciando sesión; Rol no identificado");
                    txtWarning.SetText(1);
                }
            };
              
        }
    }
}

