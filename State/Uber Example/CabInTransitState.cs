using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class CabInTransitState : ICabState
    {
        public CabInTransitState()
        {

        }

        public void Book(UberCab cab)
        {
            Console.WriteLine($"{cab.Name} is unavailable");
        }

        public void Cancelled(UberCab cab)
        {
            Console.WriteLine($"{cab.Name} can't be cancelled since its in transit");            
        }

        public void RideComplete(UberCab cab)
        {
            Console.WriteLine($"{cab.Name} ride completed");
            cab.CabState = new CabAvailableState();
        }

        public void StartTrip(UberCab cab)
        {
            Console.WriteLine($"{cab.Name} is already in transit");
        }
    }
}
