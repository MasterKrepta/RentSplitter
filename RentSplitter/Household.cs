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

   
    public class Household {
        
        #region Singleton
        private static Household instance;
        
        public static Household Instance {
            get {
                if(instance == null) {
                    instance = new Household();
                }
                return instance;
            }
        }
        #endregion

        private List<Roommate> roommates = new List<Roommate>();
        private List<Bill> bills = new List<Bill>();

        internal List<Roommate> Roommates { get => roommates; set => roommates = value; }
        internal List<Bill> Bills { get => bills; set => bills = value; }

        public void ListAllRoommates() {
            foreach (Roommate roommate in Roommates) {
                //TODO display list to app screen
            }
        }

        public void RemoveRoommate() {

        }

        public void AddRoommate(Roommate roommate) {
            Roommates.Add(roommate);
            Console.WriteLine("\nRoommate added");
        }

        public void AddBill(Bill bill) {
            Bills.Add(bill);
            Console.WriteLine("\nBill added");
        }
    }
}