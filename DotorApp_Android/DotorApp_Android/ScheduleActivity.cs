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
using Android.Util;

using DoctorApp_Android.JSONParser;
using DoctorApp_Android.Client;
using DotorApp_Android.Classes;

namespace DotorApp_Android
{
    [Activity(Label = "ScheduleActivity")]
    public class ScheduleActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Loads the layout (schedule) Log.Info("DotorApp_Android", ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Loading Schedule View");
            SetContentView(Resource.Layout.Schedule);
            
            // Movement buttons
            Button btnToAddPatient = FindViewById<Button>(Resource.Id.btnAddPatient);
            btnToAddPatient.Click += (sender, e) =>
            {
                var addPatientsView = new Intent(this, typeof(AddPatientActivity));
                StartActivity(addPatientsView);
            };
            
            Button btnToPatient = FindViewById<Button>(Resource.Id.btnSeePatient);
            btnToPatient.Click += (sender, e) =>
            {
                var PatientsView = new Intent(this, typeof(PatientActivity));
                StartActivity(PatientsView);
            };
        }

        protected override void OnStart()
        {
            base.OnStart();
            populateView();
        }

        protected override void OnRestart()
        {
            base.OnRestart();
            populateView();
        }

        private void populateView()
        {
            DateTime dt = new DateTime();
            string date = dt.ToString();

            Log.Info("DoctorApp_Android", "------------------------------------------------------------------------schedulestartdate:");
            Log.Info("DoctorApp_Android", date);

            //client.Post(json.requestSchedule() );
            List<ScheduleClass> citas = new List<ScheduleClass>();
            citas = getData();

            //Populate ListView
            ListView lvwcitas = FindViewById<ListView>(Resource.Id.lvwCitas);
            lvwcitas.ItemLongClick += Lvwcitas_ItemLongClick; //enable::do on long click



        }

        private void Lvwcitas_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            //code goes here
            Log.Info("DoctorApp_Android", "---------------------------------------------------------------------argsfromlistviewschedule:");
            //Log.Info("DoctorApp_Android", sender);
        }

        private List<ScheduleClass> getData()
        {
            List<ScheduleClass> citas = new List<ScheduleClass>();
            JSONParser json = new JSONParser();
            ClientService client = new ClientService();

            //request from DB and convert to schedulaclass array
            //citas.Add(new ScheduleClass() { });

            return citas;
        }
    }
}