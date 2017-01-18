using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public enum CabState
    {
        Available,
        NotAvailable
    }

    public class UberCab
    {
        ICabState cabState=new CabAvailableState();

        public ICabState CabState
        {
            get
            {
                return cabState;
            }

            set
            {
                cabState = value;
            }
        }

        public int ID { get; set; }

        public string Name { get { return $"Cab {ID}"; } }

        internal void Book()
        {
            if (ID == -1)
            {
                Console.WriteLine("No cabs available");
                return;
            }
            CabState.Book(this);
        }

        public void StartRide()
        {
            CabState.StartTrip(this);
        }

        internal void Cancelled()
        {
            CabState.Cancelled(this);
        }

        public void RideComplete()
        {
            CabState.RideComplete(this);
        }

        void ChangeState(ICabState cabState)
        {
            this.CabState = cabState;
        }
    }
}
