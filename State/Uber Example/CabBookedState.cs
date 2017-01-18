using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class CabBookedState:ICabState
    {        
        public CabBookedState()
        {

        }

        public void Book(UberCab cab)
        {
            Console.WriteLine($"{cab.Name} can't be booked since its already booked");
        }

        public void Cancelled(UberCab cab)
        {
            Console.WriteLine($"{cab.Name} has been cancelled");
            cab.CabState = new CabAvailableState();
        }

        public void RideComplete(UberCab cab)
        {
            Console.WriteLine($"{cab.Name} ride can't be complete since trip has not started");
        }

        public void StartTrip(UberCab cab)
        {
            Console.WriteLine($"{cab.Name} trip started");
            cab.CabState = new CabInTransitState();
        }
    }
}
