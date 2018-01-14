using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Util;

namespace ActivityLifeCycle
{
    [Activity(Label = "First Activity", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int count = 0;

        protected override void OnCreate(Bundle bundle)
        {
            Log.Debug(GetType().FullName, "First Activity - onCreate");
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            FindViewById<Button>(Resource.Id.button1).Click += (sender, args) =>
            {
                var intent = new Intent(this, typeof(SecondActivity));
                StartActivity(intent);
            };

            if(bundle != null)
            {
                count = bundle.GetInt("clickCount", 0);
                Log.Debug(GetType().FullName, "First Activity - Recovered Instance State");
            }
        }


        protected override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutInt("clickCount", count);
            Log.Debug(GetType().FullName, "First Activity - saving Instance state");
            base.OnSaveInstanceState(outState);
        }
        protected override void OnDestroy()
        {
            Log.Debug(GetType().FullName, "First Activity - On Destroy");
            base.OnDestroy();
        }

        protected override void OnPause()
        {
            Log.Debug(GetType().FullName, "First Activity - On Pause");
            base.OnPause();
        }

        protected override void OnRestart()
        {
            Log.Debug(GetType().FullName, "First Activity - On Restart");
            base.OnRestart();
        }

        protected override void OnResume()
        {
            Log.Debug(GetType().FullName, "First Activity - On Resume");
            base.OnResume();
        }

        protected override void OnStart()
        {
            Log.Debug(GetType().FullName, "First Activity - On Start");
            base.OnStart();
        }

        protected override void OnStop()
        {
            Log.Debug(GetType().FullName, "First Activity - On stop");
            base.OnStop();
        }
    }
}