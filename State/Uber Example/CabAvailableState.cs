using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class CabAvailableState : ICabState
    {
        public CabAvailableState()
        {

        }

        public void Book(UberCab cab)
        {
            Console.WriteLine($"{cab.Name} booked");
            cab.CabState = new CabBookedState();
        }

        public void Cancelled(UberCab cab)
        {
            Console.WriteLine($"{cab.Name} can't be cancelled since its not booked");            
        }

        public void RideComplete(UberCab cab)
        {
            Console.WriteLine($"{cab.Name} ride can't be complete since its not booked");
        }

        public void StartTrip(UberCab cab)
        {
            Console.WriteLine($"{cab.Name} cant start trip since its not booked");
        }
    }
}
