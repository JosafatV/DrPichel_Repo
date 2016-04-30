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

//import JSON library

namespace DotorApp_Android
{
    [Activity(Label = "ActivitLogin")]
    public class ActivitLogin : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            //Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            EditText Username = FindViewById<EditText>(Resource.Id.txtUsername);
            EditText Password = FindViewById<EditText>(Resource.Id.txtPassword);
            Button LoginButton = FindViewById<Button>(Resource.Id.btnLogin);

            LoginButton.Enabled = false;

            String Usernamen = string.Empty;
            String Passwrd = string.Empty;

            try
            {
                JSONObject parent = new JSONObject();
                JSONObject jsonObject = new JSONObject();
                JSONArray jsonArray = new JSONArray();

                jsonArray.put("Username");
                jsonArray.put("Password");
                jsonObject.put("mk1", "mv1");
                jsonObject.put("mk2", jsonArray);
                parent.put("k2", jsonObject);
                Log.d("output", parent.toString(2));
            } catch (JSONException e) {
                e.printStackTrace()}
            }
        }