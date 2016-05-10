using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Java.Net;
using Java.IO;
using Java.Util;
using Javax.Net;

namespace DoctorApp_Android.Client
{
    class ClientService
    {
        //String url = "http://sebastian95:8090/api/Paciente";
        Uri uri = new Uri("http://sebastian95:8090/api/Paciente");

        public String Post(String json)
        {

            WebClient client = new WebClient();
            client.UploadStringAsync(uri, json);

            //get response from server
            //String response = client.DownloadString(uri);

            string response = "response";

            return response;
            //parse response to get uID and Rol (JSONtoLogin)
        }

        /*
        public String HttpPost(String json)
        {
            InputStream inputStream = null;
            String result = "";
            try
            {
                //create Http client
                HttpClient httpclient = new DefaultHttpClient();

                //make POST request
                HttpPost httppost = new HttpPost(url);

                //make json String and entity string
                StringEntity se = new StringEntity(json);

                // set httpPost Entity
                httpPost.setEntity(se);

                // Http headers
                httppost.setHeader("Accept", "Application/json");
                httppost.setHeader("Content-type", "application/json");

                //execute post
                HttpResponse httpResponse = httpclient.execute(httppost);

                //receive response as input stream
                inputStream = httpResponse.getEntity().getContent();

                //convert response to string
                if (inputStream != null)
                    result = ConvertInputStreamToString(inputStream);
                else
                    result = "Did not work";
            }
            catch
            {
                Log.d("InputStream", e.getLocalizedMessage());
            }
        }*/
    }
}
           
