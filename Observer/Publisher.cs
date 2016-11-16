using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Publisher
    {
        private Observer observer;

        public Publisher(Observer o)
        {
            observer = o;
        }

        public int ID { get; set; }

        public void Update()
        {
            observer.Notify(this);
        }
    }
}
