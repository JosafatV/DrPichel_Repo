using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;

using DoctorApp_Android.JSONParser;
using DoctorApp_Android.Client;

namespace DotorApp_Android
{
    [Activity(Label = "DotorApp_Android", MainLauncher = true, Icon = "@drawable/Prime_helix")]
    public class MainActivity : Activity
    {
        //variables
        string userId = "";
        string Rol = "P";

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Loads the main layout (login)
            SetContentView(Resource.Layout.Main);

            //ui assignments
            View Main = FindViewById<View>(Resource.Layout.Main);
            EditText txtUsername = FindViewById<EditText>(Resource.Id.txtUsername);
            EditText txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            TextView txtWarning = FindViewById<TextView>(Resource.Id.txtLoginWarning);

            RadioButton rdbPatient = FindViewById<RadioButton>(Resource.Id.rdbPatient);
            rdbPatient.Click += (sender, e) =>
            {
                Rol = "P";
                Log.Info("DoctorApp_android", "-------------------------------> Rol = P");
            };

            RadioButton rdbDoctor = FindViewById<RadioButton>(Resource.Id.rdbDoctor);
            rdbDoctor.Click += (sender, e) =>
            {
                Rol = "D";
                Log.Info("DoctorApp_android", "-------------------------------> Rol = D");
            };

            Button btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnLogin.Click += (sender, e) =>
            {
                executeLoginAux(txtUsername, txtPassword, txtWarning);
            };
        }

        void executeLoginAux(EditText txtUsername, EditText txtPassword, TextView txtLoginWarning)
        {
            string Uname = txtUsername.Text.ToString();
            string Pword = txtPassword.Text.ToString();

            if (Uname.Equals("") || Pword.Equals(""))
            {
                txtLoginWarning.SetText("Todos los espacios son requeridos", null);
            }
            else
            {
                executeLogin(Uname, Pword);
            }

        }

        void executeLogin(string Uname, string Pword)
        {
            List<string> userValues = new List<string>();

            //turn arguments into JSON
            JSONParser parser = new JSONParser();
            string json = parser.loginToJSON(Uname, Pword);
            Log.Info("DotorApp_Android", json);

            /*//send data to DB
            ClientService client = new ClientService();
            client.RunAsync().Wait();
            //string response = client.Post(json);
            userValues.Add(userId); //userID
            */

            //enter specific view
            if (Rol.Equals("D"))
            {
                var scheduleView = new Intent(this, typeof(ScheduleActivity));
                userValues.Add("DoctorsView");
                scheduleView.PutStringArrayListExtra("userValues", userValues); //send info to next view
                StartActivity(scheduleView);
            }
            else //if (Rol.Equals("P"))
            {
                var addCitaView = new Intent(this, typeof(AddCitaActivity));
                userValues.Add("PatientsView");
                addCitaView.PutStringArrayListExtra("userValues", userValues); //send info to next view
                StartActivity(addCitaView);
            }
        }
    }
}

