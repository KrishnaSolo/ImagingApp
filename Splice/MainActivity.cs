using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace Splice
{
    [Activity(Label = "@string/Splice", Theme = "@style/AppCompact", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState) 
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText username = FindViewById<EditText>(Resource.Id.username);
            EditText password = FindViewById<EditText>(Resource.Id.password);
            TextView textView1 = FindViewById<TextView>(Resource.Id.textView1);
            Button EnterButton = FindViewById<Button>(Resource.Id.EnterButton);

            EnterButton.Click += (sender, e) =>
            {
                string success = Core.Splice.Login(username.Text, password.Text);
                if (success.Contains("accepted"))
                {
                    var intent = new Intent(this, typeof(Activity1));
                    StartActivity(intent);
                }
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}