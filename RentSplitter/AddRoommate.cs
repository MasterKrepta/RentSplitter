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
    [Activity(Label = "AddRoommate")]
    public class AddRoommate : Activity {
        Roommate roommate = new Roommate();
        Button submitRoommate;
        EditText edtName;
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AddRoommate);
            edtName = FindViewById<EditText>(Resource.Id.edtName);

            edtName.Click += delegate {
                edtName.Text = "";
            };
            submitRoommate = FindViewById<Button>(Resource.Id.btnSendRoommate);
            submitRoommate.Click += (o, e) => {

                AddRoommateToHousehold();
                this.Finish();
            };
            
        }

        protected void AddRoommateToHousehold() {
            roommate.Name = edtName.Text.ToUpper();
            CheckBox chkKids = FindViewById<CheckBox>(Resource.Id.ck_hasKids);
            CheckBox chkPets = FindViewById<CheckBox>(Resource.Id.ck_hasPets);
            if (chkKids.Checked) {
                roommate.HasKids = true;
            }
            if (chkPets.Checked) {
                roommate.HasPets = true;
            }
            roommate.MonthlyPayment = "400"; // TEMP TODO: Calculate based on the number of people in the household and the total bills

            Household.Instance.AddRoommate(roommate);
            
        }
    }
}