using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using System.Collections.Generic;

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
                var intent = new Intent(this, typeof(ActivitLogin));
                intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
                StartActivity(intent);
            };
           
        }
    }
}

