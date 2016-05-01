using System.Text;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

using Org.Json;
using DoctorApp_Android;


namespace DoctorApp_Android.JSONParser
{
    public class JSONParser
    {
        //Converts a string with the data for a patient insert
        private void patientToJSON(string raw)
        {
            //code
        }

        public void loginToJSON(string uname, string pwrod)
        {
            try
            {
                JSONObject parent = new JSONObject();
                JSONObject jsonObject = new JSONObject();
                JSONArray jsonArray = new JSONArray();


            }
            catch (JSONException e)
            {
                e.PrintStackTrace();
            }

        }

        //formats a JSON file into a useful string array for the schedule layout
        private string JSONtoCita(string JSON)
        {
            //code
            return JSON;
        }

        //formats a JSON file into a useful string array for the history layout
        private string JSONtoHistorial(string JSON)
        {
            //code
            return JSON;
        }

        //formats a JSON file into a useful string array for the patient list layout
        private string JSONtoPatientList(string JSON)
        {
            //code
            return JSON;
        }
    }
}