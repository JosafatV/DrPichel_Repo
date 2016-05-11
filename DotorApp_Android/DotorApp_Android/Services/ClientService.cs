using System;
using System.Net;
using System.Net.Http;
using System.Json;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;
using System.Threading.Tasks;


using System.Net.Http.Headers;


using Org.Json;

namespace DoctorApp_Android.Client
{

    public class Paciente
    {
        public string idUsuario;
        public string cedula;
        public string password;
        public string nombre;
        public string apellido;
        public string FechaNacimiento;
        public string Residencia;
        public string Estado;
        public string peso;
        public string altura;

    }


    class ClientService
    {
        string url = "http://sebastian95:8090/api/Paciente";
        Uri uri = new Uri("http://sebastian95:8090/api/Paciente");

        /*
        public String Post(String json)
        {

            WebClient client = new WebClient();
            client.UploadStringAsync(uri, json);

            //get response from server
            //String response = client.DownloadString(uri);

            string response = "response";

            return response;
            //parse response to get uID and Rol (JSONtoLogin)
        }*/

        /*
        public String HttpPost(String json)
        {
            InputStream inputStream = null;
            String result = "";
            try
            {
                //create Http client
                HttpClient httpclient = new HttpClient();

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
                Log.Info("InputStream", e.getLocalizedMessage());
            }
        }*/

        public void newPost()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------Making API Call...");
            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                //client.BaseAddress = new Uri("http://sebastian95:8090/api/Paciente");
                HttpResponseMessage response = client.GetAsync("").Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Result: " + result);
            }
            Console.ReadLine();
        }

        public async void DownloadPageAsync()
        {
            // ... Target page.
            string page = "http://sebastian95:8090/";

            // ... Use HttpClient.
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                string result = await content.ReadAsStringAsync();

                // ... Display the result.
                if (result != null &&
             result.Length >= 50)
                {
                    Console.WriteLine(result.Substring(0, 50) + "...");
                }
            }
        }

        public async  void get(string uri)
        {
            JSONObject json = new JSONObject();
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);

            //will throw an exception if not successful
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            Console.Write(content);
        }

        public async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://sebastian95:8090/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync("/api/Doctor/Ciudades"); 
                if (response.IsSuccessStatusCode)   
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    // Paciente paciente = await response.Content.ReadAsAsync<Paciente>();
                    //Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
                    Console.Write(responseString);
                }
            }
        }
    }
}
           
