using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using AndroidX.AppCompat.Widget;

namespace Jentzsch_Sudoku
{
    //[Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat.DayNight", MainLauncher = true)]
    [Activity(MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private SharedPref sharedPref;

        private Button btnStart;
        private ImageButton btnSettings;
        private Spinner spDifficulty;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            sharedPref = new SharedPref(this);

            if (sharedPref.getNightModeState())
                Delegate.SetLocalNightMode(AppCompatDelegate.ModeNightYes);
            else
                Delegate.SetLocalNightMode(AppCompatDelegate.ModeNightNo);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
     
            btnStart = FindViewById<Button>(Resource.Id.btnStart);
            btnSettings = FindViewById<ImageButton>(Resource.Id.btnSettings);
            spDifficulty = FindViewById<Spinner>(Resource.Id.spDifficulty);

            if (sharedPref.getNightModeState())
                btnSettings.SetBackgroundResource(Resource.Drawable.settings_white_24dp);
            else
                btnSettings.SetBackgroundResource(Resource.Drawable.settings_black_24dp);

            ArrayAdapter adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.difficulty_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spDifficulty.Adapter = adapter;

            btnSettings.Click += (sender, e) =>
            {
                StartActivity(typeof(SettingsActivity));
                OverridePendingTransition(Resource.Animation.slide_in_right, Resource.Animation.slide_out_right);
            };

            btnStart.Click += (sender, e) =>
            {
                StartActivity(typeof(GameActivity));
                OverridePendingTransition(Resource.Animation.slide_in_right, Resource.Animation.slide_out_right);
            };
        }
    }
}