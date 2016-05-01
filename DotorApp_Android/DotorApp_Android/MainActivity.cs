using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using System.Collections.Generic;
using DoctorApp_Android.JSONParser;


namespace DotorApp_Android
{
    [Activity(Label = "DotorApp_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Button LoginButton = FindViewById<Button>(Resource.Id.btnLogin);
            LoginButton.Click += (sender, e) =>
            {
                //get inputed credentials
                String Username = (String)FindViewById<EditText>(Resource.Id.txtUsername);
                String Password = (String)FindViewById<EditText>(Resource.Id.txtPassword);


                //turn credentials into JSON
                JSONParser jsp = new JSONParser();
                jsp.loginToJSON(Username, Password);

                //send credential

                //receive db credentials

                //set credentials
                Activo activeUser = new Activo();
                
                //proceed to appropriate rol view
                if (activeUser.getRol().Equals("D"))
                {
                    //go to view schedule
                } else if (activeUser.getRol().Equals("P"))
                {
                    //goto view historialP
                } else
                {
                    //goto view login 
                }

            };

            Button ClearButton = FindViewById<Button>(Resource.Id.btnClear);
            ClearButton.Click += (sender, e) =>
            {
                //code goes here
            };
            Button submitButton = FindViewById<Button>(Resource.Id.btnSubmit);
            submitButton.Click += (sender, e) =>
            {
                //code goes here
            };

        }
    }
}

