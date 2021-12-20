using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Jentzsch_Sudoku
{
    [Activity(Label = "SettingsActivity")]
    public class SettingsActivity : AppCompatActivity
    {
        private SharedPref sharedPref;
        private Switch swDark;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            sharedPref = new SharedPref(this);
            if (sharedPref.getNightModeState())
                Delegate.SetLocalNightMode(AppCompatDelegate.ModeNightYes);
            else
                Delegate.SetLocalNightMode(AppCompatDelegate.ModeNightNo);
            // Create your application here
            SetContentView(Resource.Layout.activity_settings);

            swDark = FindViewById<Switch>(Resource.Id.swDarkTheme);

            if (sharedPref.getNightModeState())
                swDark.Checked = true;
            else
                swDark.Checked = false;

            swDark.CheckedChange += (sender, e) =>
            {
                Delegate.ApplyDayNight();
            };
        }
    }
}