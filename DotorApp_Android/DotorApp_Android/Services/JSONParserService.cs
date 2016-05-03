using System.Text;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

using Java;
using Org.Json;
using DoctorApp_Android;


namespace DoctorApp_Android.JSONParser
{
    public class JSONParser
    {
        //Converts a string with the data for a patient insert
        public string  patientToJSON(string _nombre, string _apellido, string _cedula, string _altura, string _peso, string _genero, string _nacimiento)
        {
            JSONObject parent = new JSONObject();
            //ActiveUser active = new ActiveUser();
            try
            {
                //parent.Put(active.getUsername);
                parent.Put("Nombre", _nombre);
                parent.Put("Apellido", _apellido);
                parent.Put("Cedula", _cedula);
                parent.Put("Altura", _altura);
                parent.Put("Peso", _peso);
                parent.Put("Genero", _genero);
                parent.Put("FechaNacimiento", _nacimiento);

                string json = parent.ToString(1); //1 = human readible
                return json;

            } catch
            {
                return null;
            }
        }

        public string loginToJSON(string _uname, string _pword)
        {
            JSONObject parent = new JSONObject();
            //ActiveUser active = new ActiveUser();
            try
            {
                //parent.Put(active.getUsername);
                parent.Put("username", _uname);
                parent.Put("password", _pword);
                string json = parent.ToString(1);  //1 = human readible

                return json;

            }
            catch (JSONException e)
            {
                e.PrintStackTrace();
                return null;
            }

        }

        public string citaToJSON(string _NoDoctor, string _Timestamp)
        {
            JSONObject parent = new JSONObject();
            //ActiveUser active = new ActiveUser();
            try
            {
                //parent.Put(active.getUsername);
                parent.Put("NoDoctor", _NoDoctor);
                parent.Put("Fecha", _Timestamp);
                string json = parent.ToString(1);  //1 = human readible

                return json;
            } catch (JSONException e)
            {
                e.PrintStackTrace();
                return null;
            }
        }

        //formats a JSON file into a useful string array for the schedule layout
        public string JSONtoCita(string JSON)
        {
            //code
            return JSON;
        }

        //formats a JSON file into a useful string array for the history layout
        public string JSONtoHistorial(string JSON)
        {
            //code
            return JSON;
        }

        //formats a JSON file into a useful string array for the patient list layout
        public string JSONtoPatientList(string JSON)
        {
            //code
            return JSON;
        }
    }
}