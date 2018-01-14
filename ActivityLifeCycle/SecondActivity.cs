using Android.App;
using Android.OS;
using Android.Util;



namespace ActivityLifeCycle
{
    [Activity(Label = "Second Activity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            Log.Debug(GetType().FullName, "Second Activity - OnCreate");
            base.OnCreate(bundle);
        }

        protected override void OnRestart()
        {
            Log.Debug(GetType().FullName, "Second Activity - OnRestart");
            base.OnRestart();
        }

        protected override void OnStart()
        {
            Log.Debug(GetType().FullName, "Second Activity - OnStart");
            base.OnStart();
        }

        protected override void OnResume()
        {
            Log.Debug(GetType().FullName, "Second Activity - OnResume");
            base.OnResume();
        }

        protected override void OnPause()
        {
            Log.Debug(GetType().FullName, "Second Activity - Onpause");
            base.OnPause();
        }

        protected override void OnStop()
        {
            Log.Debug(GetType().FullName, "Second Activity - Onstop");
            base.OnStop();
        }

        protected override void OnDestroy()
        {
            Log.Debug(GetType().FullName, "Second Activity - ondestroy");
            base.OnDestroy();
        }
    }
}