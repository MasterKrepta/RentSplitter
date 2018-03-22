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
    [Activity(Label = "AddBill")]

    public class AddBill : Activity {
        Button btnSend;
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.AddBills);

            btnSend = FindViewById<Button>(Resource.Id.btnSendBill);
            btnSend.Click += (o, e) => {

                AddBillToHousehold();
                this.Finish();
            };

        }

        void AddBillToHousehold() {

        }
    }
}