using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Uber
    {
        List<UberCab> cabs = new List<UberCab>();

        public Uber()
        {
            while (cabs.Count < 10)
                cabs.Add(new UberCab() { ID = (cabs.Count + 1) });
        }

        public void Book()
        {
            var defaultCab = new UberCab() { ID = -1 };
            var availableCab = cabs.Where(x => x.CabState.GetType() == typeof(CabAvailableState)).DefaultIfEmpty(defaultCab).FirstOrDefault();
            if (availableCab != default(UberCab))
                availableCab.Book();            
        }

        public void Cancelled(int ID)
        {
            var matchFound = cabs.Where(x => x.ID == ID).First();
            matchFound.Cancelled();
        }

        public void StartTrip(int ID)
        {
            var matchFound = cabs.Where(x => x.ID == ID).First();
            matchFound.StartRide();
        }

        public void RideComplete(int ID)
        {
            var matchFound = cabs.Where(x => x.ID == ID).First();
            matchFound.RideComplete();
        }       
    }
}
