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
using DoctorApp_Android.Client;

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

            //ui assignments
            Button btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            EditText txtUsername = FindViewById<EditText>(Resource.Id.txtUsername);
            EditText txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            TextView txtWarning = FindViewById<TextView>(Resource.Id.txtLoginWarning);


            btnLogin.Click += (sender, e) =>
            {
                string Uname = txtUsername.ToString();
                string Pword = txtPassword.ToString();
                executeLogin(Uname, Pword);
            };
        }

        void executeLogin (string Uname, string Pword) {

            //turn arguments into JSON
            JSONParser parser = new JSONParser();
            string json = parser.loginToJSON(Uname, Pword);

            //send data to DB--
            //ClientService client = new ClientService();
            //string response = client.Post(json);
            
            //get this from DB
            String Rol = "P";
            String UserId = "1";

            //enter specific view
            if (Rol.Equals("D"))
            {
                var scheduleView = new Intent(this, typeof(ScheduleActivity));
                scheduleView.PutExtra(UserId, Rol); //send info to next view
                StartActivity(scheduleView);
            }
            else if (Rol.Equals("P"))
            {
                var addCitaView = new Intent(this, typeof(AddCitaActivity));
                addCitaView.PutExtra(UserId, Rol); //send info to next view
                StartActivity(addCitaView);
            }
            else
            {
                //txtWarning.SetText("Error iniciando sesión; Rol no identificado");
            }
        }
    }
}

