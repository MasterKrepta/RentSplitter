using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace RentSplitter {
    [Activity(Label = "RentSplitter", MainLauncher = true)]
    public class MainActivity : Activity {
        Button btnStart;


        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.StartPage);

            btnStart = FindViewById<Button>(Resource.Id.btn_Start);
            btnStart.Click += (o, e) => {
                Intent menu = new Intent(this, typeof(MainMenu));
                StartActivity(menu);

            };



        }

    }
}

