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
    [Activity(Label = "ViewBills")]
    public class ViewBills : Activity {
        Button btnGoBack;
        TextView counter;
        int numBills = 0;
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ViewBills);

            counter = FindViewById<TextView>(Resource.Id.txtBillCounter);
            btnGoBack = FindViewById<Button>(Resource.Id.btnGoBack);

            foreach (Bill bill in Household.Instance.Bills) {
                numBills++;
                counter.Text = numBills.ToString();

            }


            btnGoBack.Click += (o, e) => {

                
                this.Finish();
            };
        }

        
    }
}