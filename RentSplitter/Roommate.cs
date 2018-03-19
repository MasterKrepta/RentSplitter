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
    public class Roommate {
        private string name;
        private bool hasKids = false;
        private bool hasPets = false;
        private string monthlyPayment;

        public string Name { get => name; set => name = value; }
        public bool HasKids { get => hasKids; set => hasKids = value; }
        public bool HasPets { get => hasPets; set => hasPets = value; }
        public string MonthlyPayment { get => monthlyPayment; set => monthlyPayment = value; }
    }
}