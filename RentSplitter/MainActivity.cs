using Android.App;
using Android.Widget;
using Android.OS;

namespace RentSplitter {
    [Activity(Label = "RentSplitter", MainLauncher = true)]
    public class MainActivity : Activity {
        Button btnAddRoommate;
        
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.StartPage);
            btnAddRoommate = FindViewById<Button>(Resource.Id.btn_Start);
            btnAddRoommate.Click += (o, e) => SetContentView(Resource.Layout.AddRoommate);
        }

    }
}

