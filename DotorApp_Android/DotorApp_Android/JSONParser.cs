using System.Text;
using Org.Json;


namespace JSONParser
{
    public static class JSONParser
    {
        //Converts a string with the data for a patient insert
        private static void patientToJSON(string raw)
        {
            //code
        }

        private static void loginToJSON(string raw)
        {
            String JSONfile = string.Empty;

            try
            {
                JSONObject parent = new JSONObject();
                JSONObject jsonObject = new JSONObject();
                JSONArray jsonArray = new JSONArray();

                jsonArray.Put("Username");
                jsonArray.Put("Password");
                jsonObject.Put("mk1", "mv1");
                jsonObject.Put("mk2", jsonArray);
                parent.Put("k2", jsonObject);
                Log.d("output", parent.ToString(2));
            }
            catch (JSONException e)
            {
                e.PrintStackTrace();
            }
        }

        //formats a JSON file into a useful string array for the schedule layout
        private static string JSONtoCita(string JSON)
        {
            //code
            return JSON;
        }

        //formats a JSON file into a useful string array for the history layout
        private static string JSONtoHistorial(string JSON)
        {
            //code
            return JSON;
        }

        //formats a JSON file into a useful string array for the patient list layout
        private static string JSONtoPatientList(string JSON)
        {
            //code
            return JSON;
        }
    }
}