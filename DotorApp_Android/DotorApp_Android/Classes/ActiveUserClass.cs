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

namespace DotorApp_Android
{
    public class ActiveUserClass
    {
        public String aUser;
        public String Rol;

        public void setActiveUser(String Username, String newRol)
        {
            this.aUser = Username;
            this.Rol = newRol;
        } 

        public String getUsername()
        {
            return this.aUser;
        }

        public String getRol()
        {
            return this.Rol;
        }

    }
}