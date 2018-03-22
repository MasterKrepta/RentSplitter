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
    [Activity(Label = "ViewRoommates")]
    public class ViewRoommates : Activity {
        Button btnBack;
        ListView lstListOfRoommates;
        TextView counter;
        int numRoommates = 0;
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ViewRoommates);

            counter = FindViewById<TextView>(Resource.Id.txtCounter);
            btnBack = FindViewById<Button>(Resource.Id.btnGoBack);
            lstListOfRoommates = FindViewById<ListView>(Resource.Id.lstRoommateList);

            //ArrayAdapter<Roommate> adapter = new ArrayAdapter<Roommate>(this, Resource.Layout.ViewRoommates, Household.Instance.Roommates);
            //lstListOfRoommates.SetAdapter(adapter);


            foreach (Roommate roommate in Household.Instance.Roommates) {
                numRoommates++;
                counter.Text = numRoommates.ToString();
                
            }


            btnBack.Click += (o, e) => {
                this.Finish();
            };


        }
    }
}