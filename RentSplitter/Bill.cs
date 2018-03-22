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
    public class Bill {
        private List<Roommate> responsibleRoomates;
        private string name;
        private float cost;


        public List<Roommate> ResponsibleRoomates { get => responsibleRoomates; set => responsibleRoomates = value; }
        public string Name { get => name; set => name = value; }
        public float Cost { get => cost; set => cost = value; }


        
    }
}