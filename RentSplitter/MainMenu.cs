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

namespace RentSplitter {
    [Activity(Label = "MainMenu")]
    public class MainMenu : Activity {

        Button btnViewRoomates;
        Button btnViewBills;
        Button btnAddRoommate;
        Button btnAddBill;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MainMenu);

            btnViewRoomates = FindViewById<Button>(Resource.Id.btnViewRoommates);
            btnViewRoomates.Click += (o, e) => {
                Intent viewRoomates = new Intent(this, typeof(ViewRoommates));
                StartActivity(viewRoomates);

            };

            btnViewBills = FindViewById<Button>(Resource.Id.btnViewBills);
            btnViewBills.Click += (o, e) =>{ 
                Intent viewBills = new Intent(this, typeof(ViewBills));
                StartActivity(viewBills);
            };

            btnAddRoommate = FindViewById<Button>(Resource.Id.btnAddRoommate);
            btnAddRoommate.Click += (o, e) => {
                Intent addRoomate = new Intent(this, typeof(AddRoommate));
                StartActivity(addRoomate);

            };

            btnAddBill = FindViewById<Button>(Resource.Id.btnAddNewBill);
            btnAddBill.Click += (o, e)  =>{
                Intent addBill = new Intent(this, typeof(AddBill));
                StartActivity(addBill);
            };
        }
    }
}