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
using BusinessApp.Droid.Engine;
using BusinessApp.Engine;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(CloseApplication))]
namespace BusinessApp.Droid.Engine
{
    public class CloseApplication : ICloseApplication
    {
        public void ExitApplication()
        {
            var activity = (Android.App.Activity)Forms.Context;
            activity.FinishAffinity();
        }
    }
}