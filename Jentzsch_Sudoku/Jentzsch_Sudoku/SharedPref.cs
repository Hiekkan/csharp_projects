using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Jentzsch_Sudoku
{
    class SharedPref
    {
        private ISharedPreferences sharedPref;
        private ISharedPreferencesEditor editor;
        private Context context;

        public SharedPref(Context context)
        {
            this.context = context;
            sharedPref = PreferenceManager.GetDefaultSharedPreferences(context);
            editor = sharedPref.Edit();
        }

        public void setNightModeState(bool state)
        {
            editor.PutBoolean("Nightmode", state);
            editor.Apply();
        }

        public bool getNightModeState() { return sharedPref.GetBoolean("Nightmode", false); }
    }
}