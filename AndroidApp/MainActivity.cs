namespace AndroidApp
{
    using Android.App;
    using Android.OS;
    using Android.Widget;

    [Activity(Label = "AndroidApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var Helper = new SharedProject.MySharedCode();
            new AlertDialog.Builder(this)
                .SetMessage(Helper.GetFilePath("demo.dat"))
                .Show();

            // Set our view from the "main" layout resource
            // SetContentView(Resource.Layout.Main);
        }
    }
}

